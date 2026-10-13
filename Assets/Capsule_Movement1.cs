using UnityEngine;

public class Capsule_Movement : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Movement speed
    public float rotationSpeed = 100.0f; // Rotation speed
    public Transform cameraTransform; // Reference to the camera's transform

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Handle movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Get the direction the camera is facing
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        // Normalize the vectors to ignore the magnitude
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        // Calculate the movement direction based on camera direction
        Vector3 movement = (forward * moveVertical + right * moveHorizontal).normalized;
        rb.velocity = movement * moveSpeed;

        // Handle rotation with O and P keys
        if (Input.GetKey(KeyCode.O))
        {
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.P))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
    }
}