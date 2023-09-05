using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Character1 : MonoBehaviour
{
    public GameObject[] characters;
    public GameObject[] characters1;
    public GameObject[] characters2;
    public GameObject[] characters3;
    public GameObject[] characters4;
    public GameObject[] characters5;


    Tarou tarou;




    // Start is called before the first frame update
    void Start()
    {

        int n = Random.Range(0, 29);
        int s = Random.Range(0, 29);
        int i = Random.Range(0, 29);
        int a = Random.Range(0, 29);
        int b = Random.Range(0, 29);

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
        if (n == i)
        {
            i += 2;
            if (i >= 29)
                i = 0;

        }
        else
        {
            i += 0;

        }
        if (n == a)
        {
            a += 3;
            if (a >= 29)
                a = 0;

        }
        else
        {
            a += 0;

        }
        if (n == b)
        {
            b += 4;
            if (b >= 29)
                b = 0;

        }
        else
        {
            b += 0;

        }
        if (s == i)
        {
            i += 1;
            if (i >= 29)
                i = 0;

        }
        else
        {
            i += 0;

        }
        if (s == a)
        {
            a += 2;
            if (a >= 29)
                a = 0;

        }
        else
        {
            a += 0;

        }
        if (s == b)
        {
            b += 3;
            if (b >= 29)
                b = 0;

        }
        else
        {
            b += 0;

        }
        if (i == a)
        {
            a += 1;
            if (a >= 29)
                a = 0;

        }
        else
        {
            a += 0;

        }
        if (i == b)
        {
            b += 2;
            if (b >= 29)
                b = 0;

        }
        else
        {
            b += 0;

        }
        if (a == b)
        {
            b += 1;
            if (b >= 29)
                b = 0;

        }
        else
        {
            b += 0;

        }
        characters[n].tag = "God";

        characters[s].tag = "Believer";
        characters1[n].SetActive(false);
        characters1[s].SetActive(false);
        characters1[i].SetActive(false);
        characters1[a].SetActive(false);
        characters1[b].SetActive(false);
        characters2[n].SetActive(false);
        characters2[s].SetActive(false);
        characters2[i].SetActive(false);
        characters2[a].SetActive(false);
        characters2[b].SetActive(false);



    }

    void Move()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
