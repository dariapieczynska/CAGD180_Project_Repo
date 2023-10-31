using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

// Parent, Ciela
// 10/23/23
// Controls players XP


public class PlayerHealth : MonoBehaviour
{
    public int lives = 99;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    //causes player to lose 15HP after getting hit by a regular enemy 
    public void loseMinHealth()
    {
        lives -= 15; 
        {
            MeshRenderer mesh = GetComponent<MeshRenderer>();
            mesh.enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Regular Enemy") 
        {
            loseMinHealth();
        }
        if (other.gameObject.tag == "Hard Enemy") 
        {
            loseMaxHealth();
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

  
}

