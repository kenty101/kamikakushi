using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question2 : MonoBehaviour
{
    public GameObject[] Black;
    SoundManager soundManager;

    [SerializeField] AudioClip clip;



    public void Switch()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();


        if (Black[0].activeSelf)
        {
            soundManager.PlaySe(clip);

            Black[0].SetActive(false);


        }
        else
        {
            soundManager.PlaySe(clip);

            Black[0].SetActive(true);
            Black[3].SetActive(false);
            Black[4].SetActive(false);
            Black[5].SetActive(false);
            Black[6].SetActive(false);


        }
        if (Black[1].activeSelf)
        {
            soundManager.PlaySe(clip);

            Black[1].SetActive(false);


        }
        else
        {
            soundManager.PlaySe(clip);

            Black[1].SetActive(true);
            Black[3].SetActive(false);
            Black[4].SetActive(false);
            Black[5].SetActive(false);
            Black[6].SetActive(false);

        }
        if (Black[2].activeSelf)
        {
            soundManager.PlaySe(clip);

            Black[2].SetActive(false);


        }
        else
        {
            soundManager.PlaySe(clip);

            Black[2].SetActive(true);
            Black[3].SetActive(false);
            Black[4].SetActive(false);
            Black[5].SetActive(false);
            Black[6].SetActive(false);

        }




    }
}
