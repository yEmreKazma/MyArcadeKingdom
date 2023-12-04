using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : Item
{
    int pickaxeLevel;
    public override void Upgrade()
    {
        pickaxeLevel++;
    }

    public override void Use()
    {
        Debug.Log("Pickaxe used on Minerals");
    }

    // Start is called before the first frame update
    void Start()
    {

        pickaxeLevel = 1;
        Debug.Log("Pickaxe Starting Level : " + pickaxeLevel);
    }

}
