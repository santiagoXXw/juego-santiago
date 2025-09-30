using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1; // Cu�nto vale la moneda

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Detecta al jugador
        {
            // Aqu� podemos sumar puntaje
            ScoreManager.instance.AddScore(value);

            // Destruir la moneda
            Destroy(gameObject);
        }
    }
}