using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject mainCamera; 
    public GameObject secondaryCamera;
    public static CameraManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void BattleScene()
    {
        DisableMainCamera();
        EnableBattleCamera();
    }
    public void BattleOver()
    {
        DisableBattleCamera();
        EnableMainCamera();
    }
    public void EnableMainCamera()
    {
        mainCamera.SetActive(true);
    }
    public void EnableBattleCamera()
    {
        secondaryCamera.SetActive(true);
    }
    public void DisableMainCamera()
    {
        mainCamera.SetActive(false);
    }
    public void DisableBattleCamera()
    {
        secondaryCamera.SetActive(false);
    }
}
