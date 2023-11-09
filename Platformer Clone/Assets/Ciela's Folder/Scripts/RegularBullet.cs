using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEngine;

// Parent, Ciela
// 11/13/23
// Handles the speed and direction of a regular bullet

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
    //destroy itself after 5 seconds?
}
