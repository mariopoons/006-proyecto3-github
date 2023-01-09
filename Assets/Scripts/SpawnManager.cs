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
        // spawnear� UN obstaculo
        //Instantiate(obstaclePrefab, transform.position, obstaclePrefab.transform.rotation);

        // crear� un obstaculo cada 2 segundos
        InvokeRepeating("SpawnObstacle", startDelay, respawnDelay);
    }

    // spawnear� el obstaculo
    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, transform.position, obstaclePrefab.transform.rotation);
    }
}
