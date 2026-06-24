using UnityEngine;

public class PianoPlayer : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip noteC;
    public AudioClip noteD;
    public AudioClip noteE;
    public AudioClip noteF;
    public AudioClip noteG;
    public AudioClip noteA;
    public AudioClip noteB;

    public PianoPuzzleManager puzzleManager;
    

    public void PlayC()
    {
        audioSource.PlayOneShot(noteC);

        puzzleManager.AddNote("C");
    }

    public void PlayD()
    {
        audioSource.PlayOneShot(noteD);

        puzzleManager.AddNote("D");
    }

    public void PlayE()
    {
        audioSource.PlayOneShot(noteE);

        puzzleManager.AddNote("E");
    }

    public void PlayF()
    {
        audioSource.PlayOneShot(noteF);

        puzzleManager.AddNote("F");
    }

    public void PlayG()
    {
        audioSource.PlayOneShot(noteG);

        puzzleManager.AddNote("G");
    }

    public void PlayA()
    {
        audioSource.PlayOneShot(noteA);

        puzzleManager.AddNote("A");
    }

    public void PlayB()
    {
        audioSource.PlayOneShot(noteB);

        puzzleManager.AddNote("B");
    }
}