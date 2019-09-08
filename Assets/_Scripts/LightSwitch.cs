using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightSwitch : MonoBehaviour
{
    public GameObject RoomLight;
    public static bool RoomLightOn = true;

    private int counter = 0;

    
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            
            if (!RoomLight.activeSelf)
            {
                Debug.Log("light not active");
                RoomLight.SetActive(true);
                RoomLightOn = true;
                
            }
            else if (RoomLight.activeSelf)
            {
                Debug.Log("light active");
                RoomLight.SetActive(false);
                RoomLightOn = false;
            } 
        }
    }

  
}
