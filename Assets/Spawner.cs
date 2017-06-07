using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnInterval = 2;
    public float SpawnTimer = 0;
    public GameObject Spawnable;

    void Update ()
    {
        SpawnTimer += Time.deltaTime;
        if(SpawnTimer >= SpawnInterval)
        {
            SpawnTimer = 0;
            Instantiate(Spawnable, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 360)));
        }
    }
}
