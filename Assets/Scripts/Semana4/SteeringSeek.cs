using UnityEngine;

public class SteeringSeek : MonoBehaviour
{
    public Transform target;
    public float maxSpeed = 5f;
    public float steeringForce = 0.1f;

    private Vector3 velocity;
    private float fixedY;

    private void Start()
    {
        fixedY = transform.position.y;
    }

    void Update()
    {
        Vector3 desiredVelocity =(new Vector3(target.position.x, fixedY, target.position.z) - transform.position).normalized * maxSpeed;
        Vector3 steering = desiredVelocity - velocity;

        //steering = Vector3.ClampMagnitude(steering, steeringForce);
        velocity += steering * steeringForce;
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        transform.position += velocity * Time.deltaTime;

        if (velocity != Vector3.zero)
        {
            transform.forward = velocity.normalized;
        }
    }
    private void OnDrawGizmos()
    {
        if (target != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, target.position);
        }
    }
}