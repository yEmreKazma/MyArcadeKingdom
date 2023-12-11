using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Archer : MonoBehaviour
{
    public Transform arrowSpawnPoint; 
    public GameObject arrowPrefab;
    private Transform target;

    void Attack()
    {
        // Okun spawn edilmesi
        if (arrowPrefab != null && arrowSpawnPoint != null)
        {
            GameObject arrow = Instantiate(arrowPrefab, arrowSpawnPoint);
            arrow.transform.DOScale(250f, 0.1f);
            arrow.transform.DORotate(target.position,0.1f);
            arrow.transform.DOMove(target.position, 1f);
            Debug.Log("Ateþ");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Düþman Girdi");
            target = collision.transform;
            Attack();
        }
    }

}
