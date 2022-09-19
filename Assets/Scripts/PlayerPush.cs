using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour
{

    [SerializeField] float force = 5f;
    [SerializeField] GameObject hitPrefab;
    [SerializeField] AudioSource hitSound;



    public void OnCollisionEnter(Collision collision)
    {


        //Push the enemy when hit
        Rigidbody rb = collision.collider.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            Vector3 forceDirection = collision.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();
            rb.AddForceAtPosition(forceDirection * force, transform.position, ForceMode.Impulse);
            print("PLAYER PUSHED 2");


            Instantiate(hitPrefab, collision.gameObject.transform.position, Quaternion.identity);
            ParticleSystem ps = hitPrefab.GetComponent<ParticleSystem>();
            ps.Play();
            hitSound.Play();

        }


    }

}
