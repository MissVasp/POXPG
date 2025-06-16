using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    public Image fill;       // Reference to your HealthBar_Fill image with "Filled" type
    public Gradient gradient;

    private float maxHealth;

    public void SetMaxHealth(float maxHealth)
    {
        this.maxHealth = maxHealth;
        SetHealth(maxHealth);  // Initialize full health fill
    }

    public void SetHealth(float currentHealth)
    {
        float fillAmount = currentHealth / maxHealth;  // normalize health (0-1)
        fill.fillAmount = fillAmount;
        fill.color = gradient.Evaluate(fillAmount);
    }
}
