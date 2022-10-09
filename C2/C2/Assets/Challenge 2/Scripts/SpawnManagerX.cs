using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -20;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    //private float startDelay = 1.0f;
    private float spawnInterval;

    private int rndmBall;

    // Start is called before the first frame update
    void Start()
    {
        spawnInterval = Random.Range(3, 6);
        Invoke("SpawnRandomBall", spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        rndmBall = Random.Range(0, 3);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[rndmBall], spawnPos, ballPrefabs[rndmBall].transform.rotation);

        spawnInterval = Random.Range(3, 6);

        Invoke("SpawnRandomBall", spawnInterval);
    }

}
