using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour {
    public GameObject settingMenu, cultivateMenu;
	// Use this for initialization
	void Start () {
        settingMenu.SetActive(false);
        cultivateMenu.SetActive(false);
	}
	
}
