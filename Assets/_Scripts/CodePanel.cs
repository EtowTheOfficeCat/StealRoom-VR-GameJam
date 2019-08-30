using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CodePanel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI codeText;
    [SerializeField] TextMeshProUGUI codeTextRight;
    [SerializeField] GameObject Door;
    [SerializeField] GameObject CodeButtons;
    [SerializeField] GameObject codeButtonsNew;



    string codeTextValue = "";
    string rightCode = "Right Code";
    string wrongCode = "wrong code";

    private void Start()
    {
        
        
    }
    private void Update()
    {
        codeText.text = codeTextValue;

       

        if(codeTextValue.Length > 4)
        {
            codeTextValue = "";
            codeTextRight.text = wrongCode;
        }
    }

    

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.CompareTag("ButtonEnter"))
        {
            EnterCode();
        }

        if (other.CompareTag("Button1"))
        {
            codeTextValue += 1;
            codeTextRight.text = "";
        }
            

        if (other.CompareTag("Button0"))
        {
            codeTextValue += 0;
            codeTextRight.text = "";
        }

        if (other.CompareTag("Button2"))
        {
            codeTextValue += 2;
            codeTextRight.text = "";
        }

        if (other.CompareTag("Button3"))
        {
            codeTextValue += 3;
            codeTextRight.text = "";
        }

        if (other.CompareTag("Button4"))
        {
            codeTextValue += 4;
            codeTextRight.text = "";
        }

        if (other.CompareTag("Button5"))
        {
            codeTextValue += 5;
            codeTextRight.text = "";
        }

        if (other.CompareTag("Button6"))
        {
            codeTextValue += 6;
            codeTextRight.text = "";
        }

        if (other.CompareTag("Button7"))
        {
            codeTextValue += 7;
            codeTextRight.text = "";
        }

        if (other.CompareTag("Button8"))
        {
            codeTextValue += 8;
            codeTextRight.text = "";
        }

        if (other.CompareTag("Button9"))
        {
            codeTextValue += 9;
            codeTextRight.text = "";
        }


    }

    public void EnterCode()
    {
        if (codeTextValue == "0000")
        {
            codeTextRight.text = rightCode;
            codeTextValue = "";
            
            Door.AddComponent<InterActiveDoor>();
            CodeButtons.SetActive(false);
            codeButtonsNew.SetActive(true);
        }
        else
            codeTextRight.text = wrongCode;
            codeTextValue = "";

    }
}
