using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        while(isFounded == false)
        {
           int y = Random.Range(0, hitColliders.Length);
            if (hitColliders[y].CompareTag("Enemy"))
            {
                isFounded = true;


                    // Düþmaný bulduk
                    target = hitColliders[y].gameObject;

                    enemyTarget = target.transform;
                    // Düþmanýn yönüne doðru bak
                    transform.LookAt(target.transform);

                    TryAttack();

                
            }
            iterator++;
            if(iterator > 40)
            {
                break;
            }
        }

    }

    void TryAttack()
    {
        if (canAttack)
        {
            // Ok at
            ShootArrow();

            // Saldýrý hýzýný kontrol etmek için bekleme süresi ekle
          StartCoroutine(AttackCooldown());
        }
    }

    void ShootArrow()
    {
        if (arrowPrefab != null && arrowSpawnPoint != null)
        {
            // Okun kopyasýný oluþtur ve ileriye doðru fýrlat
            GameObject arrow = Instantiate(arrowPrefab, arrowSpawnPoint.position, arrowSpawnPoint.rotation);
            arrow.transform.up = arrowSpawnPoint.forward;
            Rigidbody arrowRb = arrow.GetComponent<Rigidbody>();
            arrow.GetComponent<Arrow>().StartChase(enemyTarget);
            //arrowRb.AddForce(arrowSpawnPoint.forward * 10f, ForceMode.Impulse);
        }
    }

    IEnumerator AttackCooldown()
    {
        canAttack = false;

        // Belirli bir süre boyunca saldýrý yapma yeteneðini kapat
        yield return new WaitForSeconds(attackCooldown);

        canAttack = true;
    }
}
