using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class Enemy : MonoBehaviour
{

    //Düþmanýn hedefe gitme kodu denemesi. (DOMove)
    public Transform target;
    public GameObject enemies;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            enemies.transform.DOMove(new Vector3(0, 0.939999998f, 0.980000019f), 1);
        }
    }
}
