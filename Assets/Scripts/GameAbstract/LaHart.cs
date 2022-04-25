using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaHart : Aliance, TalkableNPC
{
    string name;
    int health;
    int damage;
    public LaHart(string name, int health, int damage) : base(name, health, damage)
    {
        this.name = name;
        this.health = health;
        this.damage = damage;
        Debug.Log(ToString());
    }

    public void Script()
    {
        TalkNPC_1();
        TalkNPC_2();
        TalkNPC_3();
        TalkNPC_4();

    }

    public void TalkNPC_1()
    {
        Debug.Log("�����ϰ�!");
    }
    public void TalkNPC_2()
    {
        Debug.Log("��������!");

    }
    public void TalkNPC_3()
    {
        Debug.Log("������ ���������� �ֱ�.");

    }
    public void TalkNPC_4()
    {
        Debug.Log("���׹�Ʈ�� ��Ȱ�Ϸ� �ϰ��ֱ�.");

    }
}
