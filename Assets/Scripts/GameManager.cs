using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer = 60f;
    public UIManager uiManager;

    bool juegoTerminado = false;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (juegoTerminado)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            return;
        }

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 0;
            GameOver();
        }

        uiManager.UpdateTimer(timer);
    }

    public void Ganar()
    {
        juegoTerminado = true;
        uiManager.MostrarPantallaWin();
        Time.timeScale = 0;
    }

    public void GameOver()
    {
        juegoTerminado = true;
        uiManager.MostrarPantallaGameOver();
        Time.timeScale = 0;
    }
}