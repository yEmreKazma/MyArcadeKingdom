using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static ToonyColorsPro.ShaderGenerator.Enums;

public class Player : MonoBehaviour
{
    //T�m kodlar test amac�yla eklenmi�tir.
    public Sword sword;

    private void Start()
    {
        sword = new Sword();
    }

    private void Update()
    {
        //swordLevel = sword.level;
        //Debug.Log(swordLevel);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("Collectible"))
        {
            if (collision.transform.GameObject().name == "Stone")
            {
                ResourceManager.Instance.stone.Collect();
            }
            if (collision.transform.GameObject().name == "Tree")
            {
                ResourceManager.Instance.wood.Collect();
            }
            if (collision.transform.GameObject().name == "Iron")
            {
                ResourceManager.Instance.iron.Collect();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            if(other.GameObject().name == "WeaponMaster")
            {
                sword.swordLevel++;
            }
        }
    }

}
