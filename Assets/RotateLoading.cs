using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Text.RegularExpressions;

public class RotateLoading : MonoBehaviour
{
    int updateCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.DORotate(new Vector3(0, 0, 180), 2f, RotateMode.Fast).SetLoops(-1);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
