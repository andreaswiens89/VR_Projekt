using UnityEngine;

public class spiel_starten_audio : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip sound1;
    public AudioClip sound2;

    public void PlaySound()
    {
        audioSource.PlayOneShot(sound1);
        audioSource.PlayOneShot(sound2);
    }
}