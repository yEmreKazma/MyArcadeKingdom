using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : Item
{
    public override void Upgrade()
    {
        level++;
    }

    public override void Use()
    {
        Debug.Log("Pickaxe used on Minerals");
    }

    // Start is called before the first frame update
    void Start()
    {
        
        level = 1;
        Debug.Log("Pickaxe Starting Level : " + level);
    }

}
