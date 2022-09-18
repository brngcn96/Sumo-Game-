using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    [SerializeField] float lookRadius = 1000f;
    Transform target;
    
    


    float f_RotSpeed = 5.0f;
    float f_MoveSpeed = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        
        target = PlayerManager.instance.player.transform;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float distance = Vector3.Distance(target.position,transform.position);


        
        if (distance <= lookRadius)
        {

                /* Look at Player*/
            transform.rotation = Quaternion.Slerp(transform.rotation
                                                      , Quaternion.LookRotation(target.position - transform.position)
                                                      , f_RotSpeed * Time.deltaTime);

                /* Move at Player*/
            transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;

        }
        




    }










}
