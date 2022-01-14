using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMain : MonoBehaviour
{
    public Vector3 camerasetoff;
    public Transform target;
    public float damp;
    private Vector3 velocity = Vector3.zero;
    void FixedUpdate()
    {
        Vector3 moveposition = target.position + camerasetoff;
        Quaternion rotation = Quaternion.Euler(28,45,0);
        transform.position =Vector3.SmoothDamp(transform.position,moveposition,ref velocity,damp);
        transform.rotation = Quaternion.Slerp(transform.rotation,rotation,Time.deltaTime);
  
    }
}
