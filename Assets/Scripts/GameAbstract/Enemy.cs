using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    string name;
    public Enemy(string name, int health, int damage):base(name, health, damage)
    {
        this.name = name;
    }

    public override void Move()
    {
        Debug.Log(name + "�� 1m �Ÿ����� ����!"); ;
    }

    public override void Talk()
    {
        Debug.Log(name + "��� ¢����!"); ;
    }
}
