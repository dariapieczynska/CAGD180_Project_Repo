using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Parent, Ciela
// 11/13/23
// Handles damage done to the player, and the health of the regular enemy

public class RegularEnemy : MonoBehaviour
{
    public int lives = 1;

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    //if enemy gets hit with a regular bullet it will lose health
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RegularBullet")
        {
            loseHealth();
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "HeavyBullet")
        {
            loseMaxHealth();
            other.gameObject.SetActive(false);
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
