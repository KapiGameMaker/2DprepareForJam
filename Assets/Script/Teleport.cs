using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;
    private CameraControl cameraControl;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.position = spawnPoint.position;
            cameraControl.SetCameraToRoom();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        cameraControl = GetComponent<CameraControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
