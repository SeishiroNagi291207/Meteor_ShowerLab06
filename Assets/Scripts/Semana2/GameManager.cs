using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        // EJERCICIO 1: Suma y Resta (Calcula la suma y resta de los vectores A(3, 5) y B(-1, 2))
        VectorM2 A = new VectorM2(3, 5);
        VectorM2 B = new VectorM2(-1, 2);

        VectorM2 C = A + B;
        VectorM2 D = A - B;

        Debug.Log("Ej1 Suma: " + C.x + ", " + C.y);
        Debug.Log("Ej1 Resta: " + D.x + ", " + D.y);

        // EJERCICIO 2: Escalamiento (Calcula el vector resultante de multiplicar V(10, -5, 20) por 0.5))
        VectorM3 V = new VectorM3(10, -5, 20);
        VectorM3 mitad = V * 0.5f;

        Debug.Log("Ej2 Escalado: " + mitad.x + ", " + mitad.y + ", " + mitad.z);

        // EJERCICIO 3: Comparación (Compara los vectores V1(1, 1) y V2(1, 1) usando ==, Luego modifica uno de ellos y usa != para verificar la diferencia)
        VectorM2 V1 = new VectorM2(1, 1);
        VectorM2 V2 = new VectorM2(1, 1);

        Debug.Log("Ej3 ¿Iguales?: " + (V1 == V2));

        V2 = new VectorM2(1, 1.1f);

        Debug.Log("Ej3 ¿Diferentes?: " + (V1 != V2));

        // EJERCICIO 4: Normalización (Calcula la magnitud del vector M(4, 3) y luego normalízalo)
        VectorM2 M = new VectorM2(4, 3);

        Debug.Log("Ej4 Magnitud: " + M.Magnitude());

        VectorM2 normalizado = M.Normalize();

        Debug.Log("Ej4 Normalizado: " + normalizado.x + ", " + normalizado.y);
        Debug.Log("Ej4 Magnitud normalizada: " + normalizado.Magnitude());

        // EJERCICIO 5: Distancia entre puntos (Calcula la distancia entre los puntos P1(1, 2, 3) y P2(4, 6, 8))
        VectorM3 P1 = new VectorM3(1, 2, 3);
        VectorM3 P2 = new VectorM3(4, 6, 8);

        float distancia = (P1 - P2).Magnitude();

        Debug.Log("Ej5 Distancia: " + distancia);

        // EJERCICIO 6: Producto Punto (Calcula el producto punto entre A1(1, 0) y B1(0, 1))
        VectorM2 A2 = new VectorM2(1, 0);
        VectorM2 B2 = new VectorM2(0, 1);

        float dot = VectorM2.Dot(A2, B2);

        Debug.Log("Ej6 Dot: " + dot);

        // EJERCICIO 7: Ángulo (Calcula el ángulo entre V1(1, 0, 0) y V2(0, 1, 0))
        VectorM3 V1_3 = new VectorM3(1, 0, 0);
        VectorM3 V2_3 = new VectorM3(0, 1, 0);

        float angulo = VectorM3.Angle(V1_3, V2_3);

        Debug.Log("Ej7 Ángulo: " + angulo);

        // EJERCICIO 8: Producto Cruz (Calcula el producto cruz entre A(1, 0, 0) y B(0, 1, 0))
        VectorM3 cross = V1_3 ^ V2_3;

        Debug.Log("Ej8 Cross: " + cross.x + ", " + cross.y + ", " + cross.z);

        // EJERCICIO 9: Validación (Intenta normalizar el vector (0, 0, 0))
        VectorM3 cero = new VectorM3(0, 0, 0);

        VectorM3 resultado = cero.Normalize();

        Debug.Log("Ej9 Normalizar cero: " + resultado.x + ", " + resultado.y + ", " + resultado.z);
    }
}