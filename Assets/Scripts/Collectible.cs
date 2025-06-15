using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        //TODO Send info to Player
        //TODO Check if inventory component exists
        Inventory inventory = collision.gameObject.GetComponent<Inventory>();

        Destroy(gameObject);
    }
}
