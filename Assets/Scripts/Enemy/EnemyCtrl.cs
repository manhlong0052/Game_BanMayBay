using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    public EnemyMove enemyMove;
    public EnemyDamage enemyDamage;


    private void Awake()
    {
        this.enemyMove = GetComponent<EnemyMove>();
        this.enemyDamage = GetComponent<EnemyDamage>();
    }
}
