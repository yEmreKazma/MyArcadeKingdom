using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using static ToonyColorsPro.ShaderGenerator.Enums;

public class Player : MonoBehaviour
{
    public Sword sword;
    public Axe axe;
    public Pickaxe pickaxe;

    Rigidbody rb;
    Animator animator;

    bool isCollecting;
    bool canCollect;
    float collectCooldown=1f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();    
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            animator.SetBool("IsCollecting", true);
        }
        else
        {
            animator.SetBool("IsCollecting", false);
        }
    }

    void TryAttack()
    {
        if (canCollect)
        {
            // Ok at
            Collect();

            // Saldýrý hýzýný kontrol etmek için bekleme süresi ekle
            StartCoroutine(CollectCooldown());
        }
    }
    IEnumerator CollectCooldown()
    {
        isCollecting = false;
        yield return new WaitForSeconds(collectCooldown);
        isCollecting = true;
    }

    void Collect()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            if (other.transform.GameObject().name == "WallMasterf")
            {
                if (sword.level == 1)
                {
                    sword.level++;
                }
            }
        }
        if (other.transform.GameObject().name == "Blacksmith")
        {
            if (sword.level == 1)
            {
                sword.level++;
            }
        }
        if (other.transform.GameObject().name == "WeaponMaster")
        {
            if (sword.level == 1)
            {
                sword.level++;
            }
        }
    }

}
