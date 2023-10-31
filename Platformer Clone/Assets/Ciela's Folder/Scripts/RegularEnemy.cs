using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularEnemy : MonoBehaviour
{
    public int lives = 1;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RegularBullet")
        {
            loseHealth();
        }
    }
    public void loseHealth()
    {
        lives -= 1;
        {
            MeshRenderer mesh = GetComponent<MeshRenderer>();
            mesh.enabled = false;
        }
    }
}
