using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Memo : MonoBehaviour
{
    [SerializeField] public TMP_Text _text;
    [SerializeField] public TMP_Text _text2;
    [SerializeField] public TMP_Text _text3;
    [SerializeField] public TMP_Text _text4;
    [SerializeField] public TMP_Text _text5;



    public int a = 0;
    public int b = 0;
    public int c = 0;
    public int d = 0;
    public int e = 0;
    public int f = 0;
    public int g = 0;
    public int h = 0;
    public int i = 0;
    public int j = 0;
    public int k = 0;
    public int l = 0;
    public int n = 0;
    public int m = 0;
    public int o = 0;


    public string na = "0";
    public string na1 = "0";
    public string na2 = "0";
    public string na3 = "0";
    public string na4 = "0";

    // Update is called once per frame
    void Update()
    {
        if (a == 1 && f == 1)
        {
            _text.text = "質問：服の色は黒ですか？" + "\n" + na + ":〇";
        }
        else if (a == 1 && g == 1)
        {
            _text.text = "質問：服の色は黒ですか？" + "\n" + na + ":×";
        }
        else if (a == 2 && f == 1)
        {
            _text.text = "質問：服の色は赤ですか？" + "\n" + na + ":〇";
        }
        else if (a == 2 && g == 1)
        {
            _text.text = "質問：服の色は赤ですか？" + "\n" + na + ":×";
        }
        else if (a == 3 && f == 1)
        {
            _text.text = "質問：服の色は白ですか？" + "\n" + na + ":〇";
        }
        else if (a == 3 && g == 1)
        {
            _text.text = "質問：服の色は白ですか？" + "\n" + na + ":×";
        }
        else if (a == 4 && f == 1)
        {
            _text.text = "質問：あなたより高いですか？" + "\n" + na + ":〇";
        }
        else if (a == 4 && g == 1)
        {
            _text.text = "質問：あなたより高いですか？" + "\n" + na + ":×";
        }
        else if (a == 5 && f == 1)
        {
            _text.text = "質問：あなたより低いですか？" + "\n" + na + ":〇";
        }
        else if (a == 5 && g == 1)
        {
            _text.text = "質問：あなたより低いですか？" + "\n" + na + ":×";
        }
        else if (a == 6 && f == 1)
        {
            _text.text = "質問：あなたより重いですか？" + "\n" + na + ":〇";
        }
        else if (a == 6 && g == 1)
        {
            _text.text = "質問：あなたより重いですか？" + "\n" + na + ":×";
        }
        else if (a == 7 && f == 1)
        {
            _text.text = "質問：あなたより軽いですか？" + "\n" + na + ":〇";
        }
        else if (a == 7 && g == 1)
        {
            _text.text = "質問：あなたより軽いですか？" + "\n" + na + ":×";
        }

        if (b == 1 && h == 1)
        {
            _text2.text = "質問：服の色は黒ですか？" + "\n" + na1 + ":〇";
        }
        else if (b == 1 && i == 1)
        {
            _text2.text = "質問：服の色は黒ですか？" + "\n" + na1 + ":×";
        }
        else if (b == 2 && h == 1)
        {
            _text2.text = "質問：服の色は赤ですか？" + "\n" + na1 + ":〇";
        }
        else if (b == 2 && i == 1)
        {
            _text2.text =  "質問：服の色は赤ですか？" + "\n" + na1 + ":×";
        }
        else if (b == 3 && h == 1)
        {
            _text2.text = "質問：服の色は白ですか？" + "\n" + na1 + ":〇";
        }
        else if (b == 3 && i == 1)
        {
            _text2.text =  "質問：服の色は白ですか？" + "\n" + na1 + ":×";
        }
        else if (b == 4 && h == 1)
        {
            _text2.text =  "質問：あなたより高いですか？" + "\n" + na1 + ":〇";
        }
        else if (b == 4 && i == 1)
        {
            _text2.text = "質問：あなたより高いですか？" + "\n" + na1 + ":×";
        }
        else if (b == 5 && h == 1)
        {
            _text2.text =  "質問：あなたより低いですか？" + "\n" + na1 + ":〇";
        }
        else if (b == 5 && i == 1)
        {
            _text2.text =  "質問：あなたより低いですか？" + "n\n" + na1 + ":×";
        }
        else if (b == 6 && h == 1)
        {
            _text2.text = "質問：あなたより重いですか？" + "\n" + na1 + ":〇";
        }
        else if (b == 6 && i == 1)
        {
            _text2.text = "質問：あなたより重いですか？" + "\n" + na1 + ":×";
        }
        else if (b == 7 && h == 1)
        {
            _text2.text = "質問：あなたより軽いですか？" + "\n" + na1 + ":〇";
        }
        else if (b == 7 && i == 1)
        {
            _text2.text =  "質問：あなたより軽いですか？" + "\n" + na1 + ":×";
        }

        if (c == 1 && j == 1)
        {
            _text3.text =  "質問：服の色は黒ですか？" + "\n" + na2 + ":〇";
        }
        else if (c == 1 && k == 1)
        {
            _text3.text =  "質問：服の色は黒ですか？" + "\n" + na2 + ":×";
        }
        else if (c == 2 && j == 1)
        {
            _text3.text = "質問：服の色は赤ですか？" + "\n" + na2 + ":〇";
        }
        else if (c == 2 && k == 1)
        {
            _text3.text =  "質問：服の色は赤ですか？" + "\n" + na2 + ":×";
        }
        else if (c == 3 && j == 1)
        {
            _text3.text =  "質問：服の色は白ですか？" + "\n" + na2 + ":〇";
        }
        else if (c == 3 && k == 1)
        {
            _text3.text =  "質問：服の色は白ですか？" + "\n" + na2 + ":×";
        }
        else if (c == 4 && j == 1)
        {
            _text3.text =  "質問：あなたより高いですか？" + "\n" + na2 + ":〇";
        }
        else if (c == 4 && k == 1)
        {
            _text3.text = "質問：あなたより高いですか？" + "\n" + na2 + ":×";
        }
        else if (c == 5 && j == 1)
        {
            _text3.text = "質問：あなたより低いですか？" + "\n" + na2 + ":〇";
        }
        else if (c == 5 && k == 1)
        {
            _text3.text =  "質問：あなたより低いですか？" + "\n" + na2 + ":×";
        }
        else if (c == 6 && j == 1)
        {
            _text3.text = "質問：あなたより重いですか？" + "\n" + na2 + ":〇";
        }
        else if (c == 6 && k == 1)
        {
            _text3.text =  "質問：あなたより重いですか？" + "\n" + na2 + ":×";
        }
        else if (c == 7 && j == 1)
        {
            _text3.text =  "質問：あなたより軽いですか？" + "\n" + na2 + ":〇";
        }
        else if (c == 7 && k == 1)
        {
            _text3.text = "質問：あなたより軽いですか？" + "\n" + na2 + ":×";
        }
        if (d == 1 && l == 1)
        {
            _text4.text =  "質問：服の色は黒ですか？" + "\n" + na3 + ":〇";
        }
        else if (d == 1 && n == 1)
        {
            _text4.text =  "質問：服の色は黒ですか？" + "\n" + na3 + ":×";
        }
        else if (d == 2 && l == 1)
        {
            _text4.text =  "質問：服の色は赤ですか？" + "\n" + na3 + ":〇";
        }
        else if (d == 2 && n == 1)
        {
            _text4.text = "質問：服の色は赤ですか？" + "\n" + na3 + ":×";
        }
        else if (d == 3 && l == 1)
        {
            _text4.text =  "質問：服の色は白ですか？" + "\n" + na3 + ":〇";
        }
        else if (d == 3 && n == 1)
        {
            _text4.text =  "質問：服の色は白ですか？" + "\n" + na3 + ":×";
        }
        else if (d == 4 && l == 1)
        {
            _text4.text =  "質問：あなたより高いですか？" + "\n" + na3 + ":〇";
        }
        else if (d == 4 && n == 1)
        {
            _text4.text =  "質問：あなたより高いですか？" + "\n" + na3 + ":×";
        }
        else if (d == 5 && l == 1)
        {
            _text4.text =  "質問：あなたより低いですか？" + "\n" + na3 + ":〇";
        }
        else if (d == 5 && n == 1)
        {
            _text4.text =  "質問：あなたより低いですか？" + "\n" + na3 + ":×";
        }
        else if (d == 6 && l == 1)
        {
            _text4.text =  "質問：あなたより重いですか？" + "\n" + na3 + ":〇";
        }
        else if (d == 6 && n == 1)
        {
            _text4.text = "質問：あなたより重いですか？" + "\n" + na3 + ":×";
        }
        else if (d == 7 && l == 1)
        {
            _text4.text =  "質問：あなたより軽いですか？" + "\n" + na3 + ":〇";
        }
        else if (d == 7 && n == 1)
        {
            _text4.text =  "質問：あなたより軽いですか？" + "\n" + na3 + ":×";
        }

        if (e == 1 && m == 1)
        {
            _text5.text =  "質問：服の色は黒ですか？" + "\n" + na4 + ":〇";
        }
        else if (e == 1 && o == 1)
        {
            _text5.text =  "質問：服の色は黒ですか？" + "\n" + na4 + ":×";
        }
        else if (e == 2 && m == 1)
        {
            _text5.text =  "質問：服の色は赤ですか？" + "\n" + na4 + ":〇";
        }
        else if (e == 2 && o == 1)
        {
            _text5.text =  "質問：服の色は赤ですか？" + "\n" + na4 + ":×";
        }
        else if (e == 3 && m == 1)
        {
            _text5.text =  "質問：服の色は白ですか？" + "\n" + na4 + ":〇";
        }
        else if (e == 3 && o == 1)
        {
            _text5.text =  "質問：服の色は白ですか？" + "\n" + na4 + ":×";
        }
        else if (e == 4 && m == 1)
        {
            _text5.text =  "質問：あなたより高いですか？" + "\n" + na4 + ":〇";
        }
        else if (e == 4 && o == 1)
        {
            _text5.text =  "質問：あなたより高いですか？" + "\n" + na4 + ":×";
        }
        else if (e == 5 && m == 1)
        {
            _text5.text =  "質問：あなたより低いですか？" + "\n" + na4 + ":〇";
        }
        else if (e == 5 && o == 1)
        {
            _text5.text =  "質問：あなたより低いですか？" + "\n" + na4 + ":×";
        }
        else if (e == 6 && m == 1)
        {
            _text5.text =  "質問：あなたより重いですか？" + "\n" + na4 + ":〇";
        }
        else if (e == 6 && o == 1)
        {
            _text5.text =  "質問：あなたより重いですか？" + "\n" + na4 + ":×";
        }
        else if (e == 7 && m == 1)
        {
            _text5.text =  "質問：あなたより軽いですか？" + "\n" + na4 + ":〇";
        }
        else if (e == 7 && o == 1)
        {
            _text5.text =  "質問：あなたより軽いですか？" + "\n" + na4 + ":×";
        }
    }

}