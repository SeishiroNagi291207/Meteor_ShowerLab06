using UnityEngine;

public class VectorM3
{
    public float x, y, z;

    public VectorM3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    // Suma de dos vectores
    public static VectorM3 operator +(VectorM3 a, VectorM3 b)
    {
        return new VectorM3(a.x + b.x, a.y + b.y, a.z + b.z);
    }

    //Resta de dos vectores
    public static VectorM3 operator -(VectorM3 a, VectorM3 b)
    {
        return new VectorM3(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    //Magnitud del vector
    public float Magnitude()
    {
        return Mathf.Sqrt(x * x + y * y + z * z);
    }

    //Normalización del vector
    public VectorM3 Normalize()
    {
        float mag = Magnitude();
        return mag > 0 ? new VectorM3(x / mag, y / mag, z / mag) : new VectorM3(0, 0, 0);
    }

    //Producto escalar
    public static float Dot(VectorM3 a, VectorM3 b)
    {
        return a.x * b.x + a.y * b.y + a.z * b.z;
    }

    //Multiplicación por un escalar
    public static VectorM3 operator *(VectorM3 v, float scalar)
    {
        return new VectorM3(v.x * scalar, v.y * scalar, v.z * scalar);
    }

    //Punto cruz
    public static VectorM3 Cross(VectorM3 a, VectorM3 b)
    {
        return new VectorM3(
          a.y * b.z - a.z * b.y,
          a.z * b.x - a.x * b.z,
          a.x * b.y - a.y * b.x
        );
    }

    //Operador ^
    public static VectorM3 operator ^(VectorM3 a, VectorM3 b)
    {
        return Cross(a, b);
    }

    //Ángulo entre dos vectores
    public static float Angle(VectorM3 a, VectorM3 b)
    {
        float dot = Dot(a.Normalize(), b.Normalize());
        return Mathf.Acos(Mathf.Clamp(dot, -1f, 1f)) * Mathf.Rad2Deg;
    }

    //Operador de igualdad
    public static bool operator ==(VectorM3 a, VectorM3 b) => a.x == b.x && a.y == b.y && a.z == b.z;

    public static bool operator !=(VectorM3 a, VectorM3 b) => !(a == b);

    public override string ToString()
    {
        return $"({x}, {y})";
    }
}