using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour, ICollectible
{
    public string resourceName => "Stone";
    public int amount { get; set; }
    public float collectTime => 3f;
    public float respawnTime => 45f;
    public bool isDepleted { get; set; }
    public void Start()
    {
        amount = 5;
        isDepleted = false;
    }

    public void Collect()
    {

            Debug.Log("Stone Collected");
            amount--;
            ResourceManager.Instance.stoneCount++;
            if (amount <= 0)
            {
                isDepleted = true;
                //Respawn();
            }
       


    }

    /*
    public void Respawn()
    {
        StartCoroutine(RespawnStone());
    }
    IEnumerator RespawnStone()
    {
        yield return new WaitForSeconds(respawnTime);
        Debug.Log("Stone Respawned");
        amount = 5;
        isDepleted = false;
    }
    */

}

