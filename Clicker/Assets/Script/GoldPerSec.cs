using UnityEngine;
using System.Collections;

public class GoldPerSec : MonoBehaviour {


    public static GoldPerSec instance;
    public UnityEngine.UI.Text gpsDisplay;
    public Click click;
    public ItemManager[] items;
    public float GPS;

    void Start()
    {
        StartCoroutine(AutoTick()); 
    }

    private void Update()
    {
        GPS = GetGoldPerSec();
        if ((GetGoldPerSec() > 1000) && (GetGoldPerSec() < 1000000))
        {
            gpsDisplay.text = "Gold Per Sec: " + ((GetGoldPerSec() / 1000).ToString("#.##")) + "kB";
        }
        else if ((GetGoldPerSec() > 1000000) && (GetGoldPerSec() < 1000000000))
        {
            gpsDisplay.text = "Gold Per Sec: " + ((GetGoldPerSec() / 1000000).ToString("#.#")) + "MB";
        }
        else
        {
            gpsDisplay.text = " Gold Per Sec: " + GetGoldPerSec();
        }
    }

    public float GetGoldPerSec()
    {
        float tick = 0.00f;
        foreach(ItemManager item in items)
        {
            tick += item.count *item.secValue;
        }
        return tick;
    }
    public void AutoGoldPerSec()
    {
        click.gold += GetGoldPerSec();
    }
    IEnumerator AutoTick()
    {
        while (true)
        {
            AutoGoldPerSec();
            yield return new WaitForSeconds(1);
        }
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("GPS", GPS);
    }

    public void Load()
    {
        gpsDisplay.text = "" + PlayerPrefs.GetFloat("GPS");
    }
}
