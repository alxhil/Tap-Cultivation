using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitCultivationMenu : MonoBehaviour {

    // Use this for initialization
    public GameObject screenRegion, cultivationMenu;

    public void exitClick()
    {
        screenRegion.SetActive(true);
        cultivationMenu.SetActive(false);
    }

}
