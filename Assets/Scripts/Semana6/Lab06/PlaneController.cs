using UnityEngine;
using UnityEngine.InputSystem;

public class PlaneController : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 8f;

    [Header("Limits")]
    public float limitX = 10f;
    public float limitY = 5f;

    [Header("Rotation")]
    public float rotationAngle = 35f;
    public float rotationSmooth = 5f;

    private Quaternion originalRotation;

    // Input System
    private InputSystem_Actions inputActions;

    private Vector2 moveInput;

    void Awake()
    {
        inputActions = new InputSystem_Actions();
    }

    void OnEnable()
    {
        inputActions.Enable();
    }

    void OnDisable()
    {
        inputActions.Disable();
    }

    void Start()
    {
        originalRotation = transform.rotation;
    }

    void Update()
    {
        moveInput = inputActions.Player.Move.ReadValue<Vector2>();

        MovePlane();
        RotatePlane();
    }

    void MovePlane()
    {
        Vector3 movement = new Vector3(moveInput.x,moveInput.y,0);

        transform.Translate(movement * moveSpeed * Time.deltaTime,Space.World);

        // Limitar posición
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -limitX, limitX);

        pos.y = Mathf.Clamp(pos.y, -limitY, limitY);

        transform.position = pos;
    }

    void RotatePlane()
    {
        float rotZ = -moveInput.x * rotationAngle;

        float rotX = -moveInput.y * rotationAngle;

        Quaternion targetRotation = originalRotation * Quaternion.Euler(rotX, 0, rotZ);

        transform.rotation = Quaternion.Slerp(transform.rotation,targetRotation,rotationSmooth * Time.deltaTime);
    }
}