using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flood : MonoBehaviour
{
    [SerializeField] private Transform Floodtransfrom;
    [SerializeField] private float speed;
    private bool FloodInThisRoom;

    private void FixedUpdate()
    {
        if (FloodInThisRoom)
        {
            Vector2 floodPoint = Floodtransfrom.position;
            Vector2 maxPoint = transform.position;
            Floodtransfrom.position = Vector2.MoveTowards(floodPoint, maxPoint, speed / 10);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FloodInThisRoom = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FloodInThisRoom = false;
        }
    }

}    
