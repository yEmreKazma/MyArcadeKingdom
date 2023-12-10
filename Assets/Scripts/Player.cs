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
