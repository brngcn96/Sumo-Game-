using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;
    [SerializeField] float pitch = 1.5f;
    [SerializeField] float zoom = 10f;
    
    void Start()
    {
        target = PlayerManager.instance.player.transform;
    }

    
    void LateUpdate()
    {
        transform.position = target.position - offset * zoom;
        transform.LookAt(target.position + Vector3.up * pitch);
        
    }
}
