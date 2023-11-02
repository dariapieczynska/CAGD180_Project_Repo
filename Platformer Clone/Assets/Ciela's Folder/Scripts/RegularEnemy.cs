using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularEnemy : MonoBehaviour
{
    public int lives = 1;

    // Update is called once per frame
    void Update()
    {
        
    }
    //if enemy gets hit with a regular bullet it will lose health
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RegularBullet")
        {
            loseHealth();
        }
        if (other.gameObject.tag == "HeavyBullet")
        {
            loseMaxHealth();
        }
    }
    //function for losing 1 HP
    public void loseHealth()
    {
        lives -= 1;
    }
    //function for losing 3HP
    public void loseMaxHealth()
    {
        lives -= 3;
    }


}
