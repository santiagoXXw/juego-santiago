using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;   // El jugador

    void LateUpdate()
    {
        if (target != null)
        {
            // Seguir al jugador manteniendo la misma Z de la cámara
            transform.position = new Vector3(
                target.position.x,
                target.position.y,
                transform.position.z
            );
        }
    }
}