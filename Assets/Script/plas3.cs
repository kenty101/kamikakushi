using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plas3 : MonoBehaviour
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
            memory.a31 = 1;

        }
         if (choicemove1.M == 1)
        {
            memory.a33 = 1;

        }
        if (choicemove1.M == 2)
        {
            memory.a35 = 1;

        }
         if (choicemove1.M == 3)
        {
            memory.a37 = 1;

        }
        if (choicemove1.M == 4)
        {
            memory.a39 = 1;

        }

        if (choicemove1.M == 5)
        {
            memory.a41 = 1;

        }
        if (choicemove1.M == 6)
        {
            memory.a43 = 1;

        }
        if (choicemove1.M == 7)
        {
            memory.a45 = 1;

        }
        if (choicemove1.M == 8)
        {
            memory.a47 = 1;

        }
        if (choicemove1.M == 9)
        {
            memory.a49 = 1;

        }
        if (choicemove1.M == 10)
        {
            memory.a51 = 1;

        }
        if (choicemove1.M == 11)
        {
            memory.a53 = 1;

        }
        if (choicemove1.M == 12)
        {
            memory.a55 = 1;

        }
        if (choicemove1.M == 13)
        {
            memory.a57 = 1;

        }
        if (choicemove1.M == 14)
        {
            memory.a59 = 1;

        }
        if (choicemove1.M == 15)
        {
            memory.a61 = 1;

        }
        if (choicemove1.M == 16)
        {
            memory.a63 = 1;

        }
        if (choicemove1.M == 17)
        {
            memory.a65 = 1;

        }
        if (choicemove1.M == 18)
        {
            memory.a67 = 1;

        }
        if (choicemove1.M == 19)
        {
            memory.a69 = 1;

        }
        if (choicemove1.M == 20)
        {
            memory.a71 = 1;

        }
        if (choicemove1.M == 21)
        {
            memory.a73 = 1;

        }
        if (choicemove1.M == 22)
        {
            memory.a75 = 1;

        }
        if (choicemove1.M == 23)
        {
            memory.a77 = 1;

        }
        if (choicemove1.M == 24)
        {
            memory.a79 = 1;

        }
        if (choicemove1.M == 25)
        {
            memory.a81 = 1;

        }
        if (choicemove1.M == 26)
        {
            memory.a83 = 1;

        }
        if (choicemove1.M == 27)
        {
            memory.a85 = 1;

        }
        if (choicemove1.M == 28)
        {
            memory.a87 = 1;

        }
        if (choicemove1.M == 29)
        {
            memory.a89 = 1;

        }
  
       
    }
}
