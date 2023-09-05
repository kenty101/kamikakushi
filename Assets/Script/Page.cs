using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Page : MonoBehaviour
{
    public GameObject[] page;



    [SerializeField] AudioClip aclip;
    [SerializeField] AudioClip cclip;
    SoundManager soundManager;


    public void Start()
    {
        soundManager = GameObject.FindWithTag("Soundmanager").GetComponent<SoundManager>();


    }
    public void Next()
    {
        soundManager.PlaySe(aclip);

        page[1].SetActive(true);
            soundManager.PlaySe(aclip);
        page[0].SetActive(false);

    }
    public void Next1()
    {
            soundManager.PlaySe(aclip);
        page[2].SetActive(true);
        soundManager.PlaySe(aclip);
        page[1].SetActive(false);

    }
    public void Next2()
    {
            soundManager.PlaySe(aclip);
        page[3].SetActive(true);
            soundManager.PlaySe(aclip);
        page[2].SetActive(false);

    }
    public void Back()
    {
            soundManager.PlaySe(aclip);
        page[0].SetActive(true);
            soundManager.PlaySe(aclip);
        page[1].SetActive(false);

    }
    public void Back1()
    {
            soundManager.PlaySe(aclip);
        page[1].SetActive(true);
            soundManager.PlaySe(aclip);
        page[2].SetActive(false);

    }
    public void Back2()
    {
            soundManager.PlaySe(aclip);
        page[2].SetActive(true);
            soundManager.PlaySe(aclip);
        page[3].SetActive(false);

    }
    public void Title()
    {
            soundManager.PlaySe(aclip);
        SceneManager.LoadScene("TitleScene");

    }
    public void game()
    {
        soundManager.PlaySe(aclip);
        SceneManager.LoadScene("Gameplay1");
        soundManager.PlayBgm(cclip);

    }
}
