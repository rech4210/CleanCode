using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : Enemy, UsuableEnemySkill
{
    string name;
    int health;
    int damage;
    public Demon(string name, int health, int damage) : base(name, health, damage)
    {
        this.name = name;
        this.health = health;
        this.damage = damage;
        Debug.Log(ToString());

    }

    public override void Talk()
    {
        Debug.Log(name + ": �Ǹ����� �ε��ϸ�");

    }

    public void UseEnemySkill()
    {
        Debug.Log(name + "�� �Ǹ� ����!");
    }

}
