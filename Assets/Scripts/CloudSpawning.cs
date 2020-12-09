using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawning : MonoBehaviour
{
    public float spawnHeight = 100;
    public float heightVariation = 20;
    public float spawnArea = 200;
    public GameObject cloudObject;
    public int cloudAmount = 1000;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cloudAmount; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(transform.position.x - spawnArea, transform.position.x + spawnArea), Random.Range(spawnHeight - heightVariation, spawnHeight + heightVariation), Random.Range(transform.position.z - spawnArea, transform.position.z + spawnArea));
            Instantiate(cloudObject, spawnPos, Quaternion.identity, this.transform);
        }
    }
}
