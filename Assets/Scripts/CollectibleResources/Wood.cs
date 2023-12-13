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
    bool isCollecting;
    bool eventGiven;

    public void Start()
    {
        amount = 5;
        isDepleted = false;
    }

    private void Update()
    {
       
    }

    private void OnCollisionStay(Collision collision)
    {
        if (eventGiven)
        {
            return;
        }
        if (collision.transform.CompareTag("Player"))
        {
            eventGiven = true;
            //Invoke("Collect", collectTime);
            InvokeRepeating("Collect", 0f, collectTime);
            //Collect();
        }
    }

    public void Collect()
    {
        
        if (amount > 0)
        {
            amount--;
            ResourceManager.Instance.woodCount++;
            SpawnTreePiece();
            Debug.Log("Wood Collected");


        }
        else if (amount < 1){
            Debug.Log("Tree Depleted");
            CancelInvoke("Collect");
            isDepleted = true;

            Invoke("Respawn", respawnTime);
            transform.gameObject.SetActive(false);
        }               
        eventGiven = false;
    }

    void SpawnTreePiece()
    {
        var woodPiece = Instantiate(woodPiecePrefab, transform.position, Quaternion.identity);
        woodPiece.targetPlayer = target.gameObject;
        woodPiece.FollowPlayer();
    }
    public void Respawn()
    {
        isDepleted = false;
        Debug.Log("Tree Respawned");
        transform.gameObject.SetActive(true);
        amount = 5;
    }
}
