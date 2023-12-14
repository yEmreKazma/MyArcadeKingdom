using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
//using DG.Tweening;

public class Archer : MonoBehaviour
{
    public float attackRange = 350f;
    public Transform arrowSpawnPoint;
    public GameObject arrowPrefab;
    public float attackCooldown = 2f;

    public Transform enemyTarget;
    private GameObject target;
    private bool canAttack = true;

    void Update()
    {
        CheckForEnemies();
    }

    void CheckForEnemies()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, attackRange);
        bool isFounded = false;
        int iterator = 0;
        while (isFounded == false)
        {
            int y = Random.Range(0, hitColliders.Length);
            if (hitColliders[y].CompareTag("Enemy"))
            {
                isFounded = true;
                target = hitColliders[y].gameObject;
                enemyTarget = target.transform;
                transform.LookAt(target.transform);

                TryAttack();

            }
            iterator++;
            if (iterator > 40)
            {
                break;
            }
        }

    }

    void TryAttack()
    {
        if (canAttack)
        {
            ShootArrow();
            StartCoroutine(AttackCooldown());
        }
    }

    void ShootArrow()
    {
        if (arrowPrefab != null && arrowSpawnPoint != null)
        {
            GameObject arrow = Instantiate(arrowPrefab, arrowSpawnPoint.position, arrowSpawnPoint.rotation);
            arrow.transform.up = arrowSpawnPoint.forward;
            Rigidbody arrowRb = arrow.GetComponent<Rigidbody>();
            arrow.GetComponent<Arrow>().StartChase(enemyTarget);
        }
    }

    IEnumerator AttackCooldown()
    {
        canAttack = false;
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }
}
