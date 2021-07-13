using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    //private float spawnInterval = Random.Range(0.0f,1.0f);
    //private float spawnInterval = 0.5f;
    //private float spawnInterval = Random.Range(2, 4);

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval); // ne fonctionne pas car besoin d'un interval constant
        Invoke("SpawnRandomBall",startDelay);

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        
        int randIndice = Random.Range(0, ballPrefabs.Length); // mieux que de mettre 3
        float spawnInterval = Random.Range(0.5f, 2);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randIndice], spawnPos, ballPrefabs[randIndice].transform.rotation);
        Invoke("SpawnRandomBall",spawnInterval);

    }

}
