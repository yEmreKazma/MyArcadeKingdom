using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine.Pool;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public delegate void EnemyDeath(Enemy enemy);
    public event EnemyDeath OnEnemyDeath;

    public void Die()
    {
        // D��man �ld���nde bu fonksiyon �a�r�l�r.
        OnEnemyDeath?.Invoke(this);
    }
    private void Update()
    {
        transform.LookAt(target);
        EnemyMove();
    }

    void EnemyMove()
    {
        if (Input.GetKeyDown("space"))
        {
            transform.DOMove(target.transform.position, 10);
        }

    }
}