using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TextWhite2 : MonoBehaviour
{
    [SerializeField] public TMP_Text _text;
    [SerializeField] AudioClip aclip;
    [SerializeField] AudioClip bclip;

    Count count;
    SoundManager soundManager;

    public float d_color;
    public void start()
    {


    }

    public void Update()
    {
        count = GameObject.Find("Numbers").GetComponent<Count>();

        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

        _text.text = "Ç†ÇËÇ™Ç∆Ç§Ç≤Ç¥Ç¢Ç‹Ç∑ÅI" +  "\nç°âÒÇÕ" + count.DaysPoint+"ñºéÁÇÈÇ±Ç∆Ç™èoóàÇ‹ÇµÇΩÅB";

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
