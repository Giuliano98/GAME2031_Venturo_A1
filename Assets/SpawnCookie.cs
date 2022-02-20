using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCookie : MonoBehaviour
{
    public GameObject objToSpawn;

    public Vector3 spawnerPos;

    private float timeToSpawn = 2.0f;
    private float currentTimeToSpawn;

    private float randXAxis;
    private float randYAxis;

    private Vector3 tempPos;

    private void Start()
    {
        spawnerPos = transform.position;
        currentTimeToSpawn = timeToSpawn;
    }

    private void Update()
    {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnTargets();
            currentTimeToSpawn = Random.Range(0.5f, 3.5f);
        }
    }

    public void SpawnTargets()
    {
        randXAxis = Random.Range(-6, 6);
        randYAxis = Random.Range(0, 3);
        tempPos = new Vector3(spawnerPos.x + randXAxis, spawnerPos.y + randYAxis, spawnerPos.z);
        Instantiate(objToSpawn, tempPos, Quaternion.identity);
    }
}
