using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeligateAndAction : MonoBehaviour
{
    delegate float DamageCalc(float a, float b);
    delegate void ViewDamage();
    public delegate void UseItemDele(DeligateAndAction target);

    DamageCalc damageCalc; // �Լ����� ���� �� �ִ� ������ ��������Ʈ
    ViewDamage viewDamage;
    public UseItemDele useItemDele; // item �׸񿡼� �����Ͽ� �޼ҵ���� �߰���ų ����

    public string mydeligateName = "�ʹ��";

    private void Start()
    {
        damageCalc = Sum;     // => ��ȯ���� void�� �ƴ� �޼ҵ带 ��Ƽĳ���� �ϸ� �Ѱ����� ����ȴ�!!
        Debug.Log(damageCalc(5, 4));

        damageCalc += Substract;
        Debug.Log(damageCalc(5,4));

        viewDamage = view;
        viewDamage += damagecount;

        viewDamage(); // ��ȯ���� void �� ��� ��Ƽĳ������ �̿��� �ѹ��� �޼ҵ�� �̿� ����.



        useItemDele(this); // ��������Ʈ�� �̿��� �޼ҵ� ��� DeligateAndAction���� ��������Ʈ �Լ��� ȣ���ϰ� Delitem���� �޼ҵ带 �߰�������
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            useItem();

        }

    }

    private void useItem()
    {
        useItemDele(this);
    }

    public float Sum(float a, float b)
    {
        return a + b;
    }

    public float Substract(float a, float b)
    {
        return a - b;
    }

    public void view()
    {
        Debug.Log("������ ���� ����");

    }

    public void damagecount()
    {
        Debug.Log("������ ī��Ʈ ����");

    }

}
