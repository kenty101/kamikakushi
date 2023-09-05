using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{


    public GameObject[] Gard;
    public GameObject[] Gard2;
    public GameObject[] chara;
    public int b = 0;
    public int a;
    public int num = 2;

    List<int> numbers = new List<int>();
    Tarou tarou;

    [SerializeField] public Days1 _days1;
    public int DaysPoint = 0;
    private static Count _instance;

    [SerializeField] public Zannsuu1 _zannsuu1;
    public int ZannsuPoint = 0;


    // Start is called before the first frame update
    void Start()
    {
        //èâä˙ëÃóÕ
        DaysPoint = 30;
        _days1.SetDays(DaysPoint);
        ZannsuPoint = 30;
        _zannsuu1.SetZannsuu(ZannsuPoint);
        _instance = this;
        num = 2;
        for (int i = 0; i <= 29; i ++)
        {
            numbers.Add(i);
        }
    }

    public void Move()
    {
        DaysPoint-= 2;
        _days1.SetDays(DaysPoint);
        ZannsuPoint-= 2;
        _zannsuu1.SetZannsuu(ZannsuPoint);
        _instance = this;
       

        GameObject God = GameObject.FindWithTag("God");
        tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();


        while (num-- >0)
        {
            LOOPEND:
            int index = Random.Range(0, numbers.Count);
            int ransu = numbers[index];
            Debug.Log(ransu);
            a = ransu;
            numbers.RemoveAt(index);
            if(tarou.d == a)
            {
                goto LOOPEND;
            }

            Gard[a].SetActive(true);
            Gard2[a].SetActive(true);
        }

        num = 2;
    }
    public void Plas()
    {

        _instance = this;
        GameObject God = GameObject.FindWithTag("God");
        tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();

        while (num-- > 0)
        {


             LOOPEND1:
            int index = Random.Range(0, numbers.Count);
            int ransu = numbers[index];
            Debug.Log(ransu);
            a = ransu;
            numbers.RemoveAt(index);
            if (tarou.d == a)
            {
                goto LOOPEND1;
            }

            Gard[a].SetActive(true);
            Gard2[a].SetActive(true);
        }

        num = 2;
    }
    // Update is called once per frame
    void Update()
    {

    }
 

}
