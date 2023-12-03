using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectibles : MonoBehaviour
{
    public int resourceAmount;
    public float respawnTime;
    public bool isDepleted;

    public int Collect(int amount)
    {
        return amount;
    }
}
