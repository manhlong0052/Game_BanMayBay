using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    protected EnemyCtrl enemyCtrl;

    public float speed = 20f;
    public Rigidbody2D rb;

    private void Awake()
    {
        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    private void Start()
    {
        rb.velocity = transform.up * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyCtrl enemy = collision.GetComponent<EnemyCtrl>();
        if (enemy != null)
        {
            enemy.enemyDamage.takeDamage(1);
        }

        Destroy(gameObject);
    }
}
