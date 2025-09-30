using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para recargar la escena

public class Enemy : MonoBehaviour
{
    // Cuando el enemigo choque con el jugador
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Reiniciar la escena actual (el jugador muere)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
