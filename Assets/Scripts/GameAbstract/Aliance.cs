using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Aliance : Character
{
    string name;
    public Aliance(string name, int health, int damage):base(name,health,damage)
    {
        this.name = name;
    }

    
    public override void Move()
    {
        Debug.Log(name + "�� 1m ��ŭ �̵�!"); ;
    }

    public override void Talk()
    {
        Debug.Log(name + "�� ���ߴ�!"); ;
    }
}
