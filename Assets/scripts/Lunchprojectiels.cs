using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float attackSpeed = 1f;
    private float nextAttackTime = 0f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && Time.time >= nextAttackTime)
        {
            Shoot();
            nextAttackTime = Time.time + 1f / attackSpeed;
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = firePoint.up * bulletSpeed;
    }
    public void BoostPickup(float speedIncrease, float attackSpeedIncrease)
    {
        bulletSpeed += speedIncrease;
        attackSpeed += attackSpeedIncrease;
    }
}
