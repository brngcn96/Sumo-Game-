using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerController : MonoBehaviour
{
    Camera myCamera;
    PlayerMovement movement;

    
    // Start is called before the first frame update
    void Start()
    {
        myCamera = Camera.main;
        movement = GetComponent<PlayerMovement>();
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.moveTouch();   
    }



}
