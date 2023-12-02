using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
    public List<string> missions = new List<string>();
    public TextMeshProUGUI missionText; 
    void Start()
    {
        missions.Add("Missions 1: Collect 10 woods");
        missions.Add("Missions 2: Talk to the mason");
        missions.Add("Missions 3: Upgrade the walls");
        missions.Add("Missions 4: Survive an attack");
        missions.Add("Missions 5: Explore the forest");
        missions.Add("Missions 6: Craft 5 board ");
        missions.Add("Missions 7: Upgrade your soldiers");
        missions.Add("Missions 8: Upgrade your axe");

        SetCurrentMission();
    }

    void SetCurrentMission()
    {
       //
    }
    // Update is called once per frame
    void Update()
    {
        CheckMissions();
    }

    void CheckMissions()
    {
        string currentMission = missions[0];
        Debug.Log("Current Missions : " + currentMission);
    }
}
