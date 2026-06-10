using UnityEngine;

public class KeypadButton : MonoBehaviour
{
    public string number;

    public KeypadController keypad;

    public void Press()
    {
        keypad.AddNumber(number);
    }
}