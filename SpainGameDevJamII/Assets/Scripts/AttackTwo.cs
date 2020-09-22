using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTwo : MonoBehaviour
{
    private ObjectsPool objectsPool;
    private HeroMovement heroMovement;

    [SerializeField] private float projectileSpeed;
    private void Awake()
    {
        objectsPool = GetComponent<ObjectsPool>();
        heroMovement = GetComponentInParent<HeroMovement>();
    }
    private void OnEnable()
    {
        GameObject projectile = objectsPool.GetNextPoolObject();
        projectile.transform.position = transform.position;
        projectile.GetComponent<Rigidbody>().velocity = heroMovement.GetMovementDirection() * projectileSpeed;
    }
}
