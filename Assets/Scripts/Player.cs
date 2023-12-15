using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
    ICollectible collectible;

    bool isCollecting;
    bool canCollect;
    float collectCooldown = 20f;

    string collectType;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {

            animator.SetBool("IsCollecting", true);

            switch (other.gameObject.name)
            {
                case "Tree":
                    axe.gameObject.SetActive(true);
                    collectType = "Wood";
                    collectible = other.GetComponent<Wood>();
                    break;
                case "Stone":
                    pickaxe.gameObject.SetActive(true);
                    collectType = "Stone";
                    collectible = other.GetComponent<Stone>();
                    break;
                case "Iron":
                    pickaxe.gameObject.SetActive(true);
                    collectType = "Iron";
                    collectible = other.GetComponent<Iron>();
                    break;
            }
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

        animator.SetBool("IsCollecting", true);
        if (other.gameObject.name == "Tree")
        {
            Debug.Log(other.gameObject.name);
            axe.gameObject.SetActive(true);
            collectType = "Wood";
        }
        else if (other.gameObject.name == "Stone")
        {
            pickaxe.gameObject.SetActive(true);
            collectType = "Stone";
        }
        else if (other.gameObject.name == "Iron")
        {
            pickaxe.gameObject.SetActive(true);

            collectType = "Iron";
        }
        yield return new WaitForSeconds(collectCooldown);
    }

    void Collect()
    {
        ResourceManager.Instance.ResourceCollected(collectType, collectible);
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
