using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth: MonoBehaviour
{
    public UnityEvent onDeath;
    public int currentHealth = 100;
    public int maxHealth = 100;
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
           Die();
        }
    }
    private void Die()
    {
        onDeath.Invoke();
        Destroy(gameObject);
    }
}
