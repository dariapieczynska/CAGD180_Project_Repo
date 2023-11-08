using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Parent, Ciela
// 11/13/23
// Controls HardEnemy's health and damage it does to player

public class HardEnemy : MonoBehaviour
{
    public int lives = 10;
    public float maxDistance;
    public float minDistance;
    public float speed;
    public bool withinItsArea;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < minDistance)
        {
            withinItsArea = false;
            transform.position = new Vector3(minDistance, transform.position.y, transform.position.z);

        }
        else
        {
            withinItsArea = true;
        }
        if (transform.position.x > maxDistance)
        {
            withinItsArea = false;
            transform.position = new Vector3(maxDistance, transform.position.y, transform.position.z);

        }
        else
        {
            withinItsArea = true;
        }
        if (player.transform.position.x < transform.position.x &&  withinItsArea == true )
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else if (player.transform.position.x > transform.position.x && withinItsArea == true )
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if(lives<=0)
        {
            gameObject.SetActive(false);
        }
    }
    //if enemy gets hit with a regular bullet it will lose health
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RegularBullet")
        {
            loseMinHealth();
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "HeavyBullet") 
        {
            loseMaxHealth();
            other.gameObject.SetActive(false);
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
