using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    private void Update()
    {
        if (transform.childCount ==0)
        {
            Debug.Log("No more enemies");
        }
    }

}
