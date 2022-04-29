using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    Down down;
    Up up;
    UpDownCasting upDownCasting;



    // Start is called before the first frame update
    void Start()
    {
        Initialize();
        int a = upDownCasting.number;

        Upcasting();
        Downcasting();
        Updowncasting();
        Debug.Log(a + " 업캐스팅의 생성자 넘버"); // 5 예상

        Soceriss baegi = new Soceriss("덜꼬인꽈배기", 100, 20);
        baegi.Move();
        baegi.Talk();
        baegi.UseSkill();

        HolyKnight gaji = new HolyKnight("맛있는가지구이", 200, 10);
        gaji.Move();
        gaji.Talk();
        gaji.UseSkill();

        LaHart laHart = new LaHart("라하르트", 250, 10);
        laHart.Move();
        laHart.Talk();
        laHart.Script();

        Orc grak = new Orc("그라카르", 500, 25);
        grak.Talk();
        grak.Move();
        grak.UseEnemySkill();

        Demon avrelshaja = new Demon("아브렐슈드", 1000, 5);
        avrelshaja.Talk();
        avrelshaja.Move();
        avrelshaja.UseEnemySkill();

        UseableSkill useableSkill;


    }




    private void Upcasting()
    {
        upDownCasting = down; // 업캐스팅 서브클래스를 슈퍼클래스 인스턴스로 통합하여 관리

        //upDownCasting.DownSendtext("a"); // 업캐스팅 후 다운 객체의 메소드 사용 불가
        ((Down)upDownCasting).DownSendtext("a"); // 필요시 다운 캐스팅을 이용해 메소드 호출 가능


        int b = upDownCasting.number;
        
        Debug.Log(b + ": 업캐스팅 넘버" + upDownCasting.Calc(b) + ": 업캐스팅 후 연산 값   " + upDownCasting.Sendtext(upDownCasting.text) + " " ); 
        // 1 , 17, small 예상 (업 캐스팅 후 여전히 다운 캐스팅의 멤버변수 이용)

        
    }

    private void Downcasting()
    {
        down = (Down)upDownCasting; // 다운 캐스팅 원래 객체로의 복원
        down.DownSendtext("a"); // 필요시 다운 캐스팅을 이용해 메소드 호출 가능

        int c = down.number; // 다운 c

        Debug.Log(c + ": 다운캐스팅 넘버" + down.Calc(c) + ": 다운캐스팅 후 연산 값   " + down.DownSendtext(down.text)); 
        // 1 , 17, small 예상

    }
    private void Updowncasting()
    {
        upDownCasting = new UpDownCasting();

        int a = upDownCasting.number;
        
        Debug.Log(a + ": 업다운 객체 넘버" + upDownCasting.Calc(a) + ": 업다운 객체 연산 값   " + upDownCasting.Sendtext(upDownCasting.text) + " ");
        // 1, 17, 업다운 캐스팅입니다 예상
    }

    private void Initialize()
    {
        down = new Down();
        up = new Up();
        upDownCasting = new UpDownCasting(); // 객체 일괄 생성

        down.Initialize();
        up.Initialize();
    }

    
    
}
