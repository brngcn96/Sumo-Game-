using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;

    [SerializeField] Vector3 offset;
    [SerializeField] float pitch = 1.5f;
    [SerializeField] float yawSpeed = 100f;
     [SerializeField] float currentYaw = 0f;

    float zoom = 10f;
    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.player.transform;
    }
    void Update()
    {
        //currentYaw -= Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime ;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position - offset * zoom;
        transform.LookAt(target.position + Vector3.up * pitch);
        //transform.RotateAround(target.position,Vector3.up,currentYaw);
    }
}
