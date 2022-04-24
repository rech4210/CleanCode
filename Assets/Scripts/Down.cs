using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down : UpDownCasting
{
    public Down()
    {
        number = 1;
        text = "small";
    }

    public void Initialize()
    {
        DownSendtext(text);
        Calc(number);

        Debug.Log(DownSendtext(text));
        Debug.Log(Calc(number));

    }

    public string DownSendtext(string text)
    {
        return text + " in Down";
    }
}
