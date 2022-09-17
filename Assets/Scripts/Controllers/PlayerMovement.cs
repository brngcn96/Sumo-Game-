using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class PlayerMovement : MonoBehaviour
{

    NavMeshAgent agent;
    [SerializeField] float xValue;
    [SerializeField] float zValue;
    [SerializeField] float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void moveToDestination(Vector3 point){
        agent.SetDestination(point);
    }
    

    public void moveTouch(){
            xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            zValue = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            transform.Translate(xValue,0,zValue);
    }
}
