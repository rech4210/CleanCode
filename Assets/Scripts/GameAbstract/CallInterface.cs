using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallInterface : MonoBehaviour,UseableSkill
{
    public void UseSkill()
    {
        Debug.Log("인터페이스 호출");
    }

}
