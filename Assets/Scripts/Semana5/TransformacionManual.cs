using UnityEngine;

public class TransformacionManual : MonoBehaviour
{
    // Ejercicio 1
    public Vector3 direccion = new Vector3(0, 0, 1);
    public float velocidad = 5f;

    // Ejercicio 2
    public float velocidadRotacion = 30f;
    private float anguloActual = 0f;
    public Transform puntoCentro;
    private Vector3 posicionInicial;

    // Ejercicio 3
    public float amplitud = 0.2f;
    public float frecuencia = 1f;
    void Start()
    {
        if (puntoCentro != null)
        {
            posicionInicial = transform.position - puntoCentro.position;
        }
    }
    void Update()
    {
        //Trasladar();
        //Rotar2D();
        Escalar();
    }
    // Ejercicio 1
    void Trasladar()
    {
        Vector3 desplazamiento = direccion * velocidad * Time.deltaTime;
        transform.position = transform.position + desplazamiento;
    }
    // Ejercicio 2
    void Rotar2D()
    {
        if (puntoCentro == null) return;

        anguloActual += velocidadRotacion * Time.deltaTime;
        float rad = anguloActual * Mathf.Deg2Rad;

        float x = posicionInicial.x;
        float y = posicionInicial.y;

        float nuevoX = x * Mathf.Cos(rad) - y * Mathf.Sin(rad);
        float nuevoY = x * Mathf.Sin(rad) + y * Mathf.Cos(rad);

        Vector3 nuevaPos = new Vector3(nuevoX, nuevoY, posicionInicial.z);

        transform.position = puntoCentro.position + nuevaPos;
    }
    // Ejercicio 3
    void Escalar()
    {
        float escala = 1 + Mathf.Sin(Time.time * frecuencia) * amplitud;

        Matrix4x4 matriz = Matrix4x4.identity;

        matriz[0, 0] = escala;
        matriz[1, 1] = escala;
        matriz[2, 2] = escala;

        Vector3 escalaFinal = new Vector3(
            matriz[0, 0],
            matriz[1, 1],
            matriz[2, 2]
        );

        transform.localScale = escalaFinal;
    }
}