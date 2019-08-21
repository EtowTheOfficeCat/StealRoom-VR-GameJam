using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Hand : MonoBehaviour
{
    public SteamVR_Action_Boolean PickUpAction = null;
    public GameObject HandObj;

    private SteamVR_Behaviour_Pose pose = null;
    private FixedJoint joint = null;

    private Interactable currentInteractable = null;
    
    public List<Interactable> contactInteractables = new List<Interactable>();

    private void Awake()
    {
        pose = GetComponent<SteamVR_Behaviour_Pose>();
        joint = GetComponent<FixedJoint>();

    }

    void Update()
    {
        if (PickUpAction.GetStateDown(pose.inputSource))
        {
            
            PickUp();
        }

        if (PickUpAction.GetStateUp(pose.inputSource))
        {
            
            Drop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Interactable"))
            return;

        contactInteractables.Add(other.gameObject.GetComponent<Interactable>());
    }

    private void OnTriggerExit(Collider other)
    {
        contactInteractables.Remove(other.gameObject.GetComponent<Interactable>());
    }

    public void PickUp()
    {
        currentInteractable = GetNearestInteractable();

        if (!currentInteractable)
            return;
        if (currentInteractable.ActiveHand)
            currentInteractable.ActiveHand.Drop();

        currentInteractable.transform.position = currentInteractable.transform.position;

        Rigidbody targetBody = currentInteractable.GetComponent<Rigidbody>();
        joint.connectedBody = targetBody;

        currentInteractable.ActiveHand = this;

        HandObj.SetActive(false);

    }
     public void Drop()
    {
        if (!currentInteractable)
            return;

        Rigidbody targetBody = currentInteractable.GetComponent<Rigidbody>();
        targetBody.velocity = pose.GetVelocity();
        targetBody.angularVelocity = pose.GetAngularVelocity();

        joint.connectedBody = null;

        currentInteractable.ActiveHand = null;
        currentInteractable = null;

        HandObj.SetActive(true);
    }

    private Interactable GetNearestInteractable()
    {
        Interactable nearest = null;
        float minDistance = float.MaxValue;
        float distance = 0.0f;

        foreach ( Interactable interactable in contactInteractables)
        {
            distance = (interactable.transform.position - transform.position).sqrMagnitude;

            if(distance < minDistance)
            {
                minDistance = distance;
                nearest = interactable;
            }
        }

        return nearest;
    }
}
