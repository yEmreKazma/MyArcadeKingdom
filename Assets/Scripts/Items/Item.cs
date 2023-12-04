using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item 
{
    public int level;
    public abstract void Use();
    public abstract void Upgrade();
}
