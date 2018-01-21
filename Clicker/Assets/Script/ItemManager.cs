using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {


    public static ItemManager instance;
    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public int secValue;
    public int count;
    public string itemName;
    private float mainCost;

    void Start()
    {
        mainCost = cost;
    }

    private void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nGold: " + secValue + "/s";
    }

    public void PurchasedItem()
    {
        if (click.gold >= cost)
        {
            click.gold -= cost;
            count += 1;
            cost = Mathf.Round(mainCost * Mathf.Pow(1.20f, count));
        }
    }





}
