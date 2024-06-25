using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Maneger : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject PlayMenuPanel;
    public GameObject SettingsMenuPanel;

    //Открытие игрового меню 
    public void Play()
    {
        MainMenuPanel.SetActive(false);
        PlayMenuPanel.SetActive(true);
    }

    //Закрытие игрового меню 
    public void PlayExit()
    {
        MainMenuPanel.SetActive(true);
        PlayMenuPanel.SetActive(false);
    }

    //Открытие меню настроек
    public void Settings()
    {
        MainMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(true);
    }

    //Закрытие меню настроек
    public void ExitSettings()
    {
        MainMenuPanel.SetActive(true);
        SettingsMenuPanel.SetActive(false);
    }
}
