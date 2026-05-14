using UnityEngine;

public class PlaneCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            GameManagerL6.instance.LoseLife();

            Destroy(other.gameObject);
        }
    }
}