using UnityEngine;
using UnityEngine.UI;
public class executeAction : MonoBehaviour
{
    public Scrollbar _scrollbar; 
    public void Klick() { Debug.Log("Klick"); }
    public void LogScrollbarValue() { Debug.Log("Scrollbar: " + _scrollbar.value); }
    public void CubeKlicked() { Debug.Log("CubeKlicked"); }
}