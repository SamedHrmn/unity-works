using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotateSpeed;
    private float horizontalInput;
    private float verticalInput;

    [SerializeField]
    private Camera mainCamera;
    [SerializeField]
    private Camera fronCamera;
    [SerializeField]
    private string inputID;
    public KeyCode switchKey;

    private void Start()
    {
        fronCamera.enabled = false;
    }


    void FixedUpdate()
    {

        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * horizontalInput);
        
    }

    void Update()
    {
        changeCamera();
    }

    void changeCamera()
    {

        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            fronCamera.enabled = !fronCamera.enabled;
        }
    }
}
