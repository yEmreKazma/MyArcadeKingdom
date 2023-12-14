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
    float collectCooldown = 2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }


    void OnTriggerStay(Collider other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.CompareTag("Collectible"))
        {
            StartCoroutine(CollectCooldown(other));
        }
        if (other.CompareTag("NPC"))
        {
            if (other.transform.GameObject().name == "WallMaster")
            {
                if(ResourceManager.Instance.woodCount> 0)
                {
                    ResourceManager.Instance.ResourceSpend("Wood", 1);
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
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            animator.SetBool("IsCollecting", false);
            StopAllCoroutines();
            axe.gameObject.SetActive(false);
            pickaxe.gameObject.SetActive(false);

        }

    }


    IEnumerator CollectCooldown(Collider other)
    {
        Debug.Log("Collecting");

        yield return new WaitForSeconds(collectCooldown);

        animator.SetBool("IsCollecting", true);
        if (other.gameObject.name == "Tree")
        {
            axe.gameObject.SetActive(true);
            Collect("Wood");
        }
        else if (other.gameObject.name == "Stone")
        {
            pickaxe.gameObject.SetActive(true);
            Collect("Stone");
        }
        else if (other.gameObject.name == "Iron")
        {
            pickaxe.gameObject.SetActive(true);
            Collect("Iron");
        }

    }

    void Collect(string resource)
    {
        ResourceManager.Instance.ResourceCollected(resource);
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            if (other.transform.GameObject().name == "WallMaster")
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
    }*/

}
