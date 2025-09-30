using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Solo dejar tomarlo si ya se recogieron todos los ítems
            if (ItemManager.instance.HasCollectedAll())
            {
                Debug.Log("¡Has recogido el ítem final!");
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Todavía faltan ítems por recoger...");
            }
        }
    }
}