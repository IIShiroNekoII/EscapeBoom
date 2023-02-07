using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    public float timeRemaining;
    public TMP_Text timerText;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        else
        {
            timeRemaining = 0;
            SceneManager.LoadScene(2);
        }
        DisplayTime(timeRemaining);
    }


    void DisplayTime (float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        if (timeToDisplay < 60)
        {
            timerText.color = Color.red;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}