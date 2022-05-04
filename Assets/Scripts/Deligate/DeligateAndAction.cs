using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeligateAndAction : MonoBehaviour
{
    delegate float DamageCalc(float a, float b);
    delegate void ViewDamage();
    public delegate void UseItemDele(DeligateAndAction target);

    DamageCalc damageCalc; // 함수들을 담을 수 있는 포인터 델리게이트
    ViewDamage viewDamage;
    public UseItemDele useItemDele; // item 항목에서 참조하여 메소드들을 추가시킬 예정

    public string mydeligateName = "꽈배기";

    private void Start()
    {
        damageCalc = Sum;     // => 반환형이 void가 아닌 메소드를 멀티캐스팅 하면 한가지만 적용된다!!
        Debug.Log(damageCalc(5, 4));

        damageCalc += Substract;
        Debug.Log(damageCalc(5,4));

        viewDamage = view;
        viewDamage += damagecount;

        viewDamage(); // 반환형이 void 일 경우 멀티캐스팅을 이용하 한번에 메소드들 이용 가능.



        useItemDele(this); // 델리게이트를 이용한 메소드 사용 DeligateAndAction에서 델리게이트 함수를 호출하고 Delitem에서 메소드를 추가시켜줌
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
        Debug.Log("데미지 보기 실행");

    }

    public void damagecount()
    {
        Debug.Log("데미지 카운트 실행");

    }

}
