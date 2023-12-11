using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class Enemy : MonoBehaviour
{
    public Transform target;

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
