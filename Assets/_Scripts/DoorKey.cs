using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{
    public GameObject Door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            Door.AddComponent<InterActiveDoor>();
        }
    }
}
