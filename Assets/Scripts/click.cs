using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public UnityEngine.UI.Text spiritStoneDisplay;
    public int spiritStone = 0;
    public int spiritStonePerClick = 1;

    void Update()
    {
        spiritStoneDisplay.text = "Spirit Stones: " + spiritStone;
    }

    public void Clicked()
    {
        spiritStone += spiritStonePerClick;
    }


}
