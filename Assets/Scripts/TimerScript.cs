using System.Security.Principal;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;



public class TimerScript : MonoBehaviour
{


    public float timeLeft;
    [SerializeField] TMP_Text timerText;


    // Singleton instance
    public static TimerScript instance;

    void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        timeLeft = 60;
    }


    
    void Update()
    {
        //Checking if time is over
        if(timeLeft>0){
            timeLeft -= Time.deltaTime;             
            timerText.text = Math.Ceiling(timeLeft).ToString();

        }

    }
}
