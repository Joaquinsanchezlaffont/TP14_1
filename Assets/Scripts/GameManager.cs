using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    public UIManager uiManager;

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            timer = 0;
        }

        uiManager.UpdateTimer(timer);
    }
}