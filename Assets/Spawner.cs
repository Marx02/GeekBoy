using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spikes;

    private float timeBtwnSpawn;
    public float startTimeBtwnSpawn;

    private void Update()
    {
        if (timeBtwnSpawn <= 0)
        {
            Instantiate(spikes, transform.position, Quaternion.identity);
            timeBtwnSpawn = startTimeBtwnSpawn;
        }
        else{
            timeBtwnSpawn -= Time.deltaTime;
        }
    }

}
