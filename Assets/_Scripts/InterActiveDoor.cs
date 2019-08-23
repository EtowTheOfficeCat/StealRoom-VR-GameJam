using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterActiveDoor : Interactable
{
    float minRotation = -1;
    float maxRotation = 90;

    private void Update()
    {
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.y = Mathf.Clamp(currentRotation.y, minRotation, maxRotation);
        transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
    
