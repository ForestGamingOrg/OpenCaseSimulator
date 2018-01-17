using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInterface : MonoBehaviour {

    [Header("Menu Settings")]
    public GameObject activityPanel;
    public GameObject menuPanel;
    public GameObject settingPanel;
    public GameObject gameList;

    [Header("GameChests")]
    public GameObject csgoPanel;
    public GameObject pubgPanel;
    public GameObject dota2Panel;
    public GameObject crPanel;
    public GameObject chestsPanel;

    [Header("GameCase")]
    public GameObject gamePanel;
    public GameObject scrollPanel;



    public void GamesButton()
    {
        gamePanel.SetActive(false);
        activityPanel.SetActive(true);
        menuPanel.SetActive(false);
        gameList.SetActive(true);
        chestsPanel.SetActive(false);
    }

    public void MenuButton()
    {
        gamePanel.SetActive(false);
        activityPanel.SetActive(true);
        gameList.SetActive(false);
        settingPanel.SetActive(false);
        menuPanel.SetActive(true);
        chestsPanel.SetActive(false);
    }

    public void SettingButton()
    {
        gamePanel.SetActive(false);
        activityPanel.SetActive(true);
        menuPanel.SetActive(false);
        gameList.SetActive(false);
        settingPanel.SetActive(true);
        chestsPanel.SetActive(false);
    }

    public void CaseButton()
    {
        chestsPanel.SetActive(false);
        activityPanel.SetActive(false);
        gamePanel.SetActive(true);
        
    }

    public void OpenButton()
    {
        chestsPanel.SetActive(false);
        activityPanel.SetActive(false);
        gamePanel.SetActive(true);
        scrollPanel.SetActive(true);
    }

    public void ChangeGameButton(int id)
    {
        switch (id)
        {
            case 0:
                
                chestsPanel.SetActive(true);
                csgoPanel.SetActive(true);
                pubgPanel.SetActive(!csgoPanel.activeSelf);
                dota2Panel.SetActive(!csgoPanel.activeSelf);
                crPanel.SetActive(!csgoPanel.activeSelf);
                activityPanel.SetActive(false);
                break;
            case 1:
                chestsPanel.SetActive(true);
                dota2Panel.SetActive(true);
                pubgPanel.SetActive(!dota2Panel.activeSelf);
                csgoPanel.SetActive(!dota2Panel.activeSelf);
                crPanel.SetActive(!dota2Panel.activeSelf);
                activityPanel.SetActive(false);
                break;
            case 2:
                chestsPanel.SetActive(true);
                pubgPanel.SetActive(true);
                dota2Panel.SetActive(true);
                dota2Panel.SetActive(!pubgPanel.activeSelf);
                csgoPanel.SetActive(!pubgPanel.activeSelf);
                crPanel.SetActive(!pubgPanel.activeSelf);
                activityPanel.SetActive(false);
                break;
            case 3:
                chestsPanel.SetActive(true);
                crPanel.SetActive(true);
                dota2Panel.SetActive(true);
                dota2Panel.SetActive(!crPanel.activeSelf);
                csgoPanel.SetActive(!crPanel.activeSelf);
                pubgPanel.SetActive(!crPanel.activeSelf);
                activityPanel.SetActive(false);
                break;
            default:
                break;
        }
    }
}
