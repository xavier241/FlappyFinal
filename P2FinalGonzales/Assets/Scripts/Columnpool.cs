using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Columnpool : MonoBehaviour
{
    public float columnMax = 3.5f;
    public float columnMin = -1f;
    public float SpawnRate = 4f;
    public GameObject columnPrefab;
    public int coulmnPoolSize = 5;
    private GameObject[] columns;
    private Vector2 objectPoolposition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float SpawnXposition = 10f;
    private int currentColumn = 0;
    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[coulmnPoolSize];
        for (int i = 0; i < coulmnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolposition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= SpawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.RandomRange(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(SpawnXposition, spawnYPosition);
            currentColumn++;
            if (currentColumn >= coulmnPoolSize)
            {
                currentColumn = 0;
            }
        
        }
    }
}
