using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    float rangeX = 20;
    float startDelay = 2;
    float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal2", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal2()
    {
        int animalIndex = Random.Range(0, AnimalPrefabs.Length);
        Vector3 SpawnPos = new Vector3(rangeX, 0, Random.Range(0,10));

        Instantiate(AnimalPrefabs[animalIndex], SpawnPos, AnimalPrefabs[animalIndex].transform.rotation);
    }
}
