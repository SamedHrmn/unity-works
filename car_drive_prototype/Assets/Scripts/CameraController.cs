using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerGameObject;
    public Vector3 offset;
 

    
    void LateUpdate()
    {
        transform.position = playerGameObject.transform.position + offset;
    }
}
