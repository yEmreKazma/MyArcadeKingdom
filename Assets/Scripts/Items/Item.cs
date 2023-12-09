using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Item 
{
    int level { get; set; }
    public void Use();
    public void Upgrade();
}
