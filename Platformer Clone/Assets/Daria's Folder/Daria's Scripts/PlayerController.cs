using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidBody;
    public int jumpForce = 10;
    public bool touchingTheGround;
    public bool facingRight;
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
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    public void spaceJump()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.down), out hit, 5f))
        {
            touchingTheGround = true;
            Debug.Log("The player is touching the ground");
        }
        else
        {
            touchingTheGround = false;
            Debug.Log("The player is not touching the ground");
        }
        if (Input.GetKeyDown("space")|| Input.GetKeyDown(KeyCode.UpArrow) && touchingTheGround==true)
        {
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
