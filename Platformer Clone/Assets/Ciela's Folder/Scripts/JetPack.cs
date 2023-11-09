using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JetPack : MonoBehaviour
{
    public float jetPackForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("Space")) 
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jetPackForce);
        }
    }
}
