/*
 * Jacob Zydorowicz
 * Prototype1
 * triggers lose when player falls
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseOnFall : MonoBehaviour
{
    public Text textbox;
    private void Update()
    {
            if (transform.position.y < -1)
            {
            ScoreManager.gameOver = true;
            }
     
    }
  
}
