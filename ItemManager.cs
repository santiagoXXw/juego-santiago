using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager instance;

    public int totalItems;      // Cuántos ítems hay en total para recoger
    private int collectedItems; // Cuántos se han recogido

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public void CollectItem()
    {
        collectedItems++;
    }

    public bool HasCollectedAll()
    {
        return collectedItems >= totalItems;
    }
}