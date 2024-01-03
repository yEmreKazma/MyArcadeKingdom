using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class BridgeUpgrade : MonoBehaviour
{
    public GameObject bridge;
    int requiredAmount;
    public TextMeshPro requiredText;
    public GameObject fog;
    // Start is called before the first frame update
    void Start()
    {
        requiredAmount = 25;
    }

    // Update is called once per frame
    void Update()
    {
        requiredText.text = requiredAmount.ToString();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) 
        {
            if (requiredAmount > 0 && ResourceManager.Instance.woodCount>0)
            {
                ResourceManager.Instance.woodCount--;
                requiredAmount--;
            }
            else if (requiredAmount ==0)
            {
                fog.gameObject.transform.DOLocalMoveY(25f, 5f);
                bridge.gameObject.transform.DOLocalMoveY(0f, 5f);
            }

        }
    }
}
