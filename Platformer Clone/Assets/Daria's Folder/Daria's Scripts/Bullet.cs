using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
