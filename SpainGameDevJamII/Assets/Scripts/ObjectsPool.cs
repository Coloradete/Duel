using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class ObjectsPool : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToPool;
    [SerializeField] private int[] objectPoolSize;
    private int[] currentSpawnedObject;
    private GameObject[][] gameObjectsPool;

    private void Awake()
    {
        for(int i = 0; i < objectsToPool.Length; i++)
        {
            gameObjectsPool = new GameObject[objectsToPool.Length][];
            for (int k = 0; k < objectPoolSize.Max(); k++)
            {
                gameObjectsPool[i][k] = Instantiate(objectsToPool[i], transform.position, Quaternion.identity);
                gameObjectsPool[i][k].SetActive(false);
            }
        }
    }
    private void Start()
    {
        currentSpawnedObject = new int[objectPoolSize.Length];
    }
    void OnValidate()
    {
        if (objectPoolSize.Length != objectsToPool.Length)
        {
            Debug.LogWarning("Don't change the 'objectsPoolSize' field's array size!");
            Array.Resize(ref objectPoolSize, objectsToPool.Length);
        }
    }
    public GameObject GetNextPoolObject(int index)
    {
        currentSpawnedObject[index]++;
        if (currentSpawnedObject[index] >= objectPoolSize[index])
            currentSpawnedObject[index] = 0;
        gameObjectsPool[index][currentSpawnedObject[index]].SetActive(true);
        return gameObjectsPool[index][currentSpawnedObject[index]];
    }
}
