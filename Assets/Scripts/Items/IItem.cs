using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem 
{
    int level { get; set; }
    public void Use();
    public void Upgrade();
}
