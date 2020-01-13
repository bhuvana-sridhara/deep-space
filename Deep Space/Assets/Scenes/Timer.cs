﻿using System;
using UnityEngine;
using UnityEngine.UI;


public static class Timer
{
    static Image timerBar;
    static DateTime TimeStarted;
    static TimeSpan TotalTime;
    public static GameObject timesUpText;

    public static void Start()
    {
        timesUpText.SetActive(false);
        timerBar = GetComponent<Image>();

    }

    private static T GetComponent<T>()
    {
        throw new NotImplementedException();
    }

    public static void StartCountDown(TimeSpan totalTime)
    {
        TimeStarted = DateTime.UtcNow;
        TotalTime = totalTime;
    }

    public static TimeSpan TimeLeft
    {
        get
        {
            var result = TotalTime - (DateTime.UtcNow - TimeStarted);
            if (result.TotalSeconds <= 0)
                return TimeSpan.Zero;
            return result;
        }
    }
}