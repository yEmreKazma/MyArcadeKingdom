using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceInfoUI : MonoBehaviour
{
    public TextMeshProUGUI resourceText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        resourceText.text = "Ta� say�s� : " + ResourceManager.Instance._stoneCount;
    }
}
