using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private HeroStatus heroStatus;
    private EnemyBehaviour enemyBehaviour;
    private void Awake()
    {
        heroStatus = FindObjectOfType<HeroStatus>();
        enemyBehaviour = GetComponentInParent<EnemyBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == CollisionLayers.hero)
            heroStatus.HeroGotHit(enemyBehaviour.enemyStats.RegularAttackDamage);
    }
}
