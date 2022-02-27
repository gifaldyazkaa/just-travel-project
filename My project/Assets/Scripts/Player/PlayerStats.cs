using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerStats : MonoBehaviour
{
    [Header("Hitpoint")]
    public float maxHp = 100;
    public float currentHp;
    public float medHP;
    public float lowHp;
    public float veryLowHp;

    [Header("Mana")]
    public float maxMana = 200;
    public float currentMana;

    [Header("Combat")]
    public float currentAtt;
    public float currentDeff;

    [Header("Level")]
    public int maxLevel = 12;
    public int currentLevel = 1;
    [Space]
    public float maxExp = 60;
    public float currentExp;
    [Space]
    public float hpLevelUp = 1.5f;
    public float manaLevelUp = 1.8f;
    public float attLevelUp = 1.4f;
    public float deffLevelUp = 1.3f;
    public float expLevelUp = 2;

    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        currentMana = maxMana;
    }

    // Update is called once per frame
    void Update()
    {
        #region Hitpoint Update
        //HP Logic


        //HP Conditions
        medHP = maxHp / 1.25f;
        lowHp = maxHp / 2;
        veryLowHp = maxHp / 3;
        #endregion

        #region Level Update
        if(currentExp >= maxExp && currentLevel <= maxLevel - 1)
        {
            currentLevel += 1;
            maxExp *= expLevelUp;

            maxHp *= hpLevelUp;
            currentHp = maxHp;

            maxMana *= manaLevelUp;
            currentMana = maxMana;

            currentAtt *= attLevelUp;
            currentDeff *= deffLevelUp;
        }

        else if (currentLevel >= maxLevel)
        {
            currentExp = maxExp;
        }
        #endregion

        #region Test
        /*if (Input.GetKeyDown(KeyCode.N))
        {
            SaveSystem.SavePlayer(this);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            PlayerData data = SaveSystem.LoadPlayer();

            maxHp = data.maxHp;
            currentHp = data.hp;

            maxMana = data.maxMana;
            currentMana = data.mana;

            currentAtt = data.att;
            currentDeff = data.deff;

            currentLevel = data.level;
            maxExp = data.maxExp;
            currentExp = data.exp;

            Vector2 pos;
            pos.x = data.pos[0];
            pos.y = data.pos[1];

            transform.position = pos;
        }*/
        #endregion
    }
}
