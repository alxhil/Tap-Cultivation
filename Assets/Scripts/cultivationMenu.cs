using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cultivationMenu : MonoBehaviour {
    public GameObject screenRegion, cultivationmMenu;

    public void doClick()
    {
        screenRegion.SetActive(false);
        cultivationmMenu.SetActive(true);
    }
	

}
