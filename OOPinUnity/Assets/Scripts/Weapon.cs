
using System.Collections;
using UnityEngine;


public class Weapon : MonoBehaviour
{
    public int damageBonus;

    public Enemy enemyHoldingWeapon;

    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemeyEatsWeapon(enemyHoldingWeapon);
    }

    protected void EnemeyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats weapon");
    }
    public void Recharge()
    {
        Debug.Log("Recharging weapon");
    }
        
}
