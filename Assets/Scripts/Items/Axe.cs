using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Item
{
    public override void Upgrade()
    {
        level++;
    }

    public override void Use()
    {
        Debug.Log("Axe used on Tree");
    }

    // Start is called before the first frame update
    void Start()
    {
        
        level = 1;
        Debug.Log("Axe Starting Level : " + level);
    }

}
