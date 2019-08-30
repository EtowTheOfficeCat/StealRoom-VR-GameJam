using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI myText;
    public Color newColor;
    public Color HalfColor;
    public Color OriginalColor;
   
    

    private void OnTriggerEnter(Collider other)
    {
        if (LightSwitch.RoomLightOn == true)
            return;

        if (other.CompareTag("Torch"))
        {
            myText.color = newColor;
        }

        if (other.CompareTag("OuterTorch"))
        {
            myText.color = HalfColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        myText.color = OriginalColor;
    }
}
