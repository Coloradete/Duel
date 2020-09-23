using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostsManager : MonoBehaviour
{
    public static GhostsManager instance;
    public Dictionary<EnemyName, int> ghostsListToSpawn { get; private set; }
    void Awake()
    {
        if (instance == null) //Singleton
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        ghostsListToSpawn = new Dictionary<EnemyName, int>();
    }

    private void Start()
    {
        foreach (EnemyName enemyName in Enum.GetValues(typeof(EnemyName)))
        {
            ghostsListToSpawn.Add(enemyName, 0);
        }
    }

    public void AddEnemyToGhostList(EnemyName name)
    {
        int currentCount;
        if (ghostsListToSpawn.TryGetValue(name, out currentCount))
            ghostsListToSpawn[name] = currentCount + 1;
        else
            Debug.LogWarning("Trying to add an enemy not registered in the enum EnemyName :" + name.ToString() );
    }

    public void ResetList()
    {
        foreach(EnemyName enemyName in Enum.GetValues(typeof(EnemyName)))
        {
            ghostsListToSpawn[enemyName] = 0;
        }
    }
}
