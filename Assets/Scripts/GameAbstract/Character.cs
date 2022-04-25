using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    string name;
    int health;
    int damage;
    public Character(string name, int health, int damage)
    {
        this.name = name;
        this.health = health;
        this.damage = damage;
    }


    public override string ToString()
    {
        return ("이름:  " + name + "  체력:  " + health + "  공격력 : " + damage);
    }
    public abstract void Move();
    public abstract void Talk();
}
