using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsMenu : MonoBehaviour {
    public GameObject gameCanvas, settingMenu;
    public UnityEngine.UI.Text usernameDisplay;


    public void openSettingsMenu()
    {
        gameCanvas.SetActive(false);
        settingMenu.SetActive(true);
    }

    public void displayUsername()
    {
        usernameDisplay.text = "Username: " + dbManager.username;
    }

}
