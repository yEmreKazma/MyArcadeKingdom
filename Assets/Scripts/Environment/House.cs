using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class House : MonoBehaviour
{
    public GameObject[] housePrefab;

    void Update()
    {
       
        if (LevelManager.Instance.currentLevel > 1)
        {
            for(int i =0; i< housePrefab.Length; i++)
            {
                GameObject house = LevelManager.Instance.housePrefabs[i];
                house.GetComponent<MeshRenderer>().sharedMaterial = LevelManager.Instance.housePrefabs[LevelManager.Instance.currentLevel].GetComponent<MeshRenderer>().sharedMaterial;
            }
            
        }

    }
}
