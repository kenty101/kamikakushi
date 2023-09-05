using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plas2 : MonoBehaviour
{

    Memo memo;
    Number number;

    void Update()
    {
        memo = GameObject.Find("Textmemo").GetComponent<Memo>();
        number = GameObject.Find("Numbers").GetComponent<Number>();

        if (number.DaysPoint == 5)
        {
            memo.g = 1;

        }
        if (number.DaysPoint == 4)
        {
            memo.i = 1;

        }
        if (number.DaysPoint == 3)
        {
            memo.k = 1;

        }
        if (number.DaysPoint == 2)
        {
            memo.n = 1;

        }
         if (number.DaysPoint == 1)
        {
            memo.o = 1;

        }
    }

}
