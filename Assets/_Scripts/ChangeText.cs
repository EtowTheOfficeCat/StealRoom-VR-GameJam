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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.A))
        {
            myText.color = newColor;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
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
