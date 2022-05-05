using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramda : MonoBehaviour
{
    delegate void Find(string name);
    delegate string Kill(string name, int count);

    string man = "��������";
    string woman = "�ʹ��";

    int health;

    Find find;
    Kill kill;

    private void Start()
    {
        find += FindWoman;
        Debug.Log(find);

        find += (string findman) => { Debug.Log("Find" + findman); Debug.Log("�����" + findman); };// ���ٽ��� �̿��� ��������Ʈ �Ｎ ���� �Ű����� ���� ����


        kill += (string killman, int count) => (killman + "��" + count + "ȸ óġ"); Debug.Log("�Ϸ�"); // �Ű������� �ΰ� �̻��� ��쿡 ����ϴ� ���ٽ�

    }

    public void FindWoman(string woman)
    {
        Debug.Log("Findwoman " + this.woman);
    }

    public void RestoreHealth(int health) // ���� �޼ҵ�
    {
        this.health += health;
    }
    public void RestoreHealth_ramda(int health) => this.health += health; //���� �޼ҵ�

    public int hp // ���� ������Ƽ
    {
        get { return health; }
        set { health = 10; }
    }

    public int hp_ramda { get => health; set => health = 10;} // ���� ������Ƽ


    private void Update()
    {
        find(man);

        Debug.Log(kill(man, 15));

        Debug.Log(kill(woman, killcount));
    }
}
