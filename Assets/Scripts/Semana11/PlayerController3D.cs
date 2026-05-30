using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController3D : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody rb;
    private Vector2 inputVector = Vector2.zero;
    private Vector3 moveDirection = Vector3.zero;

    private void Awake()
    {
        // Obtenemos la referencia al Rigidbody al iniciar
        rb = GetComponent<Rigidbody>();

        // Es buena práctica congelar la rotación en X y Z para que el personaje no se caiga
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    /// <dt>Método de suscripción para el New Input System (Player Input Component)</dt>
    public void OnMove(InputValue value)
    {
        inputVector = value.Get<Vector2>();
    }

    public void InputVectorMagnitude()
    {
        print(inputVector.magnitude);
    }

    private void Update()
    {
        // Convertimos el input de 2D (pantalla/stick) a direcciones en 3D (Mundo)
        moveDirection = new Vector3(inputVector.x, 0f, inputVector.y);
    }

    private void FixedUpdate()
    {
        // Aplicamos el movimiento en FixedUpdate por tratarse de física (Rigidbody)
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 targetVelocity = new Vector3(moveDirection.x * moveSpeed, rb.linearVelocity.y, moveDirection.z * moveSpeed);

        rb.linearVelocity = Vector3.Lerp(rb.linearVelocity, targetVelocity, 0.15f);

        if (moveDirection != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.fixedDeltaTime * 10f);
        }
    }
}
