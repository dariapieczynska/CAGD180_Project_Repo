using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Parent, Ciela
// 10/23/23
// Controls players XP


public class PlayerHealth : MonoBehaviour
{

    //how many points a regualr bullet will take away
    //private float regBulletValue = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void LoseALife() 
    {
        Debug.Log("Player Lost a Life");
        //lives--;

        //if (lives == 0)
        {
            //Loads game over screen when player lives is 0
            SceneManager.LoadScene(1);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        // if the object trigger is enemy, add the value to the total score
        //then destroy the apple we collected
        
        if (other.gameObject.tag == "Enemy")
        {
            LoseALife();
            Destroy(other.gameObject);
        }
        
    }
}// player has 99 lives

