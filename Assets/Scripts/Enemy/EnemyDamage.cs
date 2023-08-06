using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    protected EnemyCtrl enemyCtrl;
    protected KillCounter killCounter;


    public int health = 1;

    private void Awake()
    {
        this.killCounter = GameObject.Find("KCO").GetComponent<KillCounter>();

        this.enemyCtrl = GetComponent<EnemyCtrl>();
    }

    public void takeDamage(int damage)
    {
        if (this.enemyCtrl.enemyMove.isDone == true)
        {
            health -= damage;

            if (health <= 0)
            {
                this.isDead();
                this.killCounter.addKill();

            }
        }
    }
    private void isDead()
    {
        Destroy(gameObject);
    }

}
