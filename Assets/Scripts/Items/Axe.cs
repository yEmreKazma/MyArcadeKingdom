<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> parent of 44bcd5c (Final)
=======
>>>>>>> parent of 44bcd5c (Final)
=======
>>>>>>> parent of 44bcd5c (Final)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour, IItem
{
    public int level { get; set; } = 1;
    public MeshFilter axeLevel2;
    public MeshFilter axeLevel3;
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
        Debug.Log("Axe used on Tree");
    }

    void CheckLevel()
    {
        if (level == 2)
        {
            MeshFilter meshFilter = GetComponent<MeshFilter>();

            meshFilter = axeLevel2;
        }
        else if (level == 3)
        {
            MeshFilter meshFilter = GetComponent<MeshFilter>();

            meshFilter = axeLevel3;
        }
    }


}
