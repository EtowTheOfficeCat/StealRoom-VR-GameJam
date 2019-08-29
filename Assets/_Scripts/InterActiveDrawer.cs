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
        PointAZ = PointA.position.x;
        PointBZ = PointB.position.x;

    }
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, PointBZ, PointAZ), (transform.position.y), (transform.position.z));
    }


}
