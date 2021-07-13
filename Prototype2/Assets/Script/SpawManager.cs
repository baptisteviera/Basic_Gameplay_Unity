using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawManager : MonoBehaviour
{

    public GameObject[] animalsPrefabs;

    private float spawnRangeX = 20;

    private float spawnRangeZ = 20;

    private float startDelay = 2;

    private float spwanInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,spwanInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0,animalsPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Instantiate(animalsPrefabs[animalIndex],spawnPos,animalsPrefabs[animalIndex].transform.rotation);

    }
}
