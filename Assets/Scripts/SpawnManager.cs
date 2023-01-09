using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;

    private float startDelay = 2f;
    private float respawnDelay = 2f;

    private void Start()
    {
        // spawneará UN obstaculo
        //Instantiate(obstaclePrefab, transform.position, obstaclePrefab.transform.rotation);

        // creará un obstaculo cada 2 segundos
        InvokeRepeating("SpawnObstacle", startDelay, respawnDelay);
    }

    // spawneará el obstaculo
    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, transform.position, obstaclePrefab.transform.rotation);
    }
}
