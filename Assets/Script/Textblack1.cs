using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Textblack1 : MonoBehaviour
{
    [SerializeField] public TMP_Text _text;
    [SerializeField] AudioClip aclip;

    SoundManager soundManager;

    public float d_color;
    public void start()
    {


    }

    public void Update()
    {
        GameObject God = GameObject.FindWithTag("God");
        GameObject Believer = GameObject.FindWithTag("Believer");
        GameObject Believer2 = GameObject.FindWithTag("Beliver2");

        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

        _text.text ="���݂��܁@���@" + God.name +"\n�M�ҁ@���@" + Believer.name + "\n�M�ҁ@���@" + Believer2.name;

        d_color += 0.005f;
        _text.faceColor = new Color(236, 41, 41, d_color);

        Invoke("Move", 5.0f);


    }
    public void Move()
    {
        soundManager.PlaySe(aclip);

        SceneManager.LoadScene("GameOver");

    }
}
