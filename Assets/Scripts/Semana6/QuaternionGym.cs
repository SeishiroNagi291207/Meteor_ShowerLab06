using UnityEngine;
using UnityEngine.InputSystem;
public class QuaternionGym : MonoBehaviour
{
    [Header("Rotation Config")]

    public Vector3 rotationAxis = Vector3.up;
    public float angle = 90f;

    [Header("Interpolation")]

    public Transform target;
    [Range(0, 1)]
    public float slerpAmount = 0.05f;

    void Update()
    {
        //Exercise 1: Rotate the object around the specified axis by the given angle
        //Matematicamente: q = [cos(angle/2), axis * sin(angle/2)]
        /*
        Quaternion rotation = Quaternion.AngleAxis(angle * Time.deltaTime, rotationAxis);

        if (Keyboard.current.spaceKey.isPressed)
        {
            transform.rotation = rotation;
        }
        */
        //Exercise 2: Interpolate the rotation of the object towards the target's rotation using Slerp
        /*
        if (target != null)
        {
            Vector3 dir = target.position - transform.position;

            if (dir != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(dir);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, slerpAmount);
            }
        }
        */
  
        //Exercise 3: Combine rotations

        if (Keyboard.current.rKey.isPressed)
        {
            Quaternion extraRotation = Quaternion.Euler(0, 45, 0);
            transform.rotation = extraRotation;
        }
    }

    private void OnDrawGizmos()
    {
        // Dibujamos el eje de rotación para que los alumnos lo vean en la Scene
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, rotationAxis * 2);
    }
}