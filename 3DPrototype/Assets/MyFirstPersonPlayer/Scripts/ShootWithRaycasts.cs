using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycasts : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;
    public float hitForce = 10f;
    public ParticleSystem muzzleFlash;
    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        void Shoot()
        {
            muzzleFlash.Play();
            RaycastHit hitInfo;
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
            {
                Debug.Log(hitInfo.transform.gameObject);

                Target target = hitInfo.transform.gameObject.GetComponent<Target>();

                if (target != null)
                {
                    target.takeDamage(damage);
                }

                if (hitInfo.rigidbody != null)
                {
                    hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
                }
            }
        }
    }
}
