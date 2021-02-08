using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class PickItUp : MonoBehaviour
{
    public Transform theDest;

    void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("GO-Destination").transform;
        }

        // if (Input.GetKeyDown("Q"))
        // {
        // this.transform.parent = null;
        // GetComponent<Rigidbody>().useGravity = true;
        //}
        //}
    }
}
