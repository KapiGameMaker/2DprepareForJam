using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float Room;
    [SerializeField] private Transform mainCamera;

    public void SetCameraToRoom()
    {
        mainCamera.position = new Vector3(Room * 17 - 16, 0, -10);
    }
}
