using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : MonoBehaviour, Item
{
    public int level { get; set; }

    public void Upgrade()
    {
        level++;
    }

    public void Use()
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
