using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject environment;

    [SerializeField]
    private List<GameObject> obstacles;

    private float environment_length;

    void Start()
    {
        Vector3 objectSize = Vector3.Scale(transform.localScale, environment.GetComponent<MeshRenderer>().bounds.size);
        environment_length = objectSize.z;
        for(int i = 0; i < obstacles.Count; i++)
        {
            Instantiate(obstacles[i],new Vector3(0,0,i* environment_length/10 + 10),Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
