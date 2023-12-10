using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : MonoBehaviour, ICollectible
{
    public string resourceName => "Iron";
    public int amount { get; set; }
    public float collectTime => 1f;
    public float respawnTime => 45f;
    public bool isDepleted { get; set; }

    public void Start()
    {
        amount = 5;
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
        Debug.Log("Iron Collected");
        amount--;
        ResourceManager.Instance.ironCount++;
        
        if (amount <= 0)
        {
            isDepleted = true;
            //Respawn();
        }
    }
    /*public void Respawn()
    {
        StartCoroutine(RespawnStone());
    }
    IEnumerator RespawnStone()
    {
        yield return new WaitForSeconds(respawnTime);
        Debug.Log("Metal Respawned");
        amount = 5;
        isDepleted = false;
    }*/
    /*public void Hit()
    {
        StartCoroutine(CollectTime());
    }
    IEnumerator CollectTime()
    {
        yield return new WaitForSeconds(collectTime);
        Debug.Log("vuru�");
    }*/
}
