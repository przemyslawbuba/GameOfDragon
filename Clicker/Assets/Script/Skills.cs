using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Skills : MonoBehaviour
{
    public static Skills instance;
    public int mainPower;
    public int strength ;
    public int stamina ;
    public int critical ;
    public int speed ;
    public UnityEngine.UI.Text strengthDisplay;
    public UnityEngine.UI.Text staminaDisplay;
    public UnityEngine.UI.Text criticalDisplay;
    public UnityEngine.UI.Text speedDisplay;
    public UnityEngine.UI.Text displaySkills;
    public Text sliderValue;
    public Slider slider;

    public Click click;

    public float skillPoints = 66;


    public void Start()
    {
        Load();
    }

    public void Update()
    {
        displaySkills.text = "Skill Points: " +  skillPoints;
        
    }

    public void BuySkills()
    {
        float totalSKills = 1000000*slider.value;
        if (click.gold >= totalSKills)
        {
            click.gold -= totalSKills;
            skillPoints += slider.value;
        }
    }

    public void textUpdate()
    {
        sliderValue.text = slider.value.ToString();
    }

    public void UpgradeStrength()
    {
        if(skillPoints > 0)
        {
            skillPoints -= 1;
            strength++;
            strengthDisplay.text = "" + strength;
        }

    }

    public void UpgradeStamina()
    {
        if (skillPoints > 0)
        {
            skillPoints -= 1;
            stamina++;
            staminaDisplay.text = "" + stamina;
        }

    }

    public void UpgradeCritical()
    {
        if (skillPoints > 0)
        {
            skillPoints -= 1;
            critical++;
            criticalDisplay.text = "" + critical;
        }

    }

    public void UpgradeSpeed()
    {
        if (skillPoints > 0)
        {
            skillPoints -= 1;
            speed++;
            speedDisplay.text = "" + speed;
        }

    }

    public void Save()
    {
        PlayerPrefs.SetInt("Strength", strength);
        PlayerPrefs.SetInt("Stamina", stamina);
        PlayerPrefs.SetInt("Critical", critical);
        PlayerPrefs.SetInt("Speed", speed);
        PlayerPrefs.SetFloat("SkillPoints", skillPoints);

        PlayerPrefs.Save();
    }

    public void Load()
    {
        strength = PlayerPrefs.GetInt("Strength");
        stamina = PlayerPrefs.GetInt("Stamina");
        critical = PlayerPrefs.GetInt("Critical");
        speed = PlayerPrefs.GetInt("Speed");
        skillPoints = PlayerPrefs.GetFloat("SkillPoints");

        strengthDisplay.text = "" + strength;
        staminaDisplay.text = "" + stamina;
        criticalDisplay.text = "" + critical;
        speedDisplay.text = "" + speed;
        displaySkills.text = "" + skillPoints;
    }
}