using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float maxHp;
    public float hp;

    public float maxMana;
    public float mana;

    public float att;
    public float deff;

    public int level;
    public float maxExp;
    public float exp;

    public float[] pos;

    public PlayerData (PlayerStats playerStats)
    {
        maxHp = playerStats.maxHp;
        hp = playerStats.currentHp;

        maxMana = playerStats.maxMana;
        mana = playerStats.currentMana;

        att = playerStats.currentAtt;
        deff = playerStats.currentDeff;

        level = playerStats.currentLevel;
        maxExp = playerStats.maxExp;
        exp = playerStats.currentExp;

        pos = new float[2];
        pos[0] = playerStats.transform.position.x;
        pos[1] = playerStats.transform.position.y;
    }
}
