using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle;
using DG.Tweening;

public class Wood : MonoBehaviour, ICollectible
{
    public string resourceName => "Wood";
    public int amount { get; set; }
    public float collectTime => 2f;
    public float respawnTime => 15f;
    public bool isDepleted { get; set; }

    public WoodPiece woodPiecePrefab;
    public Player target;
    bool canRespawn = true;

    public void Start()
    {
        amount = 5;
        isDepleted = false;
    }

    private void Update()
    {
        //TryRespawn();
    }
    public void Collect()
    {
        ResourceManager.Instance.woodCount += 1 ;
        if (amount > 0)
        {
            amount -= 1;
            ResourceManager.Instance.woodCount++;
            //SpawnTreePiece();
            Debug.Log("Wood Collected");

        }
        if (amount < 1)
        {
            Debug.Log("Wood");

        }   
    }

    /*void TryRespawn()
    {
        Respawn();
        StartCoroutine(RespawnCooldown());

    }
    public void Respawn()
    {
        Debug.Log("Tree Respawned");
        amount = 5;
    }
    
    
    void SpawnTreePiece()
    {
        var woodPiece = Instantiate(woodPiecePrefab, transform.position, Quaternion.identity);
        woodPiece.targetPlayer = target.gameObject;
        woodPiece.FollowPlayer();
    }
    
    void TreeDepleted(bool status)
    {
        Debug.Log("Tree Depleted");
        isDepleted = status;
    }


    IEnumerator RespawnCooldown()
    {
        canRespawn = false;
        yield return new WaitForSeconds(respawnTime);
        canRespawn = true;
    }*/
}
