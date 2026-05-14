using UnityEngine;

public class EarthRotation : MonoBehaviour
{
    public float rotationSpeed = 5f;

    void Update()
    {
        transform.Rotate(0,rotationSpeed * Time.deltaTime,0);
    }
}
