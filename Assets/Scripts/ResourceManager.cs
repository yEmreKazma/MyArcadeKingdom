using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public ICollectible iron;
    public ICollectible wood;
    public ICollectible stone;

    public int stoneCount;
    public int woodCount;
    public int ironCount;

    public static ResourceManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;         
        }

    }
    void Start()
    {
        stoneCount = 0;
        woodCount = 0;
        ironCount = 0;
    }
    public void ResourceCollected(string resource, ICollectible collectedResource)
    {
        if(resource == "Wood")
        {
            wood = collectedResource;
            wood.Collect();
        }
        else if (resource == "Stone")
        {
            stone = collectedResource;
            stone.Collect();
        }
        else if (resource == "Iron")
        {
           iron = collectedResource;
           iron.Collect();
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
