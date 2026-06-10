using UnityEngine;

public class ButtonPressAnimation : MonoBehaviour
{
    Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    public void Press()
    {
        StopAllCoroutines();
        StartCoroutine(Animate());
    }

    System.Collections.IEnumerator Animate()
    {
        transform.localPosition =
            startPos + Vector3.down * 0.01f;

        yield return new WaitForSeconds(0.1f);

        transform.localPosition = startPos;
    }
}