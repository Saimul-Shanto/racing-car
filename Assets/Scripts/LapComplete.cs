﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    void OnTriggerEnter()
    {
        if (LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<TextMeshProUGUI>().text ="0"+LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<TextMeshProUGUI>().text =""+LapTimeManager.SecondCount + ".";
        }
        
        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<TextMeshProUGUI>().text ="0"+LapTimeManager.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<TextMeshProUGUI>().text =LapTimeManager.MinuteCount + ".";
        }
        
        
        MilliDisplay.GetComponent<TextMeshProUGUI>().text =""+LapTimeManager.MilliDisplay ;
        //SecondDisplay.GetComponent<TextMeshProUGUI>().text =LapTimeManager.SecondCount.ToString() ;
        //MinuteDisplay.GetComponent<TextMeshProUGUI>().text =LapTimeManager.MinuteCount.ToString() ;

        LapTimeManager.MilliCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MinuteCount = 0;
        
        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
    }

}
