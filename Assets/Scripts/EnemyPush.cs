using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPush : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float force = 10f;

    private void OnCollisionEnter(Collision collision)
    {

        //Enemies also can push my player 
        rb = collision.collider.gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 forceDirection = collision.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();
            rb.AddForceAtPosition(forceDirection * force, transform.position, ForceMode.Impulse);

        }

    }

}
