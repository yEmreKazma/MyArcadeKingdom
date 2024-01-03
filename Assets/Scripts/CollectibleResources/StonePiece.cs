using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StonePiece : MonoBehaviour
{
    public GameObject targetPlayer;
    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        targetPlayer = GameObject.FindGameObjectWithTag("Player");
    }

    public void FollowPlayer()
    {
        transform.DOMove(targetPlayer.transform.position, 1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
