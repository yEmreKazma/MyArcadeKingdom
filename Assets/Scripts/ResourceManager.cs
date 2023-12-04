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
        stone = new Stone();
        wood = new Wood();
        iron = new Iron();

        stoneCount = 0;
        woodCount = 0;
        ironCount = 0;
    }
    public void ResourceCollected(string resource)
    {
        if(resource == "Wood")
        {
            woodCount++;
            Debug.Log("wood count : " + woodCount);
        }
        else if (resource == "Stone")
        {
            stoneCount++;
            Debug.Log("stone count : " + stoneCount);
        }
        else if (resource == "Iron")
        {
            ironCount++;
            Debug.Log("metal count : " + ironCount);
        }
    }

    public void ResourceSpend(string resource)
    {
        if (resource == "Wood")
        {
            woodCount--;
            Debug.Log("wood count : " + woodCount);
        }
        else if (resource == "Stone")
        {
            stoneCount--;
            Debug.Log("stone count : " + stoneCount);
        }
        else if (resource == "Iron")
        {
            ironCount--;
            Debug.Log("metal count : " + ironCount);
        }
    }

}
