using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using DG.Tweening;

public class WallMaster : MonoBehaviour, INpc
{
    public string npcName => "WallMaster";
    public TextMeshPro requiredText;
    int requiredAmount;
    public GameObject wall;

    private void Start()
    {
        requiredAmount = 50;
    }

    void Update()
    {
        requiredText.text = requiredAmount.ToString();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (requiredAmount > 0 && ResourceManager.Instance.woodCount > 0)
            {
                ResourceManager.Instance.woodCount--;
                requiredAmount--;
            }
            else if (requiredAmount == 0)
            {
                wall.gameObject.transform.DOLocalMoveY(-0.44f, 6f);
                MissionManager.Instance.iterator++;
                BattleManager.Instance.BattleAvaliable(true);
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (MissionManager.Instance.iterator == 1)
            {
                MissionManager.Instance.iterator++;
            }
        }
    }

}

