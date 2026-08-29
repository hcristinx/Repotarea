using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 6f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRb = collision.gameObject.GetComponent<Rigidbody>();

            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}


