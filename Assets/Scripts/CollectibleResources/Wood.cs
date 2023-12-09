using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour, ICollectible
{
    public string resourceName => "Wood";
    public int amount { get ; set ; }
    public float collectTime => 1f;
    public float respawnTime => 45f;
    public bool isDepleted { get; set; }

    public GameObject woodPiecePrefab;
    GameObject woodEffect;

    public void Start()
    {
        amount = 5;
        isDepleted = false;
    }

    public void Collect()
    {
        Debug.Log("Wood Collected");
        amount--;
        ResourceManager.Instance.woodCount++;
        woodEffect = Instantiate(woodPiecePrefab, transform.position, Quaternion.identity);
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
        Debug.Log("Tree Respawned");
        amount = 5;
        isDepleted = false;
    }*/
}
