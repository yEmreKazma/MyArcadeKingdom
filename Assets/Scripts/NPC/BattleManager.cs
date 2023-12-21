using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class BattleManager : MonoBehaviour
{

    public GameObject battleButton;
    public static BattleManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        battleButton.SetActive(false);
    }

    public void BattleAvaliable(bool status)
    {
        if (status)
        {
            BattleButtonAvaliable();
        }
    }
    void BattleButtonAvaliable()
    {
        battleButton.SetActive(true);
    }
}
