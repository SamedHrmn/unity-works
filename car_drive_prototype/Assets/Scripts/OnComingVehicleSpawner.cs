using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnComingVehicleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject environment;

    [SerializeField]
    private GameObject vehicle;

    [SerializeField]
    private float vehicleSpeed;

    private float environment_length;

    private List<GameObject> gameObject = new List<GameObject>();
    void Start()
    {
        Vector3 objectSize = Vector3.Scale(transform.localScale, environment.GetComponent<MeshRenderer>().bounds.size);
        environment_length = objectSize.z;
        for (int i = 0; i < 4; i++)
        {
            if(i%2 == 0)
            {
                gameObject.Add(Instantiate(vehicle, new Vector3(-5, 0, (environment_length - environment_length / 10 * i) - 20), Quaternion.Euler(0, 180, 0))); 
            }
            else
            {
                gameObject.Add(Instantiate(vehicle, new Vector3(5, 0, (environment_length - environment_length / 10 * i) - 20), Quaternion.Euler(0, 180, 0)));
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach(GameObject i in gameObject)
        {
            i.GetComponent<Rigidbody>().AddForce(Vector3.back * vehicleSpeed * Time.fixedDeltaTime, ForceMode.Acceleration);
        }
    }
}
