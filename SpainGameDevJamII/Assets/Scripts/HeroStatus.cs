using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HeroStatus : MonoBehaviour
{
    public CharacterStats heroStats;
    private int currentHealth;

    private void Awake()
    {
        currentHealth = heroStats.Health;
    }

    public void HeroGotHit(int damage)
    {
        currentHealth -= damage;
        AudioManager.instance.HeroGotHit();
        if(currentHealth <= 0)
        {
            HeroDeath();
        }
    }

    private void HeroDeath()
    {
        gameObject.SetActive(false);
    }
}
