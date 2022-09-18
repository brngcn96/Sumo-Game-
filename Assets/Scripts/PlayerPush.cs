using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerPush : MonoBehaviour
{

    [SerializeField] float force = 3f;




    void Start()
    {
        
    }

    
    void Update()
    {
 
        
    }



    

    private void OnCollisionEnter(Collision collision)
    {
        //Rigidbody rb = collision.collider.gameObject.GetComponent<Rigidbody>();
        Rigidbody rb = collision.collider.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            Vector3 forceDirection = collision.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();
            rb.AddForceAtPosition(forceDirection * force, transform.position, ForceMode.Impulse);
            print("PLAYER PUSHED 2");


        }


    }

    




}
