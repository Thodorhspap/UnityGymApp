using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;
    public float rotationSpeed = 100f;

    private void LateUpdate()
    {
        // Rotate around the player when pressing P or O
        if (Input.GetKey(KeyCode.P))
        {
            transform.RotateAround(playerTransform.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.O))
        {
            transform.RotateAround(playerTransform.position, Vector3.up, -rotationSpeed * Time.deltaTime);
        }

        // Calculate the desired position
        Vector3 desiredPosition = playerTransform.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        // Always look at the player
        transform.LookAt(playerTransform);
    }
}
