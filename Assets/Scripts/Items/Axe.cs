using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour, IItem
{
    public int level { get; set; }

    void Start()
    {
        level = 1;
        //Debug.Log("Axe Starting Level : " + level);
    }
    public void Upgrade()
    {
        level++;
    }

    public void Use()
    {
        Debug.Log("Axe used on Tree");
    }



}
