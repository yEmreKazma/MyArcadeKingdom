using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Item
{
    public override void Upgrade()
    {
        level++;
    }

    public override void Use()
    {
        Debug.Log("Sword used on Enemy");
    }

    // Start is called before the first frame update
    void Start()
    {
        
        level = 1;
        Debug.Log("Sword Starting Level : " + level);
    }

}
