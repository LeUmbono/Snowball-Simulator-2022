using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject gameManager;
    public float timeRemaining = 180;
    public bool timerOn = false;
    public Text timerText;


    private void Start()
    {
        timerOn = true;
    }

    void Update()
    {
        if(timerOn)
        {
            DisplayTime(timeRemaining);
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                timeRemaining = 0;
                timerOn = false;
                FindObjectOfType<EndLevel>().CompleteLevel();
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            timerOn = false;
            FindObjectOfType<EndLevel>().CompleteLevel();
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float mins = Mathf.FloorToInt(timeToDisplay / 60);
        float secs = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}:{1:00}", mins, secs);
    }
}
