using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [Header("Ziel")]
    public Transform target;

    [Header("Bewegung")]
    public bool moveMe = true;
    public float moveSpeed = 2f;

    private void Update()
    {

        if(InsertValueAtDash.correct) {
            Debug.Log(InsertValueAtDash.correct);

            if (moveMe && target != null)
            {
                transform.position = Vector3.Lerp(
                    transform.position,
                    target.position,
                    moveSpeed * Time.deltaTime);

                // Stoppen, wenn das Ziel nahezu erreicht ist
                if (Vector3.Distance(transform.position, target.position) < 0.01f)
                {
                    transform.position = target.position;
                    moveMe = false;
                }
            }
        }
    }
}