using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy, UsuableEnemySkill
{
    string name;
    int health;
    int damage;
    public Orc(string name, int health, int damage):base(name,health,damage)
    {
        this.name = name;
        this.health = health;
        this.damage = damage;
        Debug.Log(ToString());

    }

    public override void Talk()
    {
        Debug.Log(name + ": ³ÊÈñ¸¦ Â¢¹¶°³ÁÖ¸¶.");
    }

    public void UseEnemySkill()
    {
        Debug.Log(name + "ÀÇ ³»·ÁÂï±â!");
    }
}
