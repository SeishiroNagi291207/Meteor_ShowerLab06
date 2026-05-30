using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float explosionForce = 15f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();

            if (rb != null)
            {
                Vector3 direction = (other.transform.position - transform.position).normalized;

                rb.AddForce(direction * explosionForce, ForceMode.Impulse);
            }
        }
    }
}