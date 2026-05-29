using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIpuntos : MonoBehaviour
{
    public Text textoPuntos;

    void Start()
    {
        
    }

    void Update()
    {
        textoPuntos.text = "Puntos: " + Recolectable.puntos;
    }
}