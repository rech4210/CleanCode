using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public static class ExtensionMethod
{
    /** �� �޼ҵ�� x, y, z�� ���� �������� ������ **/
    public static Vector3 RandomPosition(this Transform transform, Vector3 vec)
    {
        float ranNumber = Random.Range(1,3);
        return transform.position =
            vec + new Vector3(ranNumber, ranNumber, ranNumber);
    }
}
