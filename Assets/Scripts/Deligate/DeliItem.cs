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
        Debug.Log(target.mydeligateName + " 헬스 아이템 사용");
    }
    public void ArmorItem(DeligateAndAction target)
    {
        Debug.Log(target.mydeligateName + " 방어 아이템 사용");
    }
    public void AttackItem(DeligateAndAction target)
    {
        Debug.Log(target.mydeligateName + " 공격 아이템 사용");
    }
}
