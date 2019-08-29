using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinWallObject : Interactable
{
    
    public GameObject Point1;
    public string Positiontext;
    private Quaternion rotation1;
    private Quaternion thisObjectRotation;
    private Vector3 Vector1;


    private void Start()
    {
        Vector1 = Point1.transform.position;
        rotation1 = Point1.transform.rotation;

    }

    private void Update()
    {
        thisObjectRotation = this.transform.rotation;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Commode"))
        {
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
            this.transform.parent = other.transform;
        }
        if (other.CompareTag("Player") )
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().useGravity = true;
            this.transform.parent = null;
            
        }
        if (other.CompareTag(Positiontext) ) 
        {
            this.transform.position = Vector1;
            this.transform.rotation = rotation1;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
