using UnityEngine;

public class TestMatriz : MonoBehaviour
{
    void Start()
    {
        // MATRICES BASE
        Matriz m1 = new Matriz(2, 2);
        Matriz m2 = new Matriz(2, 2);

        m1.datos = new double[,] { { 1, 2 }, { 3, 4 } };
        m2.datos = new double[,] { { 5, 6 }, { 7, 8 } };

        // SUMA
        Debug.Log("SUMA:");
        Matriz suma = m1 + m2;
        if (suma != null) suma.Mostrar();

        // RESTA
        Debug.Log("RESTA:");
        Matriz resta = m1 - m2;
        if (resta != null) resta.Mostrar();

        // ESCALAR
        Debug.Log("ESCALAR (m1 * 2):");
        Matriz escalar = m1 * 2;
        escalar.Mostrar();

        // MULTIPLICACIÓN MATRIZ x MATRIZ
        Debug.Log("MULTIPLICACIÓN MATRIZ:");

        Matriz a = new Matriz(2, 3);
        Matriz b = new Matriz(3, 2);

        a.datos = new double[,]
        {
            {1, 2, 3},
            {4, 5, 6}
        };

        b.datos = new double[,]
        {
            {7, 8},
            {9, 10},
            {11, 12}
        };

        Matriz mult = a * b;
        if (mult != null) mult.Mostrar();

        // ERROR SUMA
        Debug.Log("SUMA INVÁLIDA:");
        Matriz m3 = new Matriz(3, 2);
        m3.datos = new double[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        Matriz errorSuma = m1 + m3;

        // ERROR MULTIPLICACIÓN
        Debug.Log("MULTIPLICACIÓN INVÁLIDA:");
        Matriz c = new Matriz(2, 3);
        Matriz d = new Matriz(2, 2);

        Matriz errorMult = c * d;
    }
}