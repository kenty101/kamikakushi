using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Character2 : MonoBehaviour
{
    public GameObject[] characters;


    Tarou tarou;




    // Start is called before the first frame update
    void Start()
    {

        int n = Random.Range(0, 29);
        int s = Random.Range(0, 29);
        int m = Random.Range(0, 29);
        if ( n == s )
        {
            s += 1;
            if (s >= 29)
                s = 0;
           
        }
        else
        {
            s += 0;

        }
        if (n == m)
        {
            m += 2;
            if (s >= 29)
                s = 0;

        }
        else
        {
            m += 0;

        }
        if (s == m)
        {
            m += 1;
            if (s >= 29)
                m = 0;

        }
        else
        {
            m += 0;

        }
        characters[n].tag = "God";
        characters[s].tag = "Believer";
        characters[m].tag = "Beliver2";




    }

    void Move()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
