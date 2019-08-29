using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class HandAnimation : MonoBehaviour
{
    public SteamVR_Action_Single GrabAction = null;
    private Animator animator = null;
    private SteamVR_Behaviour_Pose pose = null;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        pose = GetComponentInParent<SteamVR_Behaviour_Pose>();

        GrabAction[pose.inputSource].onChange += Grab;
    }

    private void OnDestroy()
    {
        GrabAction[pose.inputSource].onChange -= Grab;
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("Point", true);

    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("Point", false);
    }
    private void Grab(SteamVR_Action_Single action, SteamVR_Input_Sources source, float axis, float delta)
    {
        animator.SetFloat("GrabBlend", axis);
    }
}
