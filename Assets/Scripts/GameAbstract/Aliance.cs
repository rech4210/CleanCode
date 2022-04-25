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
        Debug.Log(name + "가 1m 만큼 이동!"); ;
    }

    public override void Talk()
    {
        Debug.Log(name + "가 말했다!"); ;
    }
}
