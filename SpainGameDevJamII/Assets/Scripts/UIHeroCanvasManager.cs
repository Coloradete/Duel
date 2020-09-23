using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHeroCanvasManager : MonoBehaviour
{
    public static UIHeroCanvasManager instance;

    [SerializeField] private GameObject heroAliveUI, heroDeadUI;
    [SerializeField] private Slider heroHealth;
    [SerializeField] private HeroStatus heroStatus;
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
    }
    private void Start()
    {
        heroHealth.maxValue = heroStatus.currentHealth;
        heroHealth.value = heroHealth.maxValue;
    }

    public void UpdateHealth(int currentHealth)
    {
        heroHealth.value = currentHealth;
    }
}
