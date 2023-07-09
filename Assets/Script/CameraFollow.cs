using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Objek yang akan diikuti kameranya
    public float smoothSpeed = 0.125f; // Kecepatan perpindahan kamera
    public Vector3 offset; // Jarak antara kamera dan pemain

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}
