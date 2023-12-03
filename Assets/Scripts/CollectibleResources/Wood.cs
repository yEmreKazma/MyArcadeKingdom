using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood :MonoBehaviour , ICollectible
{
    public void Collect()
    {
        Debug.Log("Wood Collected");
    }

}
