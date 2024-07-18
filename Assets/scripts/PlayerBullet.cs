using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public int damage = 10;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
