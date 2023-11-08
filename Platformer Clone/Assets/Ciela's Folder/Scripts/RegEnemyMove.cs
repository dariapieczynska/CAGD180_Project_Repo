using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Parent, Ciela
// 11/13/23
// Handles the side to side movement, health of the regular enemy.
// Also handles damage done to the player

public class RegEnemyMove : MonoBehaviour
{
    public GameObject leftPoint;
    public GameObject rightPoint;
    private Vector3 lefttPos;
    private Vector3 rightPos;
    public int speed;
    public bool goingLeft;

    // Start is called before the first frame update
    void Start()
    {
        lefttPos = leftPoint.transform.position;
        rightPos = rightPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    //moves character left and right and sets boundary 
    private void Move() 
    {
        if (goingLeft) 
        {
            if (transform.position.x <= lefttPos.x) 
            {
                goingLeft = false;
            }
            else 
            {
                transform.position += Vector3.left * Time.deltaTime * speed;
            }
        }
        else 
        {
            if (transform.position.x >= rightPos.x) 
            {
                goingLeft = true;
            }
            else 
            {
                transform.position += Vector3.right * Time.deltaTime * speed;
            }
        }
    }
}
