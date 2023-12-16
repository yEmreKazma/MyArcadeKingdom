using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iron : MonoBehaviour, ICollectible
{
    public string resourceName => "Iron";
    //public int amount { get; set; }
    public float respawnTime => 20f;
    public bool isDepleted { get; set; }

    public int amount { get; set; }

    public IronPiece ironPiecePrefab;
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
                ResourceManager.Instance.ironCount++;
                amount--;
                SpawnIronPiece();
            }
            else if (amount <= 1)
            {
                ResourceManager.Instance.ironCount++;
                amount--;
                target.animator.SetBool("IsCollecting", false);
                target.pickaxe.gameObject.SetActive(false);
                Debug.Log("Iron Depleted");
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
        Debug.Log("Iron Mine Respawned");
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

    void SpawnIronPiece()
    {
        var ironPiece = Instantiate(ironPiecePrefab, transform.position, Quaternion.identity);
        ironPiece.targetPlayer = target.gameObject;
        ironPiece.FollowPlayer();
    }

}
