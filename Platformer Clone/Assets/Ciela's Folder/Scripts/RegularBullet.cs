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
    public GameObject bulletPrefab;
    public float spawnrate = 1f;
    public bool shootRight = false;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullet", 0, spawnrate);
    }
    /// <summary>
    /// shoots a bullet and sets whih direction it should go
    /// </summary>

    private void ShootBullet() 
    {
        GameObject laserInstance = Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
        laserInstance.GetComponent<Bullet>().goingRight = shootRight;
    }
    if //bullet hits player, 1 XP is taken away
    if // space bar "fire button" is pressed, a laser is released
    if // space bar is held, laser shoots at fire rate
    if // space bar is released, player stops shooting
}
