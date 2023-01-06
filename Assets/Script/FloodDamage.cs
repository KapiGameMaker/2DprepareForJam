using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloodDamage : MonoBehaviour
{
    [SerializeField] private Transform PlayerHeadTransform;
    [SerializeField] private GameManager gameManager;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player" + (PlayerHeadTransform.position.y - transform.position.y));
            if(PlayerHeadTransform.position.y - transform.position.y <= 4.5f)
            {
                Debug.Log("drown");
                gameManager.drowning = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("PlayerExit");
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.drowning = false;
            Debug.Log("drown");
        }
    }
}
