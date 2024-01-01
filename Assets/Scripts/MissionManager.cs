using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
    public List<string> missions = new List<string>();
    public TextMeshProUGUI missionText;
    public TextMeshProUGUI missionProgressText;
    string currentMission;
    public int iterator = 0;
    public GameObject questTab;

    public static MissionManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    void Start()
    {
        missions.Add("Collect 10 woods");
        missions.Add("Go to the Wall Master");
        missions.Add("Build a walls");
        missions.Add("Survive an attack");

        SetCurrentMission();
    }

    void SetCurrentMission()
    {
       currentMission = missions[iterator];
    }
    // Update is called once per frame
    void Update()
    {

        CheckCurrentMission();
        if (currentMission == missions[0])
        {
            missionProgressText.text = ResourceManager.Instance.woodCount + "/" + 10;
            if (ResourceManager.Instance.woodCount >= 10)
            {
                iterator++;
                currentMission = missions[iterator];
            }
        }
        else if(currentMission == missions[1])
        {
            missionProgressText.text = 0 + "/" + 1;
            currentMission = missions[iterator];
        }
        else if(currentMission == missions[2])
        {
            missionProgressText.text = 0 + "/" + 1;
            currentMission = missions[iterator];
        }
        else if (currentMission == missions[3])
        {
            missionProgressText.text = 0 + "/" + 1;
        }
        else
        {
            

            Debug.Log("Mission Completed");
        }


    }

    void CheckCurrentMission()
    {
        missionText.text = currentMission;  
    }
}
