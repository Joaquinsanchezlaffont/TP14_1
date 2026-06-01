using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    int score = 0;
    UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collecionable"))
        {
            score++;

            uiManager.UpdateScore(score);

            Debug.Log("Objeto recolectado exitosamente. Puntos: " + score);

            Destroy(other.gameObject);
        }
    }
}