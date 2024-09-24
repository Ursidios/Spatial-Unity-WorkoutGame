using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RunningTrack : MonoBehaviour
{
    public float timer;
    public bool inRunning;

    public TMP_Text timerText;
    public void Update()
    {
        if(inRunning)
        {
            timer += Time.deltaTime;
        }

        timerText.text = timer.ToString("00:00");
    }
    public void StartTimer()
    {
        timer = 0;
        inRunning = true;
    }

    public void EndTimer()
    {
        inRunning = false;
    }
}
