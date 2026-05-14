using UnityEngine;

public class SpinExample : MonoBehaviour
{
    public float spinSpeed = 90f;
    public float totalAngle = 0;
    public float quaternionSpeed = 100f;
    void Start()
    {
        
    }
    void Update()
    {
        //->1st manera Rotation(Unity Rotation)
        //transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);

        //2nd way Rotation (Manual Rotation)
        //totalAngle += 45 * Time.deltaTime; //-> Incrementamos el ángulo total
        //float rad = totalAngle * Mathf.Deg2Rad; //-> Convertimos a radianes
        //Matrix4x4 localMatrix = Matrix4x4.identity; //-> Matriz de identidad
        //localMatrix[0,0] = Mathf.Cos(rad); //-> Rotación en X
        //localMatrix[0,2] = Mathf.Sin(rad); //-> Rotación en Z
        //localMatrix[2,0] = -Mathf.Sin(rad); //-> Rotación en X
        //localMatrix[2,2] = Mathf.Cos(rad); //-> Rotación en Z
        //transform.rotation = localMatrix.rotation; //-> Aplicamos la rotación a la transformación


        //3rd way Rotation (Quaternion Rotation)
        Quaternion frameRotation = Quaternion.Euler(0, quaternionSpeed * Time.deltaTime, 0); //-> Rotación del frame actual
        transform.rotation = transform.rotation * frameRotation; //-> Aplicamos la rotación a la transformación
    }
}
