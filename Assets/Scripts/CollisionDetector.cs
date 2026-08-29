using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);

        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
        }
    }*/
    private void OnTriggerEnter(Collider other) { 
        if (other.gameObject.CompareTag("Player")){ 
            Debug.Log("¡Meta alcanzada!"); 
        } 
    }
}