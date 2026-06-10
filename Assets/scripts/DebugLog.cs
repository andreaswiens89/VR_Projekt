using UnityEngine;
using UnityEngine.Rendering;

public class DebugLog : MonoBehaviour
{
    public GameObject visible;
    public void logme()
    {
        visible.SetActive(true);
        Debug.Log("Entered");
    }



}
