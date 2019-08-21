using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CodePanel : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI codeText;
    [SerializeField] TextMeshProUGUI codeTextRight;
    string codeTextValue = "";
    string rightCode = "Right Code";
    string wrongCode = "wrong code";

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
            
    }

    public void EnterCode()
    {
        if (codeTextValue == "0101")
        {
            codeTextRight.text = rightCode;
            codeTextValue = "";
        }
        else
            codeTextRight.text = wrongCode;
            codeTextValue = "";

    }
}
