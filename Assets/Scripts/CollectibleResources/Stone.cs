using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour, ICollectible
{
    public void Collect()
    {
        Debug.Log("Stone Collected");
    }

}
