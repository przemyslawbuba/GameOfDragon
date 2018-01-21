using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Click : MonoBehaviour {

    
    public static Click instance;
    public UnityEngine.UI.Text gpc;
	public UnityEngine.UI.Text goldDisplay;
    public UnityEngine.UI.Text goldDisplay2;
    public UnityEngine.UI.Text goldDisplay3;
    public float gold = 0.00f;
	public float goldperclick = 1.00f;



    private void Start()
    {
        if (PlayerPrefs.GetString("test") == "test")
        {
            Load();
        }
        
    }

    void Update(){
        if ((gold > 1000) && (gold < 1000000)) 
        {
            goldDisplay.text = "Dragon Scale:" + ((gold / 1000).ToString("#.##")) + "kB";
            goldDisplay2.text = "Dragon Scale:" + ((gold / 1000).ToString("#.##")) + "kB";
            goldDisplay3.text = "Dragon Scale:" + ((gold / 1000).ToString("#.##")) + "kB";
        }
        else if ((gold > 1000000) && ( gold < 1000000000))
        {
            goldDisplay.text = "Dragon Scale:" + ((gold / 1000000).ToString("#.#")) + "MB";
            goldDisplay2.text = "Dragon Scale:" + ((gold / 1000000).ToString("#.#")) + "MB";
            goldDisplay3.text = "Dragon Scale:" + ((gold / 1000000).ToString("#.##")) + "kB";
        }
        else if ((gold > 1000000000) && (gold < 1000000000000))
        {
            goldDisplay.text = "Dragon Scale:" + ((gold / 100000000).ToString("#.#")) + "TB";
            goldDisplay2.text = "Dragon Scale:" + ((gold / 100000000).ToString("#.#")) + "TB";
            goldDisplay3.text = "Dragon Scale:" + ((gold / 100000000).ToString("#.##")) + "kB";
        }
        else
        {
            goldDisplay.text = "Dragon Scale:" + gold;
            goldDisplay2.text = "Dragon Scale:" + gold;
            goldDisplay3.text = "Dragon Scale:" + gold;
        }

        if ((goldperclick > 1000) && (goldperclick < 1000000))
        {
            gpc.text = "Gold Per Click: " + ((goldperclick / 1000).ToString("#.##")) + "kB";
        }
        else if ((goldperclick > 1000000) && (goldperclick < 1000000000))
        {
            gpc.text = "Gold Per Click: " + ((goldperclick / 1000000).ToString("#.#")) + "MB";
        }
        else
        {
            gpc.text = "Gold Per Click: " + goldperclick;
        }
        
    }

	public void Clicked()
    {
		gold += goldperclick;
	}

    public void Save()
    {
        PlayerPrefs.SetFloat("Gold", gold);
        PlayerPrefs.SetFloat("GoldPerClick", goldperclick);
        PlayerPrefs.SetString("test", "test");
    }

    public void Load()
    {
        gold = PlayerPrefs.GetFloat("Gold");
        goldperclick = PlayerPrefs.GetFloat("GoldPerClick");
    }

    

}
