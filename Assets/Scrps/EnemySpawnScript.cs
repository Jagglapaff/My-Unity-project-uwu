using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject[] enemyPrefabs;  /// Array of enemy prefabs to spawn
    public Transform spawnPoint;      // The spawn point for enemies
    public float timeSpawn = 2.0f;  //  Time between when enemies spawn

    private float timeSinceLastSpawn = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Updating the timer
        timeSinceLastSpawn += Time.deltaTime;

        /// To check if it's time to spawn more 
        if (timeSinceLastSpawn >= timeSpawn)
        {
            //Reset
            timeSinceLastSpawn = 0.0f;

            // Select random enemy prefab. Array slay
            int randomIndex = Random.Range(0, enemyPrefabs.Length);

            //Finissihg magic
            Instantiate(enemyPrefabs[randomIndex], spawnPoint.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
