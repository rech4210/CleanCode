using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownCasting
{
    public string text;
    public int number;

    public UpDownCasting()
    {
        text = "업다운 캐스팅입니다. ";
        number = 5;
    }


    public int Calc(int number)
    {
        return number * 17;
    }
    public string Sendtext(string text)
    {
        return text + " 메소드";
    }

}
