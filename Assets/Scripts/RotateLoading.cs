using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;

public class RotateLoading : MonoBehaviour
{
    int updateCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.DORotate(new Vector3(0, 0, 180), 4.05f).OnComplete(() => 
        {
            SceneManager.LoadScene("Level1");

        });


    }

    // Update is called once per frame
    void Update()
    {

    }
}
