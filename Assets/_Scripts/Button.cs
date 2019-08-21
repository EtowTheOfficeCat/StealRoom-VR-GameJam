using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Transform PointA;
    public Transform PointB;
    float PointAZ;
    float PointBZ;

    private void Start()
    {
        PointAZ = PointA.position.y;
        PointBZ = PointB.position.y;

    }
    private void Update()
    {
        transform.position = new Vector3((transform.position.x), Mathf.Clamp(transform.position.y, PointBZ, PointAZ), (transform.position.z));
    }
}
