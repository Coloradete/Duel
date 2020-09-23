using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HeroStatus : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    [HideInInspector] public int currentHealth { get; private set; }
    private float gotHitCooldown;

    private void Awake()
    {
        currentHealth = maxHealth;
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
            UIHeroCanvasManager.instance.UpdateHealth(currentHealth);
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
