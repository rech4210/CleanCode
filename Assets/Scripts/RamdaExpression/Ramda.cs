using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramda : MonoBehaviour
{
    delegate void Find(string name);
    delegate string Kill(string name, int count);

    int killcount = 5;

    string man = "가지구이";
    string woman = "꽈배기";

    int health;

    Find find;
    Kill kill;

    private void Start()
    {
        find += FindWoman;
        Debug.Log(find);

        find += (string findman) => { Debug.Log("Find" + findman); Debug.Log("찾기" + findman); };// 델리게이트 부착 람다식표현


        kill += (string killman, int count) => (killman + "가" + count + "잡았습니다"); Debug.Log("만세");

    }

    public void FindWoman(string woman)
    {
        Debug.Log("Findwoman " + this.woman);
    }

    public void RestoreHealth(int health) // 기존 메소드
    {
        this.health += health;
    }

    public void RestoreHealth_ramda(int health) => this.health = health; // 람다 메소드

    public int hp // 기존 프로퍼티
    {
        get { return health; }
        set { health += 10; }
    }

    public int hp_ramda { get => health; set => health +=+10;} // 람다 프로퍼티


    private void Update()
    {
        //find(man);

        //Debug.Log(kill(man, 15));

        //Debug.Log(kill(woman, killcount));
    }
}
