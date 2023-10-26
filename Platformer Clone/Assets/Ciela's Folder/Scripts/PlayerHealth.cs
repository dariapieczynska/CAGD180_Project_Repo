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
        lives -= 15; 
        {
            MeshRenderer mesh = GetComponent<MeshRenderer>();
            mesh.enabled = false;
        }
    }// to blink make new courutine
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

