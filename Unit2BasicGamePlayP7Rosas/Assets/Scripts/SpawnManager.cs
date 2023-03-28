using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 9.0f;
    private float spawnRangeZUp = 13.0f;
    private float spawnRangeZDown = 3.0f;
    private float spawnPosZ = 29.0f;
    private float startDelay = 2.0f;
    private float spawnInterval = 1.5f;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //create 3 respawn points
        Vector3 spawnPosLeft = new Vector3(-29, 0, Random.Range(spawnRangeZDown, spawnRangeZUp));
        Vector3 spawnPosRight = new Vector3(29, 0, Random.Range(spawnRangeZDown, spawnRangeZUp));
        Vector3 spawnPosTop = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        //creating a random number generator
        int randomSpawnPos = Random.Range(1, 4);

        //using the random number generator and the if condition
        //I choose the position of the respawn and the rotation of the animals
        if (randomSpawnPos == 1)
            Instantiate(animalPrefabs[animalIndex], spawnPosLeft, Quaternion.Euler(0, 90, 0));

        else if (randomSpawnPos == 2)
            Instantiate(animalPrefabs[animalIndex], spawnPosRight, Quaternion.Euler(0, -90, 0));

        else if (randomSpawnPos == 3)
            Instantiate(animalPrefabs[animalIndex], spawnPosTop, animalPrefabs[animalIndex].transform.rotation);
    }
}