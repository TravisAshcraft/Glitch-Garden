﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip ("our level timer in seconds")]
    [SerializeField] float levelTime = 10f;
    bool triggeredLeveFinished = false;
    public void Update()
    {
        if (triggeredLeveFinished) { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LeveTimerFinished();
            triggeredLeveFinished = true;
        }
    }
}
