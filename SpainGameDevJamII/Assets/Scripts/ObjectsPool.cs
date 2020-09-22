using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsPool : MonoBehaviour
{
    [SerializeField] private GameObject objectToPool;
    [SerializeField] private int poolSize;
    private int currentSpawnedObject;
    private GameObject[] gameObjectsPool;

    private void Awake()
    {
        gameObjectsPool = new GameObject[poolSize];
        for(int i = 0; i < poolSize; i++)
        {
            gameObjectsPool[i] = Instantiate(objectToPool, transform.position, Quaternion.identity);
            gameObjectsPool[i].SetActive(false);
        }
    }
    public GameObject GetNextPoolObject()
    {
        currentSpawnedObject++;
        if (currentSpawnedObject >= poolSize)
            currentSpawnedObject = 0;
        gameObjectsPool[currentSpawnedObject].SetActive(true);
        return gameObjectsPool[currentSpawnedObject];
    }
}
