using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemies;
    public GameObject sugar;
    public GameObject fats;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    public float timeBetweenSpawnSugar;
    public float timeBetweenSpawnFats;
    private float spawnTime;
    private float spawnTimeSugar = 5;
    private float spawnTimeFats = 6;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
        if (Time.time > spawnTimeSugar)
        {
            SpawnSugar();
            spawnTimeSugar = Time.time + timeBetweenSpawnSugar;
        }
        if (Time.time > spawnTimeFats)
        {
            SpawnFats();
            spawnTimeFats = Time.time + timeBetweenSpawnFats;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(enemies, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    void SpawnSugar()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(sugar, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
    void SpawnFats()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(fats, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
