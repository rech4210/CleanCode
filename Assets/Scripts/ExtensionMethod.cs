using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public static class ExtensionMethod
{
    /** 이 메소드는 x, y, z에 대해 랜덤값을 더해줌 **/
    public static Vector3 RandomPosition(this Transform transform, Vector3 vec)
    {
        float ranNumber = Random.Range(1,3);
        return transform.position =
            vec + new Vector3(ranNumber, ranNumber, ranNumber);
    }
}
