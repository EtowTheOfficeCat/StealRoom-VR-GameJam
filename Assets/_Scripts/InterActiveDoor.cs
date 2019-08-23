using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterActiveDoor : Interactable
{
    float minRotation = -1;
    float maxRotation = 90;
    private Vector3 rotation;
    private int rotate = 1;
    private int RateOfRotate = 1;

    private void Update()
    {
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.y = Mathf.Clamp(currentRotation.y, minRotation, maxRotation);
        //transform.localRotation = Quaternion.Euler(currentRotation);

        //rotation = this.transform.eulerAngles;
        //float rotationY = rotation.y + rotate * RateOfRotate;
        //rotationY = Mathf.Clamp(rotationY, minRotation, maxRotation);
        //rotation.y = rotationY;
        //this.transform.eulerAngles = rotation;
    }
}
    
