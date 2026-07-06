using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class TwoKeyDoorOpener : MonoBehaviour
{
    [Header("Sockets")]
    public XRSocketInteractor socket1;
    public XRSocketInteractor socket2;

    [Header("Door")]
    public Transform doorPivot;
    public float openAngle = 90f;
    public float openSpeed = 2f;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip winSound;

    [Header("Hinweis")]
    public GameObject messageCanvas;
    public float messageDuration = 3f;

    private Quaternion closedRotation;
    private Quaternion openRotation;

    private bool doorOpened = false;

    void Start()
    {
        closedRotation = doorPivot.localRotation;
        openRotation = closedRotation * Quaternion.Euler(0f, openAngle, 0f);

        // Canvas beim Spielstart ausblenden
        if (messageCanvas != null)
        {
            messageCanvas.SetActive(false);
        }
    }

    void Update()
    {
        bool socket1HasKey = socket1.hasSelection;
        bool socket2HasKey = socket2.hasSelection;

        bool bothKeysInserted = socket1HasKey && socket2HasKey;

        // Tür nur einmal öffnen
        if (bothKeysInserted && !doorOpened)
        {
            doorOpened = true;

            // Sound abspielen
            if (audioSource != null && winSound != null)
            {
                audioSource.PlayOneShot(winSound);
            }

            // Hinweis anzeigen
            StartCoroutine(ShowMessage());
        }

        Quaternion targetRotation = doorOpened ? openRotation : closedRotation;

        doorPivot.localRotation = Quaternion.Lerp(
            doorPivot.localRotation,
            targetRotation,
            Time.deltaTime * openSpeed
        );
    }

    IEnumerator ShowMessage()
    {
        if (messageCanvas != null)
        {
            messageCanvas.SetActive(true);

            yield return new WaitForSeconds(messageDuration);

            messageCanvas.SetActive(false);
        }
    }
}