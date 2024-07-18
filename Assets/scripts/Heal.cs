using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public float healAmount = 20f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            health.Heal(healAmount);
            Destroy(gameObject);
        }
    }
}
