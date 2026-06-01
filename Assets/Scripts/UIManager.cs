using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text timerText;

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateTimer(float timer)
    {
        timerText.text = "00:" + timer.ToString("00");
    }
}