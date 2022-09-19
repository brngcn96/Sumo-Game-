using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerController : MonoBehaviour
{
    
    PlayerMovement movement;


    void Start()
    {
        
        movement = GetComponent<PlayerMovement>();
        
    }

    void Update()
    {
        movement.moveTouch();   
    }

}
