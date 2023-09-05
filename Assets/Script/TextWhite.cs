using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TextWhite : MonoBehaviour
{
    [SerializeField] public TMP_Text _text;
    [SerializeField] AudioClip aclip;
    [SerializeField] AudioClip bclip;


    SoundManager soundManager;

    public float d_color;
    public void start()
    {


    }

    public void Update()
    {
        GameObject God = GameObject.FindWithTag("God");
        GameObject Believer = GameObject.FindWithTag("Believer");
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

        _text.text = "かみさま　＝　" + God.name + "\n信者　＝　" + Believer.name;

        d_color += 0.005f;
        _text.faceColor = new Color(236, 41, 41, d_color);

        Invoke("Move", 5.0f);


    }
    public void Move()
    {


        soundManager.PlaySe(aclip);

        SceneManager.LoadScene("GameClear");

    }
}
