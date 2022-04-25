using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soceriss : Aliance ,UseableSkill
{
    string name;
    int health;
    int damage;
    public Soceriss(string name, int health, int damage) : base(name, health, damage)
    {
        this.name = name;
        this.health = health;
        this.damage = damage;
        Debug.Log(ToString());
    }

    public void UseSkill()
    {
        Debug.Log("혹한의 부름을 사용!");
    }

}
