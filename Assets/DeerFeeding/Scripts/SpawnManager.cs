using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    float rangeX = 10;
    float rangeZ = 20;
    float startDelay = 2;
    float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 SpawnPos = new Vector3(Random.Range(-rangeX, rangeX), 0, rangeZ);

        Instantiate(AnimalPrefabs[animalIndex], SpawnPos, AnimalPrefabs[animalIndex].transform.rotation);
    }
}
