using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownCasting
{
    public string text;
    public int number;

    public UpDownCasting()
    {
        text = "���ٿ� ĳ�����Դϴ�. ";
        number = 5;
    }


    public int Calc(int number)
    {
        return number * 17;
    }
    public string Sendtext(string text)
    {
        return text + " �޼ҵ�";
    }

}
