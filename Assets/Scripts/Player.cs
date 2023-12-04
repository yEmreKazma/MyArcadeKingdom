using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static ToonyColorsPro.ShaderGenerator.Enums;

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

}
