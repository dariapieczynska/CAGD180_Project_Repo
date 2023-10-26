using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject regularBullet;
    public GameObject heavyBullet;
    public bool canShoot=true;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FireBullet();
    }
    public void FireBullet()
    {
        if (canShoot)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                //shooting a bullet
                Instantiate(regularBullet, transform.position, transform.rotation);
            }

        }
    }
}
