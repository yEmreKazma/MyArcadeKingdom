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
    public float respawnTime => 20f;
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
        if (!isDepleted)
        {
            if (amount > 1)
            {
                ResourceManager.Instance.woodCount++;
                amount--;
                SpawnTreePiece();
            }
            else if (amount <= 1)
            {
                ResourceManager.Instance.woodCount++;
                amount--;
                target.animator.SetBool("IsCollecting", false);
                target.axe.gameObject.SetActive(false);
                Debug.Log("Wood Depleted");
                Debug.Log(amount);
                isDepleted = true;
                gameObject.GetComponent<Collider>().enabled = false;
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                canRespawn = true;
                TryRespawn();
            }
        }
    }

    void TryRespawn()
     {
            StartCoroutine(RespawnCooldown());
    }
     public void Respawn()
     {
        gameObject.GetComponent<Collider>().enabled = true;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        Debug.Log("Tree Respawned");
        isDepleted = false;
         amount = 5;
     }


     IEnumerator RespawnCooldown()
     {
        canRespawn = false;
        yield return new WaitForSeconds(respawnTime);
        Respawn();
        canRespawn = true;
    }
   
     void SpawnTreePiece()
     {
         var woodPiece = Instantiate(woodPiecePrefab, transform.position, Quaternion.identity);
         woodPiece.targetPlayer = target.gameObject;
         woodPiece.FollowPlayer();
     }
   
}
