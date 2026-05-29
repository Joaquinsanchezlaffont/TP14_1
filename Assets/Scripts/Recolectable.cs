using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolectable : MonoBehaviour
{
    public static int puntos = 0;

    void OnTriggerEnter(Collider otro)
    {
        if (otro.gameObject.CompareTag("Player"))
        {
            puntos = puntos + 1;
Debug.Log("Recolectaste una botella. Total: " + puntos);

            Destroy(gameObject);
        }
    }
}