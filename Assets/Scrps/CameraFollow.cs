using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ObjectForCamera;
    public Vector3 offset;   // Offset from the target's position (e.g., to set the camera slightly above and behind the target)
    public float smoothSpeed = 0.125f;  // Smoothing factor for camera movement



    // Update is called once per frame
    void LateUpdate()
    {
        if (ObjectForCamera != null)
        {
            Vector3 desiredPosition = ObjectForCamera.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}

