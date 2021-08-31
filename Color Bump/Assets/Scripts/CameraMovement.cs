using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 6f;
    public Vector3 cameraVelocity;
    void Update()
    {
        if (FindObjectOfType<PlayerController>().canMove)
        {
            transform.position += Vector3.forward * cameraSpeed;
        }
        cameraVelocity = Vector3.forward * cameraSpeed;
    }
}
