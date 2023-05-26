using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;     // Reference to the player's transform
    public float smoothSpeed = 0.125f;   // Smoothing factor for camera movement
    public Vector3 offset;      // Offset between the camera and the player

    private void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
