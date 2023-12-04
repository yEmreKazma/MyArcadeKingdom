using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Item
{
    int axeLevel;

    void Start()
    {

        axeLevel = 1;
        Debug.Log("Axe Starting Level : " + axeLevel);
    }
    public override void Upgrade()
    {
        axeLevel++;
    }

    public override void Use()
    {
        Debug.Log("Axe used on Tree");
    }



}
