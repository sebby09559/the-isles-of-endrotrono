using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivityX = 2f;
    public float mouseSensitivityY = 2f;
    public Transform playerBody;

    private float xRotation = 0f;

    void Update()
    {
        // Get the mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivityX;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivityY;

        // Apply rotation on the X-axis (up and down)
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Prevent camera from flipping upside down
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Apply rotation on the Y-axis (left and right)
        playerBody.Rotate(Vector3.up * mouseX); // Rotate the player body to turn left/right
    }
}
