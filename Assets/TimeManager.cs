using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class TimeManager : MonoBehaviour
{
    //timer component
    public TMP_Text timerText;
    
    //timer settings
    bool TimerActive = false;
    float currentTime;

    //score component
    int score;
    public TMP_Text scoreText;
    public float multiplier = 5;

    private TimeSpan initialTime;
    public TimeSpan timePassed;
   
    void Start()
    {
        initialTime = new TimeSpan(System.DateTime.Now.Ticks);
    }

    void Update()
    {
        // if(TimerActive == true){
        //     currentTime = currentTime + Time.deltaTime;
        // }

        //timer display
        TimeSpan currTime = new TimeSpan(System.DateTime.Now.Ticks);
        timePassed = currTime - initialTime;

        // score display
        // score = Mathf.RoundToInt((float)timePassed.TotalSeconds * multiplier);

        // print(timePassed);
        timerText.text = timePassed.ToString(@"mm\:ss");
    }

    public void StartTimer() {
        TimerActive = true;
    }
    
    public void StopTimer() {
        TimerActive = false;
    }

    public TimeSpan getTime() {
        return timePassed;
    }

    public int getScore() {
        return score;
    }
}
