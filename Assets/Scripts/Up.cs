using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : UpDownCasting
{

    public Up()
    {
        number = 55;
        text = "Big";
    }

    public void Initialize()
    {
        UpSendtext(text);
        Calc(number);

        Debug.Log(UpSendtext(text));
        Debug.Log(Calc(number));
    }

    public string UpSendtext(string text)
    {
        return text + " in Up";
    }
}
