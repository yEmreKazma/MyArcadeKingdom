using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour, IItem
{
    public int level { get; set; }

    public void Upgrade()
    {
        level++;
    }

    public void Use()
    {
        Debug.Log("Sword used on Enemy");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Sword Starting Level : " + level);
    }

}
