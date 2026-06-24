using UnityEngine;
using TMPro;

public class PianoPuzzleManager : MonoBehaviour
{
    public GameObject key;
    public TMP_Text noteDisplay;

    private string[] correctSequence =
    {
        "E",
        "G",
        "C",
        "A",
        "F",
        "D",
        "B"
    };

    private int currentIndex = 0;

    // <-- HIER Schritt 3 einfügen
    void Start()
    {
        UpdateDisplay();
    }

    public void AddNote(string note)
    {
        if (note == correctSequence[currentIndex])
        {
            currentIndex++;

            UpdateDisplay();

            if (currentIndex >= correctSequence.Length)
            {
                PuzzleSolved();
            }
        }
        else
        {
            currentIndex = 0;

            UpdateDisplay();
        }
    }

    private void UpdateDisplay()
    {
        string display = "";

        for (int i = 0; i < correctSequence.Length; i++)
        {
            if (i < currentIndex)
            {
                display += correctSequence[i] + " ";
            }
            else
            {
                display += "- ";
            }
        }

        noteDisplay.text = display;
    }

    void PuzzleSolved()
    {
        key.SetActive(true);
    }
}