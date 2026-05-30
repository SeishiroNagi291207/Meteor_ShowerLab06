using UnityEngine;

public class CameraFollowS_11 : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0f, 8f, -8f);
    public float smoothSpeed = 5f;

    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + target.TransformDirection(offset);

        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        transform.LookAt(target);
    }
}