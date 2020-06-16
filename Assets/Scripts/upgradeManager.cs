using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgradeManager : MonoBehaviour {

    public click click;
    public UnityEngine.UI.Text iteminfo;
    public int cost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    private float _newCost;
	
	// Update is called once per frame
	void Update () {
        iteminfo.text = itemName + "\nCost:"+cost+"\nPower:"+clickPower;	
	}
    public void purchasedUpgrade()
    {
        if(click.spiritStone >= cost)
        {
            click.spiritStone -= cost;
            count += 1;
            click.spiritStonePerClick += clickPower;
            cost = (int)Mathf.Round(cost * 1.15f);
            _newCost = Mathf.Pow(cost, _newCost);
        }
    }

    public void purchasedCultivationRank()
    {

    }

    public void updateDB()
    {
        click.spiritStone = dbManager.spiritstone;
    }

}
