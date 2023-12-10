using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public Iron iron;
    public Wood wood;
    public Stone stone;

    public int stoneCount;
    public int woodCount;
    public int ironCount;

    public GameObject woodPiecePrefab;
    GameObject woodEffect;
    public static ResourceManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        stoneCount = 0;
        woodCount = 0;
        ironCount = 0;
    }



    public void ResourceCollected(string resource)
    {
        if(resource == "Wood")
        {
            woodEffect = Instantiate(woodPiecePrefab, transform.position, Quaternion.identity);
            //woodCount++;
            wood.Collect();
        }
        else if (resource == "Stone")
        {
            stone.Collect();
        }
        else if (resource == "Iron")
        {
            ironCount++;
        }
    }

    public void ResourceSpend(string resource, int amount)
    {
        if (resource == "Wood")
        {
            woodCount = woodCount - amount;
            Debug.Log("wood count : " + woodCount);
        }
        else if (resource == "Stone")
        {
            stoneCount = stoneCount - amount;
            Debug.Log("stone count : " + stoneCount);
        }
        else if (resource == "Iron")
        {
            ironCount = ironCount - amount;
            Debug.Log("metal count : " + ironCount);
        }
    }

}
