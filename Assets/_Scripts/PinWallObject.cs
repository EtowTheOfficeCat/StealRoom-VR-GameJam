using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinWallObject : Interactable
{
    
    public GameObject Point1;
    private Quaternion rotation1;
    private Vector3 Vector1;

    private void Start()
    {
        Vector1 = Point1.transform.position;
        rotation1 = Point1.transform.rotation;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PinWall")) 
        {
            this.transform.position = Vector1;
            this.transform.rotation = rotation1;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
