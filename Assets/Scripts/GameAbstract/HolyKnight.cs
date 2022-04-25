using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyKnight : Aliance, UseableSkill
{
    public string name;
    int health;
    int damage;
    public HolyKnight(string name, int health, int damage) : base(name, health, damage)
    {
        this.name = name;
        this.health = health;
        this.damage = damage;
        Debug.Log(ToString());
    }



    public void UseSkill()
    {
        Debug.Log("신성한 보호를 사용!");
    }
}
