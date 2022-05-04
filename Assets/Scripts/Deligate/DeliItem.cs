using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliItem : MonoBehaviour
{


    private void Awake()
    {
        DeligateAndAction player = FindObjectOfType<DeligateAndAction>();
        player.useItemDele =  HealthItem;
        player.useItemDele += ArmorItem;
        player.useItemDele += AttackItem;
    }


    public void HealthItem(DeligateAndAction target)
    {
        Debug.Log(target.mydeligateName + " �ｺ ������ ���");
    }
    public void ArmorItem(DeligateAndAction target)
    {
        Debug.Log(target.mydeligateName + " ��� ������ ���");
    }
    public void AttackItem(DeligateAndAction target)
    {
        Debug.Log(target.mydeligateName + " ���� ������ ���");
    }
}
