using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int currentLevel;
    public GameObject[] buildings;
    public static LevelManager Instance;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI ExperienceText;
    int requiredExperience;
    public int currentExperience;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Update()
    {
        CheckCurrentLevel();
        switch (currentLevel)
        {
            case 1:
                buildings[0].SetActive(true);
                buildings[1].SetActive(false);
                buildings[2].SetActive(false);
                titleText.text = "COMMANDER";
                ExperienceText.text = currentExperience + "/" + requiredExperience;
                break;
            case 2:
                buildings[0].SetActive(false);
                buildings[1].SetActive(true);
                buildings[2].SetActive(false);
                titleText.text = "CHIEF";
                requiredExperience = 1000;
                ExperienceText.text = currentExperience + "/" + requiredExperience;
                break;
            case 3:
                buildings[0].SetActive(false);
                buildings[1].SetActive(false);
                buildings[2].SetActive(true);
                titleText.text = "KING";
                requiredExperience = 10000;
                ExperienceText.text = currentExperience + "/" + requiredExperience;
                break;
        }

        levelText.text = "LEVEL " + currentLevel;

    }

    void CheckCurrentLevel()
    {
        if(currentExperience < 100)
        {
            currentLevel = 1;
        }
        else if (currentExperience >= 100 && currentExperience <1000)
        {
            currentLevel = 2;
        }
        else if (currentExperience > 1000)
        {
            currentLevel = 3;
        }
    }

    private void Start()
    {
        currentLevel = 1;
        requiredExperience = 100;
    }
    public int GetLevel()
    {
        return currentLevel;
    }
}
