using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Pieczynska, Daria & Parent, Ciela 
// 11/09/2023
// Gun picks up heavy bullets and has a cool down every half second. 
public class Gun : MonoBehaviour
{
    public GameObject regularBullet;
    public GameObject heavyBullet;
    public bool canShoot=true;
    public bool heavyBulletObject = false;
    public int heavyBulletNumber = 0;
    public int jetpackNumber = 0;
    public GameObject player; 
  
   

    // Update is called once per frame
    void Update()
    {
        FireBullet();
    }
    /// <summary>
    /// the gun fires a bullet
    /// </summary>
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
            heavyBulletNumber++;
        }
        if(other.tag=="jetpack")
        {
            jetpackNumber++;
            other.gameObject.SetActive(false);
            //player.AddComponent<JetPack>();
        }
      
        }
    public IEnumerator CoolDown()
    {
        canShoot = false;
        yield return new WaitForSeconds(.5f);
        canShoot = true; 
    }
}
