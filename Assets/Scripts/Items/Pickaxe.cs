using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : MonoBehaviour, IItem
{
    public int level { get; set; } = 1;
    public MeshFilter pickaxeLevel2;
    public MeshFilter pickaxeLevel3;
    void Start()
    {
        level = 1;
    }
    private void Update()
    {
        CheckLevel();
    }
    public void Upgrade()
    {
        level += 1;
    }

    public void Use()
    {
        Debug.Log("Pickaxe used on Mines");
    }

    void CheckLevel()
    {
        if (level == 2)
        {
            MeshFilter meshFilter = GetComponent<MeshFilter>();

            meshFilter = pickaxeLevel2;
        }
        else if (level == 3)
        {
            MeshFilter meshFilter = GetComponent<MeshFilter>();

            meshFilter = pickaxeLevel3;
        }
    }

}
