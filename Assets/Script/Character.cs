using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Character : MonoBehaviour
{
    public GameObject[] characters;


    Tarou tarou;




    // Start is called before the first frame update
    void Start()
    {

        int n = Random.Range(0, 29);
        int s = Random.Range(0, 29);
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
        characters[n].tag = "God";

        characters[s].tag = "Believer";



    }

    void Move()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
