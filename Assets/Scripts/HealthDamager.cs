using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))] 
public class HealthDamager : MonoBehaviour
{
    public float damage = 40;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject collisionObject = collision.gameObject;
        HandleTakeDamage(collisionObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionObject = collision.gameObject;
        HandleTakeDamage(collisionObject);
    }

    private void HandleTakeDamage(GameObject collisionObject)
    {
        if (!collisionObject.CompareTag("Player"))
        {
            return;
        }

        PlayerStats stats = collisionObject.GetComponent<PlayerStats>();

        if (stats == null)
        {
            return;
        }

        stats.TakeDamage(damage);
    }
}
