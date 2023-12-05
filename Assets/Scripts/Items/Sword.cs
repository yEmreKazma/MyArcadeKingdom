using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Item
{
    public int swordLevel=1;
    public override void Upgrade()
    {
        swordLevel++;
    }

    public override void Use()
    {
        Debug.Log("Sword used on Enemy");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Sword Starting Level : " + swordLevel);
    }

}
