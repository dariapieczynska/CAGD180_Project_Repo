using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Pieczynska, Daria & Parent, Ciela
//11/09/2023
//the camera follows the player

public class Camera : MonoBehaviour
{
    public GameObject player;



    

    private void LateUpdate()
    {
        Vector3 tempPos = transform.position;
        tempPos.x = player.transform.position.x;
        tempPos.y = player.transform.position.y;
        transform.position = tempPos;
    }
}