using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question3 : MonoBehaviour
{
    public GameObject Question;
    public GameObject No;







    public void Switch()
    {


        if (Question.activeSelf)
        {
            Question.SetActive(false);




        }

    
        else
        {
            Question.SetActive(true);

        }
        if (No.activeSelf)
        {
            No.SetActive(false);
            Question.SetActive(false);



        }
        else
        {
            No.SetActive(true);
            Question.SetActive(false);





        }



    }




}
