using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fadeout : MonoBehaviour
{
    public GameObject No;

    public bool flgFade;
    Color color;

    void Start()
    {
        color = gameObject.GetComponent<Image>().color;

        color.r = 0.0f;
        color.g = 0.0f;
        color.b = 0.0f;
        color.a = 0.1f;
        gameObject.GetComponent<Image>().color = color;



    }

    public void Update()
    {
        if (flgFade == true)
        {
            color.a += 0.1f;
            gameObject.GetComponent<Image>().color = color;

            if (color.a >= 1)
            {
                flgFade = false;
            }
        }


    }

    public void Switch()
    {


        if (No.activeSelf)
        {
            No.SetActive(false);




        }


        else
        {
            No.SetActive(true);
            flgFade = true;
        }





    }

}
