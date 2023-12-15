using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour, ICollectible
{
    public string resourceName => "Stone";
    //public int amount { get; set; }
    public float respawnTime => 45f;
    public bool isDepleted { get; set; }

    public int amount { get; set; } = 5;

    public void Start()
    {
       
        isDepleted = false;
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Collect();
        }
    }

    public void Collect()
    {

        ResourceManager.Instance.stoneCount++; 
  Debug.Log("Stone Depleted");
            isDepleted = true;
            //Respawn();
        
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

