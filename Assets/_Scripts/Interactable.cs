using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Interactable : MonoBehaviour
{
    [HideInInspector]
    public Hand ActiveHand = null;
    public Vector3 PinWallPosition;
    

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PinWall"))
        {
            transform.position = PinWallPosition;
        }
    }
}
