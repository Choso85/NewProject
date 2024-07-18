using UnityEngine;
using System.Collections;

public class Boost : MonoBehaviour
{
    public float speedIncrease = 10f;
    public float attackSpeedIncrease = 0.5f;
    public float boostDuration = 5f;
    void OnTriggerEnter2D(Collider2D other)
    {
        LaunchProjectile launcher = other.GetComponent<LaunchProjectile>();
        if (launcher != null)
        {
            StartCoroutine(TemporaryBoost(launcher));
            Destroy(gameObject);
        }
    }
    private IEnumerator TemporaryBoost(LaunchProjectile launcher)
    {
        launcher.BoostPickup(speedIncrease, attackSpeedIncrease);
        yield return new WaitForSeconds(boostDuration);
        launcher.BoostPickup(-speedIncrease, -attackSpeedIncrease);
    }
}
