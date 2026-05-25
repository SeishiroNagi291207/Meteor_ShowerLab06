using UnityEngine;

public class Exercise02_MRUV : MonoBehaviour
{
    public float velocidad = 30f;
    public float aceleracion = -6f;

    void Update()
    {
        // Mientras la velocidad sea mayor a 0
        if (velocidad > 0)
        {
            // Reducir velocidad
            velocidad += aceleracion * Time.deltaTime;

            // Evitar negativos
            if (velocidad < 0) velocidad = 0;

            // Movimiento hacia adelante (eje Z)
            transform.Translate(transform.forward * velocidad * Time.deltaTime);
        }
    }
}