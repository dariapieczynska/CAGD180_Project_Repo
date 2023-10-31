using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;

// Parent, Ciela
// 10/23/23
// Handles when bullet is fired and how much XP is taken

public class RegularBullet : MonoBehaviour
{
    [Header("Projectole Variables")]
    public float speed;
    public bool goingLeft;

    
    //update is called once per frame
    void Update()
    {
        if (goingLeft == true) 
        {
            transform.position += speed * Vector3.left * Time.deltaTime;
        }
        else 
        {
            transform.position += speed * Vector3.right * Time.deltaTime;
        }
    }
}
