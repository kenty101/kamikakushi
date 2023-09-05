using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plas1 : MonoBehaviour
{
    Memory memory;
    Count count;
    ChoiceMove1 choicemove1;

    void Update()
    {
        memory = GameObject.Find("Textmemo").GetComponent<Memory>();
        count = GameObject.Find("Numbers").GetComponent<Count>();
        choicemove1 = GameObject.Find("Canvas").GetComponent<ChoiceMove1>();

        if (choicemove1.M == 0)
        {
            memory.a30 = 1;

        }
         if (choicemove1.M == 1)
        {
            memory.a32 = 1;

        }
        if (choicemove1.M == 2)
        {
            memory.a34 = 1;

        }
         if (choicemove1.M == 3)
        {
            memory.a36 = 1;

        }
        if (choicemove1.M == 4)
        {
            memory.a38 = 1;

        }

        if (choicemove1.M == 5)
        {
            memory.a40 = 1;

        }
        if (choicemove1.M == 6)
        {
            memory.a42 = 1;

        }
        if (choicemove1.M == 7)
        {
            memory.a44 = 1;

        }
        if (choicemove1.M == 8)
        {
            memory.a46 = 1;

        }
        if (choicemove1.M == 9)
        {
            memory.a48 = 1;

        }
        if (choicemove1.M == 10)
        {
            memory.a50 = 1;

        }
        if (choicemove1.M == 11)
        {
            memory.a52 = 1;

        }
        if (choicemove1.M == 12)
        {
            memory.a54 = 1;

        }
        if (choicemove1.M == 13)
        {
            memory.a56 = 1;

        }
        if (choicemove1.M == 14)
        {
            memory.a58 = 1;

        }
        if (choicemove1.M == 15)
        {
            memory.a60 = 1;

        }
        if (choicemove1.M == 16)
        {
            memory.a62 = 1;

        }
        if (choicemove1.M == 17)
        {
            memory.a64 = 1;

        }
        if (choicemove1.M == 18)
        {
            memory.a66 = 1;

        }
        if (choicemove1.M == 19)
        {
            memory.a68 = 1;

        }
        if (choicemove1.M == 20)
        {
            memory.a70 = 1;

        }
        if (choicemove1.M == 21)
        {
            memory.a72 = 1;

        }
        if (choicemove1.M == 22)
        {
            memory.a74 = 1;

        }
        if (choicemove1.M == 23)
        {
            memory.a76 = 1;

        }
        if (choicemove1.M == 24)
        {
            memory.a78 = 1;

        }
        if (choicemove1.M == 25)
        {
            memory.a80 = 1;

        }
        if (choicemove1.M == 26)
        {
            memory.a82 = 1;

        }
        if (choicemove1.M == 27)
        {
            memory.a84 = 1;

        }
        if (choicemove1.M == 28)
        {
            memory.a86 = 1;

        }
        if (choicemove1.M == 29)
        {
            memory.a88 = 1;

        }
  
       
    }
}
