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
        Debug.Log(a + " ��ĳ������ ������ �ѹ�"); // 5 ����
    }


    

    private void Upcasting()
    {
        upDownCasting = down; // ��ĳ���� ����Ŭ������ ����Ŭ���� �ν��Ͻ��� �����Ͽ� ����

        //upDownCasting.DownSendtext("a"); // ��ĳ���� �� �ٿ� ��ü�� �޼ҵ� ��� �Ұ�
        ((Down)upDownCasting).DownSendtext("a"); // �ʿ�� �ٿ� ĳ������ �̿��� �޼ҵ� ȣ�� ����


        int b = upDownCasting.number;
        
        Debug.Log(b + ": ��ĳ���� �ѹ�" + upDownCasting.Calc(b) + ": ��ĳ���� �� ���� ��   " + upDownCasting.Sendtext(upDownCasting.text) + " " ); 
        // 1 , 17, small ���� (�� ĳ���� �� ������ �ٿ� ĳ������ ������� �̿�)

        
    }

    private void Downcasting()
    {
        down = (Down)upDownCasting; // �ٿ� ĳ���� ���� ��ü���� ����
        down.DownSendtext("a"); // �ʿ�� �ٿ� ĳ������ �̿��� �޼ҵ� ȣ�� ����

        int c = down.number; // �ٿ� c

        Debug.Log(c + ": �ٿ�ĳ���� �ѹ�" + down.Calc(c) + ": �ٿ�ĳ���� �� ���� ��   " + down.DownSendtext(down.text)); 
        // 1 , 17, small ����

    }
    private void Updowncasting()
    {
        upDownCasting = new UpDownCasting();

        int a = upDownCasting.number;
        
        Debug.Log(a + ": ���ٿ� ��ü �ѹ�" + upDownCasting.Calc(a) + ": ���ٿ� ��ü ���� ��   " + upDownCasting.Sendtext(upDownCasting.text) + " ");
        // 1, 17, ���ٿ� ĳ�����Դϴ� ����
    }

    private void Initialize()
    {
        down = new Down();
        up = new Up();
        upDownCasting = new UpDownCasting(); // ��ü �ϰ� ����

        down.Initialize();
        up.Initialize();
    }
}