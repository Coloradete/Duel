using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceSlash : MonoBehaviour
{
    [SerializeField] private float duration;
    [SerializeField] private int damage;
    private void OnEnable()
    {
        StartCoroutine(DisableGameObject());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == CollisionLayers.enemy)
            other.gameObject.GetComponent<EnemyBehaviour>().EnemyGotHit(damage);
    }
    private IEnumerator DisableGameObject()
    {
        yield return new WaitForSeconds(duration);
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
