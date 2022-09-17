using System.Security.Principal;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;



public class TimerScript : MonoBehaviour
{

    [SerializeField] float timeLeft = 60;
    [SerializeField] TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timeLeft>0){
            timeLeft -= Time.deltaTime;             
            timerText.text = Math.Ceiling(timeLeft).ToString();

        }
        else{
            
        }
    }
}
