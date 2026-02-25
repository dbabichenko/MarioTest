using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject coin;
    public GameObject hazzard;

    private List<GameObject> spawnedObjects = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < Random.Range(3, 10); i++)
        {
            SpawnObjects();
        }
        
    }

    void SpawnObjects()
    {
        GameObject coinPrefab = Instantiate(coin, GetRandomPosition(), Quaternion.identity);
        spawnedObjects.Add(coinPrefab);
        GameObject hazzardPrefab = Instantiate(hazzard, GetRandomPosition(), Quaternion.identity);
        spawnedObjects.Add(hazzardPrefab);
    }

    Vector2 GetRandomPosition()
    {
        float x = Random.Range(-8f, 8f);
        float y = Random.Range(-4f, 4f);
        return new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject obj in spawnedObjects)
        {
            if (obj != null)
            {
                obj.transform.Translate(Vector2.left * Time.deltaTime * Random.Range(0.1f, 3.0f));
            }
        }
    }
}
