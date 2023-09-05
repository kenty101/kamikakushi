using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuetionTime : MonoBehaviour
{
    public GameObject Hear;
    public GameObject High;
    SoundManager soundManager;

    [SerializeField] AudioClip clip;


    public void Switch()
    {

        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

        if (Hear.activeSelf)
            {
            soundManager.PlaySe(clip);

            Hear.SetActive(false);
           
                
            }
            else
            {
            soundManager.PlaySe(clip);

            Hear.SetActive(true);

            }

        if (High.activeSelf)
        {
            soundManager.PlaySe(clip);

            High.SetActive(false);


        }
        else
        {
            soundManager.PlaySe(clip);

            High.SetActive(true);

        }

    }

   




}
