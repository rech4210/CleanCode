using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GenericClass : MonoBehaviour
{
    public class GenericT<T, U>
    {
        public Queue<T> GenericQueue;
        public List<T> GenericList;
        public Stack<T> GenericStack;
        public Dictionary<T,U> GenericDic;


        public T value;
        public U key;


        public GenericT(T value, U key)
        {
            this.value = value;
            this.key = key;
        }

        public void GenericMethod<T>(T value) => Debug.Log(value + "���ʸ� �޼ҵ�");

        public void print(GenericT<T,U> generic)
        {
            Debug.Log("���� " + generic.value +  " ���ʸ� Ŭ�����Դϴ�. : " + generic.key);

        }


    }

    void Start()
    {
        GenericT<int, string> genericT = new GenericT<int, string>(10, "HI");
        genericT.print(genericT);

        GenericT<float, Vector3> genericT1 = new GenericT<float, Vector3>(10.1f, Vector3.forward);
        genericT1.print(genericT1);

        Queue<float> ts = new Queue<float>(); // ���ʸ� ť ���� float ����
        genericT1.GenericQueue = ts;
        ts = genericT1.GenericQueue; // ���ʸ� Ŭ���� �ν��Ͻ��� ���ʸ� ť ts�� �Ҵ�
        ts.Enqueue(genericT1.value);
        genericT.GenericMethod<int>(30);
        genericT.GenericMethod<string>("30");
        genericT.GenericMethod<float>(30);

    }
}

