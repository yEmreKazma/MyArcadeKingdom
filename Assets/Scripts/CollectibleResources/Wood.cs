using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle;
using DG.Tweening;
using System.CodeDom.Compiler;

public class Wood : MonoBehaviour, ICollectible
{
    public string resourceName => "Wood";
    public float respawnTime => 15f;
    public bool isDepleted { get; set; }
    public int amount { get; set; }

    public WoodPiece woodPiecePrefab;
    public Player target;
    bool canRespawn;

    private void Start()
    {
        amount = 5;
        isDepleted = false;
    }
    public void Collect()
    {
        if(amount > 0)
        {
            ResourceManager.Instance.woodCount++;
            amount--;
        }
        else if (amount < 1)
        {
            Debug.Log("Wood Depleted");
            Debug.Log(amount);
            isDepleted = true;
            gameObject.SetActive(false);
            TryRespawn();
        }

    }

    void TryRespawn()
     {
        if (canRespawn)
        {
            StartCoroutine(RespawnCooldown());
        }
    }
     public void Respawn()
     {
        gameObject.SetActive(true);
         Debug.Log("Tree Respawned");
         amount = 5;
     }


     IEnumerator RespawnCooldown()
     {
        canRespawn = false;
        yield return new WaitForSeconds(respawnTime);
        canRespawn = true;
    }
    /*

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
    */

}
