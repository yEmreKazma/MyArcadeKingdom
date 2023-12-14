using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMaster : MonoBehaviour, INpc
{
    public string npcName => "WallMaster";

    int value;

    private void Start()
    {
        value = 0;
    }

    private void Update()
    {
        if(value > 500)
        {

        }
    }


}

