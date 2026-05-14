using UnityEngine;

public class VectorM2
{
    public float x, y;

    public VectorM2(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    //Suma de dos vectores
    public static VectorM2 operator +(VectorM2 a, VectorM2 b)
    {
        return new VectorM2(a.x + b.x, a.y + b.y);
    }

    //Resta de dos vectores
    public static VectorM2 operator -(VectorM2 a, VectorM2 b)
    {
        return new VectorM2(a.x - b.x, a.y - b.y);
    }

    //Magnitud de un vector
    public float Magnitude()
    {
        return Mathf.Sqrt(x * x + y * y);
    }

    //Normalización de un vector
    public VectorM2 Normalize()
    {
        float magnitude = Magnitude();
        return magnitude > 0 ? new VectorM2(x / magnitude, y / magnitude) : new VectorM2(0, 0);
    }

    //Multiplicación por un escalar
    public static VectorM2 operator *(VectorM2 v, float scalar)
    {
        return new VectorM2(v.x * scalar, v.y * scalar);
    }

    //Producto escalar de dos vectores
    public static float Dot(VectorM2 a, VectorM2 b)
    {
        return a.x * b.x + a.y * b.y;
    }

    //Ángulo entre dos vectores (en radianes)
    public static float Angle(VectorM2 a, VectorM2 b)
    {
        float dot = Dot(a.Normalize(), b.Normalize());
        return Mathf.Acos(Mathf.Clamp(dot, -1f, 1f)); // Clamp para evitar errores de precisión
    }

    // Igualdad entre vectores
    public static bool operator ==(VectorM2 a, VectorM2 b) =>
      a.x == b.x && a.y == b.y;

    // Diferencia entre vectores
    public static bool operator !=(VectorM2 a, VectorM2 b) => !(a == b);

    public override string ToString()
    {
        return $"({x}, {y})";
    }
}