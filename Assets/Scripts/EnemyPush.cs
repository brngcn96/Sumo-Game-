using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPush : MonoBehaviour
{

    Rigidbody rb;
    [SerializeField] float force = 10f;
    // Start is called before the first frame update
    void Start()
    {
        //rb = PlayerManager.instance.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        rb = collision.collider.gameObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 forceDirection = collision.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();
            rb.AddForceAtPosition(forceDirection * force, transform.position, ForceMode.Impulse);
            //rb.AddForce(transform.forward * 200, ForceMode.Impulse);

        }


    }

}
