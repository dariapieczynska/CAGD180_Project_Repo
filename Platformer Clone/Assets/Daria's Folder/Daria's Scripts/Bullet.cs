using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Pieczynska, Daria & Parent, Ciela
//11/09/2023
//Bullets' speed and get destroyed when they hit a wall
public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="wall")
        {
            Destroy(gameObject);
        }
    }
    
}
