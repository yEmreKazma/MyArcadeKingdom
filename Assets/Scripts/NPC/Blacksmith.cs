using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class Blacksmith : MonoBehaviour, INpc
{
    public Sword sword;
    public Axe axe;
    public Pickaxe pickaxe;
    int currentLevel;
    int axeLevel;
    public string npcName => "Blacksmith";

    int requiredAmount;
    public TextMeshPro requiredText;

    private void Start()
    {
        requiredAmount = 50;
        currentLevel = 1;
    }

    void Update()
    {
        requiredText.text = requiredAmount.ToString();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (currentLevel == 1)
            {
                if (requiredAmount > 0 && ResourceManager.Instance.stoneCount > 0)
                {
                    ResourceManager.Instance.stoneCount--;
                    requiredAmount--;
                }
                else if (requiredAmount == 0)
                {
                    if (axe.level == 1 && pickaxe.level == 1)
                    {
                        Debug.Log("Items upgraded to Level 2");
                        axe.Upgrade();
                        pickaxe.Upgrade();
                        currentLevel += 1;
                        Debug.Log("Axe Level : " + axe.level + " Pickaxe LEvel " + pickaxe.level + " Current LEvel : " + currentLevel);
                        requiredAmount = 75;
                    }
                }
            }
            else if (currentLevel == 2)
            {
                if (requiredAmount > 0 && ResourceManager.Instance.ironCount > 0)
                {
                    ResourceManager.Instance.ironCount--;
                    requiredAmount--;
                }
                else if (requiredAmount == 0)
                {
                    if (axe.level == 2 && pickaxe.level == 2)
                    {
                        Debug.Log("Items upgraded to Level 3");
                        axe.Upgrade();
                        pickaxe.Upgrade();
                        currentLevel += 1;
                    }
                }
            }

        }
    }
}

