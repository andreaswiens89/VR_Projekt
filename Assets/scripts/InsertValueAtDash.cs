using UnityEngine;
using TMPro;

public class InsertValueAtDash : MonoBehaviour
{
    [Header("Textobjekt")]
    public TextMeshProUGUI targetText;

    [Header("Einzutragender Wert")]
    public string valueToInsert = "0";

    [Header("Leerer Zustand")]
    public string defaultText = "- - - -";

    [Header("Richtiger Code")]
    public string correctCode = "1670";

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip successSound;
    public AudioClip failSound;

    [Header("Schublade")]
    //public DrawerMover drawerMover;
    public static bool correct = false;


    public void InsertValue()
    {
        if (targetText == null)
            return;

        string text = targetText.text;

        int dashIndex = text.IndexOf('-');

        if (dashIndex == -1)
            return;

        string result = text.Remove(dashIndex, 1)
                            .Insert(dashIndex, valueToInsert);

        targetText.text = result;
    }

    public void ResetText()
    {
        if (targetText == null)
            return;

        targetText.text = defaultText;
    }

    public void CheckCode()
    {
        if (targetText == null)
            return;

        // Leerzeichen entfernen
        string enteredCode = targetText.text.Replace(" ", "");

        if (enteredCode == correctCode)
        {
            Debug.Log("Code korrekt!");

            if (audioSource != null && successSound != null)
                audioSource.PlayOneShot(successSound);
            correct = true;

           // if (drawerMover != null)
             //   drawerMover.OpenDrawer();
        }
        else
        {
            Debug.Log("Code falsch!");

            if (audioSource != null && failSound != null)
                audioSource.PlayOneShot(failSound);

            // Eingabe zurücksetzen
            ResetText();
        }
    }
}