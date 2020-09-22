using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAttack : MonoBehaviour
{
    [SerializeField] private int damage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == CollisionLayers.enemy)
            other.gameObject.GetComponent<EnemyBehaviour>().EnemyGotHit(damage);
    }
}
