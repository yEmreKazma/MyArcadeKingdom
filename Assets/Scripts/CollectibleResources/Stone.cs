using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour, ICollectible
{
    public string resourceName => "Stone";
    //public int amount { get; set; }
    public float respawnTime => 15f;
    public bool isDepleted { get; set; }

    public int amount { get; set; } = 5;

    public StonePiece stonePiecePrefab;
    public Player target;
    //bool canRespawn;

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
                ResourceManager.Instance.stoneCount++;
                amount--;
                SpawnStonePiece();
            }
            else if (amount <= 1)
            {
                ResourceManager.Instance.stoneCount++;
                amount--;
                target.animator.SetBool("IsCollecting", false);
                target.pickaxe.gameObject.SetActive(false);
                Debug.Log("Stone Depleted");
                Debug.Log(amount);
                isDepleted = true;
                gameObject.GetComponent<Collider>().enabled = false;
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                //canRespawn = true;
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
        Debug.Log("Stone Mine Respawned");
        isDepleted = false;
        amount = 5;
    }


    IEnumerator RespawnCooldown()
    {
        //canRespawn = false;
        yield return new WaitForSeconds(respawnTime);
        Respawn();
        //canRespawn = true;
    }

    void SpawnStonePiece()
    {
        var stonePiece = Instantiate(stonePiecePrefab, transform.position, Quaternion.identity);
        stonePiece.targetPlayer = target.gameObject;
        stonePiece.FollowPlayer();
    }

}

