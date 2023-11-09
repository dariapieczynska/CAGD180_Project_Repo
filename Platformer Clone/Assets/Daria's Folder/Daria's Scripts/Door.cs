using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class Door : MonoBehaviour
{
 
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!(player.GetComponentInChildren<Gun>().heavyBulletNumber > 0))
        {
            return;
        }

        if(!(player.GetComponentInChildren<Gun>().jetpackNumber > 0))
        {
            return;

        }
        gameObject.SetActive(false);
    }
}
