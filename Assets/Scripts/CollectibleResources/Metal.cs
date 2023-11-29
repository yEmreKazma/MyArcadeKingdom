using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metal : MonoBehaviour, ICollectible
{
    public void Collect()
    {
        Debug.Log("Metal Collected");
    }

}
