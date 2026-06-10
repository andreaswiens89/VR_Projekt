using TMPro;
using UnityEngine;

public class KeypadController : MonoBehaviour
{
    public TMP_Text displayText;

    private string enteredCode = "";

    void Start()
    {
        displayText.text = "";
    }

    public void AddNumber(string number)
    {
        enteredCode += number;

        displayText.text = enteredCode;
    }
}