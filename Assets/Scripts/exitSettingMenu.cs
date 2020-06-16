using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitSettingMenu : MonoBehaviour {
    public GameObject gameCanvas, settingMenu;
	// Use this for initialization
    public void doClick()
    {
        gameCanvas.SetActive(true);
        settingMenu.SetActive(false);
    }
	
}
