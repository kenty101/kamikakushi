using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plas : MonoBehaviour
{
    Memo memo;
    Number number;
    void Update()
    {
        memo = GameObject.Find("Textmemo").GetComponent<Memo>();
        number = GameObject.Find("Numbers").GetComponent<Number>();

        if(number.DaysPoint == 5)
        {
            memo.f = 1;

        }
         if (number.DaysPoint == 4)
        {
            memo.h = 1;

        }
        if (number.DaysPoint == 3)
        {
            memo.j = 1;

        }
         if (number.DaysPoint == 2)
        {
            memo.l = 1;

        }
        if (number.DaysPoint == 1)
        {
            memo.m = 1;

        }

    }
}
