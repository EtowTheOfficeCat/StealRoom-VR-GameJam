using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InterActiveDrawer : Interactable
{
    public Transform PointA;
    public Transform PointB;
    float PointAZ;
    float PointBZ;

    private void Start()
    {
        PointAZ = PointA.position.z;
        PointBZ = PointB.position.z;

    }
    private void Update()
    {
        transform.position = new Vector3((transform.position.x), (transform.position.y), Mathf.Clamp(transform.position.z, PointBZ, PointAZ));
    }
}
