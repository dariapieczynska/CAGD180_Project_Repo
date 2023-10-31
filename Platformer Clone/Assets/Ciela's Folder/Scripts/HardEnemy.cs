using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardEnemy : MonoBehaviour
{
    public int lives = 10;

    // Update is called once per frame
    void Update()
    {
        
    }
    //if enemy gets hit with a regular bullet it will lose health
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RegularBullet")
        {
            loseMinHealth();
        }
        if (other.gameObject.tag == "HeavyBullet") 
        {
            loseMaxHealth();
        }
    }
    //function for losing 1 HP
    public void loseMinHealth()
    {
        lives -= 1;
    }
    //function for losing 3HP
    public void loseMaxHealth() 
    {
        lives -= 3;
    }
}
