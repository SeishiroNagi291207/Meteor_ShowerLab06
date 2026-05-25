using UnityEngine;

public class CalculadorRebote : MonoBehaviour
{
    [Header("Configuración del Rayo")]

    [Tooltip("Distancia máxima del rayo")]
    public float distanciaMaxima = 10f;

    [Tooltip("Capas con las que puede chocar")]
    public LayerMask capaColision;

    private void OnDrawGizmos()
    {
        // PASO 1: DATOS INICIALES

        // Punto desde donde sale el láser
        Vector3 origen = transform.position;

        // Dirección hacia adelante del objeto
        Vector3 direccionIncidencia = transform.forward;

        // Dibujar el rayo inicial en amarillo
        Gizmos.color = Color.yellow;

        RaycastHit hit;

        // PASO 2: RAYCAST

        if (Physics.Raycast(origen, direccionIncidencia, out hit, distanciaMaxima, capaColision))
        {
            // PASO 3: DATOS DEL IMPACTO

            Vector3 puntoImpacto = hit.point;

            // Vector normal de la pared
            Vector3 vectorNormal = hit.normal;
            
            // PASO 4: FÓRMULA DE REFLEXIÓN

            float productoEscalar = Vector3.Dot(direccionIncidencia, vectorNormal);

            Vector3 direccionRebote = direccionIncidencia -2 * productoEscalar * vectorNormal;

            // PASO 5: DIBUJAR INCIDENCIA

            Gizmos.color = Color.red;

            // Línea desde el origen al impacto
            Gizmos.DrawLine(origen, puntoImpacto);

            // Punto de impacto
            Gizmos.DrawSphere(puntoImpacto, 0.1f);

            // PASO 6: DIBUJAR NORMAL

            Gizmos.color = Color.blue;

            Gizmos.DrawLine(puntoImpacto,puntoImpacto + vectorNormal * 1.5f);

            // PASO 7: DIBUJAR REBOTE

            Gizmos.color = Color.green;

            Gizmos.DrawLine(puntoImpacto,puntoImpacto + direccionRebote * 3f);
        }
        else
        {
            // Si no golpea nada, dibuja el rayo completo
            Gizmos.DrawLine(origen,origen + direccionIncidencia * distanciaMaxima);
        }
    }
}