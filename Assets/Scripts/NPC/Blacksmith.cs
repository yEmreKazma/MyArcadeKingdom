using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Blacksmith : MonoBehaviour, INpc
{
    public Sword sword;
    public Axe axe;
    public Pickaxe pickaxe;
    public string npcName => "Blacksmith";

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            UpgradeItems();
        }
    }

    void UpgradeItems()
    {

    }

}

