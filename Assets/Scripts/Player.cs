using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static ToonyColorsPro.ShaderGenerator.Enums;

public class Player : MonoBehaviour
{
    //Tüm kodlar test amacýyla eklenmiþtir.
    public Sword sword;

    private void Start()
    {
        sword = new Sword();
    }

    private void Update()
    {
        //swordLevel = sword.level;
        //transform.GetChild(7).gameObject.SetActive(false);
        Debug.Log(sword.swordLevel);
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
                transform.GetChild(7).gameObject.SetActive(true);
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
                if (sword.swordLevel == 1)
                {
                    sword.swordLevel++;
                }
            }
        }
        if (other.transform.GameObject().name == "Blacksmith")
        {
            if (sword.swordLevel == 1)
            {
                sword.swordLevel++;
            }
        }
        if (other.transform.GameObject().name == "WeaponMaster")
        {
            if (sword.swordLevel == 1)
            {
                sword.swordLevel++;
            }
        }
    }

}
