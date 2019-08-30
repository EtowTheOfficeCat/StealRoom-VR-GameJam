using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinWallObject : Interactable
{
    
    public GameObject Point1;
    public string Positiontext;
    private Rigidbody currentDrawer;
    private Quaternion rotation1;
    private Quaternion thisObjectRotation;
    private Vector3 Vector1;
    private bool enterCommode = false;
    public static bool pinned = false;
    private bool isInside = false;
    private float speed = 0.001f;


    private void Start()
    {
        Vector1 = Point1.transform.position;
        rotation1 = Point1.transform.rotation;

    }

    private void Update()
    {
        thisObjectRotation = this.transform.rotation;
    }

    private void FixedUpdate()
    {
        if(enterCommode == true)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            if(rb.velocity.sqrMagnitude < 0.5f)
            {
                enterCommode = false;
                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<Rigidbody>().isKinematic = true;
                GetComponent<Rigidbody>().velocity = Vector3.zero;
                GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
                this.transform.parent = currentDrawer.transform;
                Debug.Log($"enter drawer: {currentDrawer.name}");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Commode"))
        {
            Debug.Log("trigger entered");
            enterCommode = true;
            currentDrawer = other.transform.parent.GetComponent<Rigidbody>();
            


        }
        if (other.CompareTag("Player") )
        {
            if (pinned == true)
                return;

            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().useGravity = true;
            this.transform.parent = null;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        }
        if (other.CompareTag(Positiontext) ) 
        {
            pinned = true;
            this.transform.position = Vector1;
            this.transform.rotation = rotation1;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().isKinematic = true;
            
        }
    }
}
