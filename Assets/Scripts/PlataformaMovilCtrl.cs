using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float distance = 2f;
    public float speed = 2f;

    private Rigidbody rb;
    private Vector3 startPosition;
    private int direction = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }

    void FixedUpdate()
    {
        Vector3 targetPosition = startPosition + Vector3.right * distance * direction;

        rb.MovePosition(
            Vector3.MoveTowards(
                rb.position,
                targetPosition,
                speed * Time.fixedDeltaTime
            )
        );

        if (Vector3.Distance(rb.position, targetPosition) < 0.01f)
        {
            direction *= -1;
        }
    }
}

