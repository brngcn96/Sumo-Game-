using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour
{

    [SerializeField] float lookRadius = 9f;
    Transform target;
    [SerializeField] float rotationSpeed = 3f;
    [SerializeField] float moveSpeed = 3f;
    
    
    void Start()
    {
        
        target = PlayerManager.instance.player.transform;
        
    }

    
    void Update()
    {
        float distance = Vector3.Distance(target.position,transform.position);
        
        if (distance <= lookRadius)
        {

            // Look at Player
            transform.rotation = Quaternion.Slerp(transform.rotation
                                                      , Quaternion.LookRotation(target.position - transform.position)
                                                      , rotationSpeed * Time.deltaTime);

            //Move at Player
            transform.position += transform.forward * moveSpeed * Time.deltaTime;

        }


    }




}
