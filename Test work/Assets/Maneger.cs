using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Maneger : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject PlayMenuPanel;
    public GameObject SettingsMenuPanel;

    //�������� �������� ���� 
    public void Play()
    {
        MainMenuPanel.SetActive(false);
        PlayMenuPanel.SetActive(true);
    }

    //�������� �������� ���� 
    public void PlayExit()
    {
        MainMenuPanel.SetActive(true);
        PlayMenuPanel.SetActive(false);
    }

    //�������� ���� ��������
    public void Settings()
    {
        MainMenuPanel.SetActive(false);
        SettingsMenuPanel.SetActive(true);
    }

    //�������� ���� ��������
    public void ExitSettings()
    {
        MainMenuPanel.SetActive(true);
        SettingsMenuPanel.SetActive(false);
    }
}
