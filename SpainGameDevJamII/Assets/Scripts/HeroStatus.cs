using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HeroStatus : MonoBehaviour
{
    public CharacterStats heroStats;
    private int currentHealth;
    private float gotHitCooldown;

    private void Awake()
    {
        currentHealth = heroStats.Health;
    }

    private void Update()
    {
        gotHitCooldown -= Time.deltaTime;
    }
    public void HeroGotHit(int damage)
    {
        if(gotHitCooldown <= 0f)
        {
            currentHealth -= damage;
            AudioManager.instance.HeroGotHit();
            if (currentHealth <= 0)
            {
                HeroDeath();
            }
            gotHitCooldown = 0.25f;
        }
    }

    private void HeroDeath()
    {
        gameObject.SetActive(false);
    }
}
