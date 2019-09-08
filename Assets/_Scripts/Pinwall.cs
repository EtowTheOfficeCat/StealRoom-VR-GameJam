using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinwall : MonoBehaviour
{
    
    public GameObject door2;
    private int allThere = 7;
    private int counter = 0;


    private void Update()
    {
        if(allThere == counter)
        { 
        
            door2.AddComponent<Interactable>();
        }

        Debug.Log(allThere);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            counter += 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Interactable"))
        {
            counter -= 1;
        }
    }

}
