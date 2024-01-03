using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceInfoUI : MonoBehaviour
{
    public TextMeshProUGUI woodCount;
    public TextMeshProUGUI ironCount;
    public TextMeshProUGUI stoneCount;

    // Update is called once per frame
    void Update()
    {
        woodCount.text = ResourceManager.Instance.woodCount.ToString();
        ironCount.text = ResourceManager.Instance.ironCount.ToString();
        stoneCount.text = ResourceManager.Instance.stoneCount.ToString();
    }
}
