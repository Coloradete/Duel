using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public EnemyStats enemyStats;
    private HeroStatus hero;

    private Rigidbody rBody;
    private Vector3 movementDirection;

    [SerializeField] private GameObject enemyAttack;
    [SerializeField] private GameObject gotHitEffect;
    [SerializeField] private float attackDistance;
    private float currentAttackCooldown, gotHitCooldown;
    private int currentHealth;

    private bool isMoving = true, isAttacking;
    private void Awake()
    {
        hero = FindObjectOfType<HeroStatus>();
        rBody = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        currentAttackCooldown = enemyStats.RegularAttackCooldown;
        currentHealth = enemyStats.Health;
    }
    private void Update()
    {
        if(isMoving && !isAttacking)
            rBody.velocity = movementDirection * enemyStats.RunSpeed * Time.deltaTime;
        currentAttackCooldown -= Time.deltaTime;
        gotHitCooldown -= Time.deltaTime;
        if(gotHitCooldown <= 0f)
            gotHitEffect.SetActive(false);
    }

    private void FixedUpdate()
    {
        movementDirection = hero.transform.position - transform.position;
        movementDirection.Normalize();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == CollisionLayers.hero)
        {
            isMoving = false;
            rBody.velocity = Vector3.zero;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == CollisionLayers.hero)
        {
            isMoving = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (currentAttackCooldown <= 0f && other.gameObject.layer == CollisionLayers.hero)
        {
            StartCoroutine(RegularAttack());
        }
    }

    private IEnumerator RegularAttack()
    {
        if (!isAttacking)
        {
            isAttacking = true;
            yield return new WaitForSeconds(enemyStats.Buildup);
            enemyAttack.transform.position = transform.position + movementDirection * attackDistance;
            enemyAttack.SetActive(true);
            AudioManager.instance.EnemyAttack(enemyStats.RawName);
            yield return new WaitForSeconds(enemyStats.Recoil);
            enemyAttack.SetActive(false);
            isAttacking = false;
            currentAttackCooldown = enemyStats.RegularAttackCooldown;
        }
    }
    public void EnemyGotHit(int damage)
    {
        if (gotHitCooldown <= 0f)
        {
            currentHealth -= damage;
            AudioManager.instance.EnemyGotHit(enemyStats.RawName);
            gotHitEffect.SetActive(true);
            if (currentHealth <= 0)
            {
                EnemyDeath();
            }
            gotHitCooldown = 0.25f;
        }
    }
    private void EnemyDeath()
    {
        GhostsManager.instance.AddEnemyToGhostList(enemyStats.RawName);
        gameObject.SetActive(false);
    }

}
