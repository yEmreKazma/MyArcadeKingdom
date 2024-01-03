using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missions : MonoBehaviour
{

    string missionName;
    bool isCompleted;


    public Missions(string name)
    {
        missionName = name;
        isCompleted = false;
    }

    void CompleteMission()
    {
        isCompleted = true;
        Debug.Log("Mission : " + missionName + " Completed.");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
