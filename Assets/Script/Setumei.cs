using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Setumei : MonoBehaviour
{
    SoundManager soundManager;
    public GameObject[] setu;
    public GameObject gamen;

    [SerializeField] AudioClip aclip;
    [SerializeField] AudioClip bclip;


    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

    }

    public void Page()
    {
        soundManager.PlaySe(aclip);

        setu[0].SetActive(true);
    }
    public void Page1()
    {
        soundManager.PlaySe(aclip);

        setu[1].SetActive(false);

        setu[2].SetActive(true);
    }
    public void Page2()
    {
        soundManager.PlaySe(aclip);

        setu[2].SetActive(false);

        setu[3].SetActive(true);
    }
    public void Page3()
    {
        soundManager.PlaySe(aclip);

        setu[3].SetActive(false);

        setu[4].SetActive(true);
    }
    public void Page4()
    {
        soundManager.PlaySe(aclip);

        setu[4].SetActive(false);
        setu[1].SetActive(true);
        setu[0].SetActive(false);

    }
    public void Back()
    {
        soundManager.PlaySe(aclip);

        setu[0].SetActive(false);

    }
    public void Back1()
    {
        soundManager.PlaySe(aclip);

        setu[2].SetActive(false);

        setu[1].SetActive(true);
    }
    public void Back2()
    {
        soundManager.PlaySe(aclip);

        setu[3].SetActive(false);

        setu[2].SetActive(true);
    }
    public void Back3()
    {
        soundManager.PlaySe(aclip);

        setu[4].SetActive(false);

        setu[3].SetActive(true);
    }
    public void HIraku()
    {
        soundManager.PlaySe(bclip);

        gamen.SetActive(true);
    }
    public void tojiru()
    {
        soundManager.PlaySe(bclip);

        gamen.SetActive(false);
    }
}
