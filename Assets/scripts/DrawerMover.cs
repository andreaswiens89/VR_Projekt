using UnityEngine;

public class DrawerMover : MonoBehaviour
{
    public Transform drawer;
    public Transform target;
    public float speed = 1f;

    public bool moveDrawer = false;

    private void Update()
    {
        if (moveDrawer)
        {
            drawer.position = Vector3.MoveTowards(
                drawer.position,
                target.position,
                speed * Time.deltaTime);

            if (Vector3.Distance(drawer.position, target.position) < 0.001f)
            {
                drawer.position = target.position;
                moveDrawer = false;
            }
        }
    }

    public void OpenDrawer()
    {
        moveDrawer = true;
    }
}