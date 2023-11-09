using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

// Parent, Ciela
// 11/13/23
// Controls players health and XP


public class PlayerHealth : MonoBehaviour
{
    //respawning variables
    public int lives = 99;
    public int fallDepth;
    private Vector3 startPosition;

    public int healthPack;
    public int startLives; 

    // Start is called before the first frame update
    void Start()
    {
        startLives = lives;

        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < fallDepth) 
        {
            LoseALife();
        }
    }
    //causes player to lose 15HP after getting hit by a regular enemy 
    public void loseMinHealth()
    {
        lives -= 15; 
        {
            MeshRenderer mesh = GetComponent<MeshRenderer>();
            mesh.enabled = false;
        }
        if (lives < 0) 
        {
            LoseALife();
        } 
    }
    private void OnTriggerEnter(Collider other)
    {
        //if we collide with a health pack trigger, it heals player to origionl health
     
        if(other.gameObject.tag=="health_pack")
        {
            if (lives <= lives-healthPack)
            {
                lives += healthPack;
            }
            else
            {
                lives = startLives;
            }
            other.gameObject.SetActive(false); 
        }
        //when collided with, the prefab extra_health will give the player 100HP (max health)
        if(other.gameObject.tag=="extra_health")
        {
            lives = startLives + 100;
            startLives = lives;
            other.gameObject.SetActive(false);
        }
        //if we collide with a portal trigger, teleport the player to the nect level.
        // and reset the starting point
        if (other.gameObject.tag == "Portal") 
        {
            //restart the startPos to the spawnPoint positio
            startPosition = other.gameObject.GetComponent<Portal>().spawnPoint.transform.position;
            //bring the player back to the start position
            transform.position = startPosition;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag== "RegularEnemy")
        {
            loseMinHealth();
        }
        if (collision.gameObject.tag == "HardEnemy")
        {
            loseMinHealth();
        }
    }

    // player loses 35 HP after gettin hit by a hard enemy
    public void loseMaxHealth() 
    {
        lives -= 35;
        {
            MeshRenderer mesh = GetComponent<MeshRenderer>();
            mesh.enabled = false;
        }
        if (lives < 0)
        {
            LoseALife();
        }
    }
    // couroutine causes player to blink after being shot
    public IEnumerator Blink() 
    {
        for (int index = 0; index < 30; index++) 
        {
            if (index % 2 == 0) 
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
            else 
            {
                GetComponent<MeshRenderer>().enabled = true;
            }
            yield return new WaitForSeconds(.1f);
        }
        GetComponent<MeshRenderer>().enabled = true;
    }
    private void LoseALife()
    {

        if (lives <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
    //sends player back to starting point
    //private void Respawn() 
    //  {
    //   transform.position = startPosition;
    //   lives--;

    //    if (lives <= 0) 
    //     {
    //       this.enabled = false;
    //    }
    //  }


}

