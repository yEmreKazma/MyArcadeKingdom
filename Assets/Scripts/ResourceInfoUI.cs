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
        resourceText.text = "Taþ sayýsý : " + ResourceManager.Instance.stoneCount +
            "Odun sayýsý : " + ResourceManager.Instance.woodCount +
            "Demir sayýsý : " + ResourceManager.Instance.ironCount;
    }
}
