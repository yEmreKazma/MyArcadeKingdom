using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Tüm kodlar test amacýyla eklenmiþtir.
    public Sword sword;
    int swordLevel;

    private void Start()
    {
        sword = new Sword();
    }

    private void Update()
    {
        swordLevel = sword.level;
        Debug.Log(swordLevel);
    }

    private void OnTriggerStay(Collider other)
    {
        //Spend some resources
        if (other.CompareTag("Blacksmith"))
        {
            sword.Upgrade();
        }
    }
}
