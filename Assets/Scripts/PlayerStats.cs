using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private float health = 100;
    private Animator anim;
    public HealthBarUI healthBar;
    public bool isDead = false;


    private void Start()
    {
        anim = GetComponent<Animator>();
        healthBar.SetMaxHealth(maxHealth);
        int total = GameObject.FindGameObjectsWithTag("Collectible").Length;
        CollectibleCounterUI.Instance.SetTotal(total);

    }

    public void TakeDamage(float damage)
    {
        damage = Mathf.Abs(damage);
        health = Mathf.Clamp(health - damage, 0, maxHealth);
        healthBar.SetHealth(health);
        CheckHealth();
    }

    public void Heal(float heal)
    {
        heal = Mathf.Abs(heal);
        health = Mathf.Clamp(health + heal, 0, maxHealth);
        healthBar.SetHealth(health);
        CheckHealth();
    }


    public void CheckHealth()
    {
        if (health == 0)
        {
            anim.SetTrigger("isDead");
            isDead = true;
            Invoke(nameof(ReloadScene), 2);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(20); // Adds +20 health
            Debug.Log("Healed 20 HP");
        }
    }


    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
