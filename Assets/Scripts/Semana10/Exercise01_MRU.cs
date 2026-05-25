using UnityEngine;

public class Exercise01_MRU : MonoBehaviour
{
    public float velocidad = 8f;
    private float VectorX = 40f;
    void Update()
    {
        // Mientras no llegue a x = 40
        if (transform.position.x < VectorX)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        }
    }
}