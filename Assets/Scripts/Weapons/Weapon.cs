using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float spawnTimer = 0f;
    public float spawnDelay = 1f;

    // Update is called once per frame
    void Update()
    {
        this.shoot();
    }

    private void shoot()
    {
        this.spawnTimer += Time.deltaTime;
        if (this.spawnTimer < this.spawnDelay) return;
        this.spawnTimer = 0f;

        Instantiate(this.bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
