using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Interactable : MonoBehaviour
{
    [HideInInspector]
    public Hand ActiveHand = null;
    

    private void OnTriggerEnter(Collider other)
    {
        
    }

}
