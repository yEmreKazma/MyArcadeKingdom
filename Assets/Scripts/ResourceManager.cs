using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    private int _metalCount;
    private int _woodCount;
    public int _stoneCount;

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
        _metalCount = 0;
        _woodCount = 0;
        _stoneCount = 0;
    }
    public void ResourceCollected(string resource)
    {
        if(resource == "Wood")
        {
            _woodCount++;
        }

        
    }
    public void StoneCollected()
    {
        _stoneCount++;
    }
    public void WoodCollected()
    {
        _woodCount++;
    }

    public void MetalCollected()
    {
        _metalCount++;
    }
}
