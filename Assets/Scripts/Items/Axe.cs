using Palmmedia.ReportGenerator.Core.Parser.Filtering;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour, IItem
{
    public int level;
    public MeshFilter axeLevel2;
    public MeshFilter axeLevel3;
    MeshFilter mFilter;
    void Start()
    {
        mFilter = GetComponent<MeshFilter>();
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
        Debug.Log("Axe used on Tree");
    }

    void CheckLevel()
    {
        if (level == 2)
        {
            Debug.Log("Level atladý");
            mFilter.mesh = axeLevel2.mesh;
        }
        else if (level == 3)
        {
            MeshFilter meshFilter = GetComponent<MeshFilter>();

            mFilter.mesh = axeLevel3.mesh;
        }
    }


}
