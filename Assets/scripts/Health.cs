using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;
    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
    public void Heal(float amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
