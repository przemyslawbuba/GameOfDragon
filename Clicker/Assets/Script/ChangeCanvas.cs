using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCanvas : MonoBehaviour {
    public Canvas CanMain;
    public Canvas CanMarket;
    public Canvas CanDragon;
    public Canvas CanBattle;
    public Button BtnMain;
    public Button BtnMarket;


    void Start()
    {
        CanMain.enabled = false;
        CanMarket.enabled = false;
        CanBattle.enabled = false;
        CanDragon.enabled = false;  
    }

    public void GoMain()
    {
        CanMain.enabled = true;
        CanMarket.enabled = false;
        CanBattle.enabled = false;
        CanDragon.enabled = false;
    }

    public void GoMarket()
    {
        CanMain.enabled = false;
        CanMarket.enabled = true;
        CanBattle.enabled = false;
        CanDragon.enabled = false;
    }
    public void GoArmy()
    {
        CanMain.enabled = false;
        CanMarket.enabled = false;
        CanBattle.enabled = false;
        CanDragon.enabled = true;
    }
    public void GoBattle()
    {
        CanMain.enabled = false;
        CanMarket.enabled = false;
        CanBattle.enabled = true;
        CanDragon.enabled = false;
    }
}
