using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nickname : MonoBehaviour {

    public static Nickname instance;
    public string nickname;
    public UnityEngine.UI.InputField tmpInput ;
    public Canvas CanMain;
    public Canvas CanMarket;
    public Canvas CanDragon;
    public Canvas CanBattle;
    public Canvas CanNickName;

    void Start ()
    {
        Load();
        if (nickname == "" )
        {
            CanMain.enabled = false;
            CanMarket.enabled = false;
            CanBattle.enabled = false;
            CanDragon.enabled = false;
        }
        else
        {
            CanMain.enabled = true;
            CanNickName.enabled = false;
        }
    }
    public void nextScene()
    {
        nickname = tmpInput.text;
        CanMain.enabled = true;
        CanNickName.enabled = false;
    }
	
	public void Save ()
    {
        PlayerPrefs.SetString("Nickname", nickname);
    }

    public void Load()
    {
        nickname = PlayerPrefs.GetString("Nickname");
    }

    public string ReturnNickame()
    {
        return nickname;
    }
}
