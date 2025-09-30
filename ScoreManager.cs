using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Solo si vas a mostrar el puntaje en UI
using TMPro;   // Para usar TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public int score = 0;
    public TMP_Text scoreText; // Campo para el texto de la UI

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void AddScore(int amount)
    {
        score += amount;
        if (scoreText != null)
        {
            scoreText.text = "Monedas: " + score;
        }
    }
}