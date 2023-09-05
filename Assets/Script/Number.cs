using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{



    [SerializeField] public Days _days;
    public int DaysPoint = 0;
    private static Number _instance;

    [SerializeField] public Zannsuu _zannsuu;
    public int ZannsuuPoint = 0;


    // Start is called before the first frame update
    void Start()
    {
        //‰Šú‘Ì—Í
        DaysPoint = 5;
        _days.SetDays(DaysPoint);
        ZannsuuPoint = 5;
        _zannsuu.SetZannsuu(ZannsuuPoint);
        _instance = this;

    }

    public void Move()
    {
        --DaysPoint;
        _days.SetDays(DaysPoint);
        --ZannsuuPoint;
        _zannsuu.SetZannsuu(ZannsuuPoint);
        _instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
