using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TestDictionary : MonoBehaviour
{
    int a, b, c, d;
    Dictionary<KeyCode, int> testDictionary = new Dictionary<KeyCode, int>
    {
        { KeyCode.A,1 },{ KeyCode.S,2 },{ KeyCode.D,3 }
    };

    delegate int mydelegate();


    Dictionary<KeyCode, Action> actiontestDictionary = new Dictionary<KeyCode, Action>(); // ¾×¼ÇÇü

    private void Start()
    {
        testDictionary.Add(KeyCode.F,4);
        actiontestDictionary.Add(KeyCode.R, D);
        actiontestDictionary.Add(KeyCode.T, A);
        actiontestDictionary.Add(KeyCode.Y, B);
        actiontestDictionary.Add(KeyCode.U, C);
    }

    private void A()
    {
        int a = 1;
        this.a = a;
    }
    private void B()
    {
        int b = 2;
        this.b = b;

    }
    private void C()
    {
        int c = 3;
        this.c = c;

    }
    private void D()
    {
        int d = 4;
        this.d = d;

    }
}
