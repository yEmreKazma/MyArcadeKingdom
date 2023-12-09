using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using static ToonyColorsPro.ShaderGenerator.Enums;

public class Player : MonoBehaviour
{
    public Item sword;
    public Axe axe;
    public Item pickaxe;
    private void Start()
    {
        sword = new Sword();

        pickaxe = new Pickaxe();    
        
    }

    private void Update()
    {
        //swordLevel = sword.level;
        //transform.GetChild(7).gameObject.SetActive(false);
        Debug.Log(sword.level);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("Collectible"))
        {
            if (collision.transform.GameObject().name == "Stone")
            {
                transform.GetChild(8).gameObject.SetActive(true);
                ResourceManager.Instance.stone.Collect();
            }
            if (collision.transform.GameObject().name == "Tree")
            {
                axe.gameObject.SetActive(true);
                ResourceManager.Instance.wood.Collect();
            }
            if (collision.transform.GameObject().name == "Iron")
            {
                transform.GetChild(8).gameObject.SetActive(true);
                ResourceManager.Instance.iron.Collect();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            if(other.transform.GameObject().name == "WallMasterf")
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
