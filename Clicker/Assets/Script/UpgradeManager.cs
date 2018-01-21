using UnityEngine;
using System.Collections;

public class UpgradeManager : MonoBehaviour {

	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public float cost;
	public int count = 0;
	public int clickPower;
	public string itemName;
    private float baseCost;

    private void Start()
    {
        {
            baseCost = cost;
        }
    }

    void Update() {
		itemInfo.text = itemName + "\nPower Click: +" + clickPower + "\nCost: " + cost ;
	}

	public void PurshasedUpgrade(){
		if (click.gold >= cost){
			click.gold -= cost;
			count += 1;
			click.goldperclick +=clickPower;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
		}
	}
}

 