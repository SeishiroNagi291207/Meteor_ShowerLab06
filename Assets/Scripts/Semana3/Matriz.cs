using UnityEngine;

public class Matriz
{
    public int m, n;
    public double[,] datos;
    public Matriz(int m, int n)
    {
        this.m = m;
        this.n = n;
        datos = new double[m, n];
    }
    // SUMA
    public static Matriz operator +(Matriz a, Matriz b)
    {
        if (a.m != b.m || a.n != b.n)
        {
            Debug.Log("No se pueden sumar matrices");
            return null;
        }

        Matriz r = new Matriz(a.m, a.n);

        for (int i = 0; i < a.m; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                r.datos[i, j] = a.datos[i, j] + b.datos[i, j];
            }
        }

        return r;
    }
    // RESTA
    public static Matriz operator -(Matriz a, Matriz b)
    {
        if (a.m != b.m || a.n != b.n)
        {
            Debug.Log("No se pueden restar matrices");
            return null;
        }

        Matriz r = new Matriz(a.m, a.n);

        for (int i = 0; i < a.m; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                r.datos[i, j] = a.datos[i, j] - b.datos[i, j];
            }
        }

        return r;
    }
    // MULTIPLICACIÓN POR ESCALAR
    public static Matriz operator *(Matriz a, double escalar)
    {
        Matriz r = new Matriz(a.m, a.n);

        for (int i = 0; i < a.m; i++)
        {
            for (int j = 0; j < a.n; j++)
            {
                r.datos[i, j] = a.datos[i, j] * escalar;
            }
        }

        return r;
    }
    // MULTIPLICACIÓN MATRIZ x MATRIZ
    public static Matriz operator *(Matriz a, Matriz b)
    {
        if (a.n != b.m)
        {
            Debug.Log("No se puede multiplicar matrices");
            return null;
        }

        Matriz r = new Matriz(a.m, b.n);

        for (int i = 0; i < a.m; i++)
        {
            for (int j = 0; j < b.n; j++)
            {
                for (int k = 0; k < a.n; k++)
                {
                    r.datos[i, j] += a.datos[i, k] * b.datos[k, j];
                }
            }
        }

        return r;
    }
    // MOSTRAR
    public void Mostrar()
    {
        string salida = "";

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                salida += datos[i, j] + "\t";
            }
            salida += "\n";
        }

        Debug.Log(salida);
    }
}