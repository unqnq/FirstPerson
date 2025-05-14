using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLookController : MonoBehaviour
{
    [SerializeField] private Transform playerBody;
    [SerializeField] private Transform cameraHolder;

    [SerializeField] private float sensitivity = 2f;
    [SerializeField] private float clampAngle = 80f;

    private Vector2 lookInput;
    private float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void OnLook(InputAction.CallbackContext context)
    {
        lookInput = context.ReadValue<Vector2>();
    }

    void Update()
    {
        Vector2 mouse = lookInput * sensitivity * Time.deltaTime;

        // Горизонталь: обертаємо персонажа
        playerBody.Rotate(Vector3.up * mouse.x);

        // Вертикаль: обертаємо камеру (з обмеженням)
        xRotation -= mouse.y;
        xRotation = Mathf.Clamp(xRotation, -clampAngle, clampAngle);
        cameraHolder.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
