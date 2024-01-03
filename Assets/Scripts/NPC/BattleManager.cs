using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;
public class BattleManager : MonoBehaviour
{

    public GameObject battleButton;
    public static BattleManager Instance;
    public TextMeshProUGUI expText;
    public GameObject questTab;
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

    void BattleLost()
    {
        //battleButton.SetActive(false);
    }

    public void BattleWon()
    {
        int temp = LevelManager.Instance.currentExperience;
        if (LevelManager.Instance.currentExperience - temp < 50)
        {
            LevelManager.Instance.currentExperience += 50;

            MissionManager.Instance.missionProgressText.text = 1 + "/" + 1;
            MissionManager.Instance.questTab.transform.DOScale(0, 5f);
            CameraManager.Instance.BattleOver();
        }

    }
}
