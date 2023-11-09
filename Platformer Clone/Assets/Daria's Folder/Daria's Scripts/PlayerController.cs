using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// Pieczynska, Daria & Parent, Ciela
//11/09/2023
//Player moves right and left 
public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidBody;
    public int jumpForce = 5;
    public bool touchingTheGround;
    public bool facingRight = true;
    public float speed = 10f;
  



    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        spaceJump();

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            TurnLeft();

            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            TurnRight();
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

    }

    public void spaceJump()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 3f))
        {
            touchingTheGround = true;
            Debug.Log("The player is touching the ground");
        }
        else
        {
            touchingTheGround = false;
            Debug.Log("The player is not touching the ground");
        }
        if (Input.GetKeyDown("space") && touchingTheGround == true || Input.GetKeyDown(KeyCode.UpArrow) && touchingTheGround == true)
        {
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    public void TurnLeft()
    {
        if (Input.GetKeyDown("a") || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (facingRight)
            {
                facingRight = false;
                transform.Rotate(Vector3.up * 180);
            }
        }
    }
    public void TurnRight()
    {
        if(Input.GetKeyDown("d") || Input.GetKeyDown(KeyCode.RightArrow))
    {
            if (!facingRight)
            {
                facingRight = true;
                transform.Rotate(Vector3.up * 180);
            }
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag=="jump_higher")
        {
            jumpForce = 7;
            other.gameObject.SetActive(false);
        }
    }


}
