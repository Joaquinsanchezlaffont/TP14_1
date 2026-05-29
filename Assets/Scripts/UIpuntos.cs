using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIpuntos : MonoBehaviour
{
    public TMP_Text textoPuntos;

    void Start()
    {
        
    }

    void Update()
    {
        textoPuntos.text = "Puntos: " + Recolectable.puntos;
    }
}