using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject regularBullet;
    public GameObject heavyBullet;
    public bool canShoot=true;
    public bool heavyBulletObject = false; 

  
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
                if (heavyBulletObject)
                {
                    //shooting a bullet
                    Instantiate(heavyBullet, transform.position, transform.rotation);
                    StartCoroutine(CoolDown());
                }
                else
                {
                    Instantiate(regularBullet, transform.position, transform.rotation);
                    StartCoroutine(CoolDown());
                }
            }

        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag=="heavy_bullet")
        {
            Debug.Log("hit heavy bullet");
            heavyBulletObject=true;
            other.gameObject.SetActive(false);
        }
    }
    public IEnumerator CoolDown()
    {
        canShoot = false;
        yield return new WaitForSeconds(.5f);
        canShoot = true; 
    }
}
