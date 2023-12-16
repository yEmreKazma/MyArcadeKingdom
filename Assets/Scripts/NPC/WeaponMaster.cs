using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeaponMaster : MonoBehaviour, INpc
{
    public string npcName => "WeaponMaster";

    int requiredAmount;
    public TextMeshPro requiredText;
    private void Start()
    {
        requiredAmount = 75;
    }

    void Update()
    {
        requiredText.text = requiredAmount.ToString();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (requiredAmount > 0 && ResourceManager.Instance.ironCount > 0)
            {
                ResourceManager.Instance.ironCount--;
                requiredAmount--;
            }
            else if (requiredAmount == 0)
            {
                Debug.Log("Archer Upgraded");
            }

        }
    }

}
