using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 10f;

    [Header("Rotation")]
    public Vector3 rotationSpeed;

    [Header("Destroy")]
    public float destroyZ = -50f;

    void Update()
    {
        // Movimiento hacia el jugador
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime,Space.World);

        // Rotación del obstáculo
        transform.Rotate(rotationSpeed * Time.deltaTime);

        // Destruir cuando pase la cámara
        if (transform.position.z < destroyZ)
        {
            Destroy(gameObject);
        }
    }
}