using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rigidBody;
    public int jumpForce = 10;
    public bool touchingTheGround;



    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        spaceJump();
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
        if (Input.GetKeyDown("space") && touchingTheGround==true)
        {
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
