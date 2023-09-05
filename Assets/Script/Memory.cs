using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Memory : MonoBehaviour
{
    ChoiceMove1 choicemove1;
    [SerializeField] public TMP_Text _text;
    [SerializeField] public TMP_Text _text2;
    [SerializeField] public TMP_Text _text3;
    [SerializeField] public TMP_Text _text4;
    [SerializeField] public TMP_Text _text5;
    [SerializeField] public TMP_Text _text6;
    [SerializeField] public TMP_Text _text7;
    [SerializeField] public TMP_Text _text8;
    [SerializeField] public TMP_Text _text9;
    [SerializeField] public TMP_Text _text10;
    [SerializeField] public TMP_Text _text11;
    [SerializeField] public TMP_Text _text12;
    [SerializeField] public TMP_Text _text13;
    [SerializeField] public TMP_Text _text14;
    [SerializeField] public TMP_Text _text15;
    [SerializeField] public TMP_Text _text16;
    [SerializeField] public TMP_Text _text17;
    [SerializeField] public TMP_Text _text18;
    [SerializeField] public TMP_Text _text19;
    [SerializeField] public TMP_Text _text20;
    [SerializeField] public TMP_Text _text21;
    [SerializeField] public TMP_Text _text22;
    [SerializeField] public TMP_Text _text23;
    [SerializeField] public TMP_Text _text24;
    [SerializeField] public TMP_Text _text25;
    [SerializeField] public TMP_Text _text26;
    [SerializeField] public TMP_Text _text27;
    [SerializeField] public TMP_Text _text28;
    [SerializeField] public TMP_Text _text29;
    [SerializeField] public TMP_Text _text30;

    public int a = 0;
    public int a1 = 0;
    public int a2 = 0;
    public int a3 = 0;
    public int a4 = 0;
    public int a5 = 0;
    public int a6 = 0;
    public int a7 = 0;
    public int a8 = 0;
    public int a9 = 0;
    public int a10 = 0;
    public int a11 = 0;
    public int a12 = 0;
    public int a13 = 0;
    public int a14 = 0;
    public int a15 = 0;
    public int a16 = 0;
    public int a17 = 0;
    public int a18 = 0;
    public int a19 = 0;
    public int a20 = 0;
    public int a21 = 0;
    public int a22 = 0;
    public int a23 = 0;
    public int a24 = 0;
    public int a25 = 0;
    public int a26 = 0;
    public int a27 = 0;
    public int a28 = 0;
    public int a29 = 0;
    public int a30 = 0;
    public int a31 = 0;
    public int a32 = 0;
    public int a33 = 0;
    public int a34 = 0;
    public int a35 = 0;
    public int a36 = 0;
    public int a37 = 0;
    public int a38 = 0;
    public int a39 = 0;
    public int a40 = 0;
    public int a41 = 0;
    public int a42 = 0;
    public int a43 = 0;
    public int a44 = 0;
    public int a45 = 0;
    public int a46 = 0;
    public int a47 = 0;
    public int a48 = 0;
    public int a49 = 0;
    public int a50 = 0;
    public int a51 = 0;
    public int a52 = 0;
    public int a53 = 0;
    public int a54 = 0;
    public int a55 = 0;
    public int a56 = 0;
    public int a57 = 0;
    public int a58 = 0;
    public int a59 = 0;
    public int a60 = 0;
    public int a61 = 0;
    public int a62 = 0;
    public int a63 = 0;
    public int a64 = 0;
    public int a65 = 0;
    public int a66 = 0;
    public int a67 = 0;
    public int a68 = 0;
    public int a69 = 0;
    public int a70 = 0;
    public int a71 = 0;
    public int a72 = 0;
    public int a73 = 0;
    public int a74 = 0;
    public int a75 = 0;
    public int a76 = 0;
    public int a77 = 0;
    public int a78 = 0;
    public int a79 = 0;
    public int a80 = 0;
    public int a81 = 0;
    public int a82 = 0;
    public int a83 = 0;
    public int a84 = 0;
    public int a85 = 0;
    public int a86 = 0;
    public int a87 = 0;
    public int a88 = 0;
    public int a89 = 0;

    public string na = "0";
    public string na1 = "0";
    public string na2 = "0";
    public string na3 = "0";
    public string na4 = "0";
    public string na5 = "0";
    public string na6 = "0";
    public string na7 = "0";
    public string na8 = "0";
    public string na9 = "0";
    public string na10 = "0";
    public string na11 = "0";
    public string na12 = "0";
    public string na13 = "0";
    public string na14 = "0";
    public string na15 = "0";
    public string na16 = "0";
    public string na17 = "0";
    public string na18 = "0";
    public string na19 = "0";
    public string na20 = "0";
    public string na21 = "0";
    public string na22 = "0";
    public string na23 = "0";
    public string na24 = "0";
    public string na25 = "0";
    public string na26 = "0";
    public string na27 = "0";
    public string na28 = "0";
    public string na29 = "0";
    void start()
    {
        choicemove1 = GameObject.Find("Canvas").GetComponent<ChoiceMove1>();

    }
    void Update()
    {
 
            
        if (a == 1 && a30 == 1)
           {
                _text.text = "質問：服の色は黒ですか？" + "\n" + na + ":〇";

            }
            else if (a == 1 && a31 == 1)
            {
                _text.text = "質問：服の色は黒ですか？" + "\n" + na + ":×";
            }
            else if (a == 2 && a30 == 1)
            {
                _text.text = "質問：服の色は赤ですか？" + "\n" + na + ":〇";
            }
            else if (a == 2 && a31 == 1)
            {
                _text.text = "質問：服の色は赤ですか？" + "\n" + na + ":×";
            }
            else if (a == 3 && a30 == 1)
            {
                _text.text = "質問：服の色は白ですか？" + "\n" + na + ":〇";
            }
            else if (a == 3 && a31 == 1)
            {
                _text.text = "質問：服の色は白ですか？" + "\n" + na + ":×";
            }
            else if (a == 4 && a30 == 1)
            {
                _text.text = "質問：あなたより高いですか？" + "\n" + na + ":〇";
            }
            else if (a == 4 && a31 == 1)
            {
                _text.text = "質問：あなたより高いですか？" + "\n" + na + ":×";
            }
            else if (a == 5 && a30 == 1)
            {
                _text.text = "質問：あなたより低いですか？" + "\n" + na + ":〇";
            }
            else if (a == 5 && a31 == 1)
            {
                _text.text = "質問：あなたより低いですか？" + "\n" + na + ":×";
            }
            else if (a == 6 && a30 == 1)
            {
                _text.text = "質問：あなたより重いですか？" + "\n" + na + ":〇";
            }
            else if (a == 6 && a31 == 1)
            {
                _text.text = "質問：あなたより重いですか？" + "\n" + na + ":×";
            }
            else if (a == 7 && a30 == 1)
            {
                _text.text = "質問：あなたより軽いですか？" + "\n" + na + ":〇";
            }
            else if (a == 7 && a31 == 1)
            {
                _text.text = "質問：あなたより軽いですか？" + "\n" + na + ":×";
            }
      

        if (a1 == 1 && a32 == 1)
        {
            _text2.text = "質問：服の色は黒ですか？" + "\n" + na1 + ":〇";
        }
        else if (a1 == 1 && a33 == 1)
        {
            _text2.text = "質問：服の色は黒ですか？" + "\n" + na1 + ":×";
        }
        else if (a1 == 2 && a32 == 1)
        {
            _text2.text = "質問：服の色は赤ですか？" + "\n" + na1 + ":〇";
        }
        else if (a1 == 2 && a33 == 1)
        {
            _text2.text = "質問：服の色は赤ですか？" + "\n" + na1 + ":×";
        }
        else if (a1 == 3 && a32 == 1)
        {
            _text2.text = "質問：服の色は白ですか？" + "\n" + na1 + ":〇";
        }
        else if (a1 == 3 && a33 == 1)
        {
            _text2.text = "質問：服の色は白ですか？" + "\n" + na1 + ":×";
        }
        else if (a1 == 4 && a32 == 1)
        {
            _text2.text = "質問：あなたより高いですか？" + "\n" + na1 + ":〇";
        }
        else if (a1 == 4 && a33 == 1)
        {
            _text2.text = "質問：あなたより高いですか？" + "\n" + na1 + ":×";
        }
        else if (a1 == 5 && a32 == 1)
        {
            _text2.text = "質問：あなたより低いですか？" + "\n" + na1 + ":〇";
        }
        else if (a1 == 5 && a33 == 1)
        {
            _text2.text = "質問：あなたより低いですか？" + "n\n" + na1 + ":×";
        }
        else if (a1 == 6 && a32 == 1)
        {
            _text2.text = "質問：あなたより重いですか？" + "\n" + na1 + ":〇";
        }
        else if (a1 == 6 && a33 == 1)
        {
            _text2.text = "質問：あなたより重いですか？" + "\n" + na1 + ":×";
        }
        else if (a1 == 7 && a32 == 1)
        {
            _text2.text = "質問：あなたより軽いですか？" + "\n" + na1 + ":〇";
        }
        else if (a1 == 7 && a33 == 1)
        {
            _text2.text = "質問：あなたより軽いですか？" + "\n" + na1 + ":×";
        }

        if (a2 == 1 && a34 == 1)
        {
            _text3.text = "質問：服の色は黒ですか？" + "\n" + na2 + ":〇";
        }
        else if (a2 == 1 && a35 == 1)
        {
            _text3.text = "質問：服の色は黒ですか？" + "\n" + na2 + ":×";
        }
        else if (a2 == 2 && a34 == 1)
        {
            _text3.text = "質問：服の色は赤ですか？" + "\n" + na2 + ":〇";
        }
        else if (a2 == 2 && a35 == 1)
        {
            _text3.text = "質問：服の色は赤ですか？" + "\n" + na2 + ":×";
        }
        else if (a2 == 3 && a34 == 1)
        {
            _text3.text = "質問：服の色は白ですか？" + "\n" + na2 + ":〇";
        }
        else if (a2 == 3 && a35 == 1)
        {
            _text3.text = "質問：服の色は白ですか？" + "\n" + na2 + ":×";
        }
        else if (a2 == 4 && a34 == 1)
        {
            _text3.text = "質問：あなたより高いですか？" + "\n" + na2 + ":〇";
        }
        else if (a2 == 4 && a35 == 1)
        {
            _text3.text = "質問：あなたより高いですか？" + "\n" + na2 + ":×";
        }
        else if (a2 == 5 && a34 == 1)
        {
            _text3.text = "質問：あなたより低いですか？" + "\n" + na2 + ":〇";
        }
        else if (a2 == 5 && a35 == 1)
        {
            _text3.text = "質問：あなたより低いですか？" + "\n" + na2 + ":×";
        }
        else if (a2 == 6 && a34 == 1)
        {
            _text3.text = "質問：あなたより重いですか？" + "\n" + na2 + ":〇";
        }
        else if (a2 == 6 && a35 == 1)
        {
            _text3.text = "質問：あなたより重いですか？" + "\n" + na2 + ":×";
        }
        else if (a2 == 7 && a34 == 1)
        {
            _text3.text = "質問：あなたより軽いですか？" + "\n" + na2 + ":〇";
        }
        else if (a2 == 7 && a35 == 1)
        {
            _text3.text = "質問：あなたより軽いですか？" + "\n" + na2 + ":×";
        }
        if (a3 == 1 && a36 == 1)
        {
            _text4.text = "質問：服の色は黒ですか？" + "\n" + na3 + ":〇";
        }
        else if (a3 == 1 && a37 == 1)
        {
            _text4.text = "質問：服の色は黒ですか？" + "\n" + na3 + ":×";
        }
        else if (a3 == 2 && a36 == 1)
        {
            _text4.text = "質問：服の色は赤ですか？" + "\n" + na3 + ":〇";
        }
        else if (a3 == 2 && a37 == 1)
        {
            _text4.text = "質問：服の色は赤ですか？" + "\n" + na3 + ":×";
        }
        else if (a3 == 3 && a36 == 1)
        {
            _text4.text = "質問：服の色は白ですか？" + "\n" + na3 + ":〇";
        }
        else if (a3 == 3 && a37 == 1)
        {
            _text4.text = "質問：服の色は白ですか？" + "\n" + na3 + ":×";
        }
        else if (a3 == 4 && a36 == 1)
        {
            _text4.text = "質問：あなたより高いですか？" + "\n" + na3 + ":〇";
        }
        else if (a3 == 4 && a37 == 1)
        {
            _text4.text = "質問：あなたより高いですか？" + "\n" + na3 + ":×";
        }
        else if (a3 == 5 && a36 == 1)
        {
            _text4.text = "質問：あなたより低いですか？" + "\n" + na3 + ":〇";
        }
        else if (a3 == 5 && a37 == 1)
        {
            _text4.text = "質問：あなたより低いですか？" + "\n" + na3 + ":×";
        }
        else if (a3 == 6 && a36 == 1)
        {
            _text4.text = "質問：あなたより重いですか？" + "\n" + na3 + ":〇";
        }
        else if (a3 == 6 && a37 == 1)
        {
            _text4.text = "質問：あなたより重いですか？" + "\n" + na3 + ":×";
        }
        else if (a3 == 7 && a36 == 1)
        {
            _text4.text = "質問：あなたより軽いですか？" + "\n" + na3 + ":〇";
        }
        else if (a3 == 7 && a37 == 1)
        {
            _text4.text = "質問：あなたより軽いですか？" + "\n" + na3 + ":×";
        }

        if (a4 == 1 && a38 == 1)
        {
            _text5.text = "質問：服の色は黒ですか？" + "\n" + na4 + ":〇";
        }
        else if (a4 == 1 && a39 == 1)
        {
            _text5.text = "質問：服の色は黒ですか？" + "\n" + na4 + ":×";
        }
        else if (a4 == 2 && a38 == 1)
        {
            _text5.text = "質問：服の色は赤ですか？" + "\n" + na4 + ":〇";
        }
        else if (a4 == 2 && a39 == 1)
        {
            _text5.text = "質問：服の色は赤ですか？" + "\n" + na4 + ":×";
        }
        else if (a4 == 3 && a38 == 1)
        {
            _text5.text = "質問：服の色は白ですか？" + "\n" + na4 + ":〇";
        }
        else if (a4 == 3 && a39 == 1)
        {
            _text5.text = "質問：服の色は白ですか？" + "\n" + na4 + ":×";
        }
        else if (a4 == 4 && a38 == 1)
        {
            _text5.text = "質問：あなたより高いですか？" + "\n" + na4 + ":〇";
        }
        else if (a4 == 4 && a39 == 1)
        {
            _text5.text = "質問：あなたより高いですか？" + "\n" + na4 + ":×";
        }
        else if (a4 == 5 && a38 == 1)
        {
            _text5.text = "質問：あなたより低いですか？" + "\n" + na4 + ":〇";
        }
        else if (a4 == 5 && a39 == 1)
        {
            _text5.text = "質問：あなたより低いですか？" + "\n" + na4 + ":×";
        }
        else if (a4 == 6 && a38 == 1)
        {
            _text5.text = "質問：あなたより重いですか？" + "\n" + na4 + ":〇";
        }
        else if (a4 == 6 && a39 == 1)
        {
            _text5.text = "質問：あなたより重いですか？" + "\n" + na4 + ":×";
        }
        else if (a4 == 7 && a38 == 1)
        {
            _text5.text = "質問：あなたより軽いですか？" + "\n" + na4 + ":〇";
        }
        else if (a4 == 7 && a39 == 1)
        {
            _text5.text = "質問：あなたより軽いですか？" + "\n" + na4 + ":×";
        }


        if (a5 == 1 && a40 == 1)
        {
            _text6.text = "質問：服の色は黒ですか？" + "\n" + na5 + ":〇";

        }
        else if (a5 == 1 && a41 == 1)
        {
            _text6.text = "質問：服の色は黒ですか？" + "\n" + na5 + ":×";
        }
        else if (a5 == 2 && a40 == 1)
        {
            _text6.text = "質問：服の色は赤ですか？" + "\n" + na5 + ":〇";
        }
        else if (a5 == 2 && a41 == 1)
        {
            _text6.text = "質問：服の色は赤ですか？" + "\n" + na5 + ":×";
        }
        else if (a5 == 3 && a40 == 1)
        {
            _text6.text = "質問：服の色は白ですか？" + "\n" + na5 + ":〇";
        }
        else if (a5 == 3 && a41 == 1)
        {
            _text6.text = "質問：服の色は白ですか？" + "\n" + na5 + ":×";
        }
        else if (a5 == 4 && a40 == 1)
        {
            _text6.text = "質問：あなたより高いですか？" + "\n" + na5 + ":〇";
        }
        else if (a5 == 4 && a41 == 1)
        {
            _text6.text = "質問：あなたより高いですか？" + "\n" + na5 + ":×";
        }
        else if (a5 == 5 && a40 == 1)
        {
            _text6.text = "質問：あなたより低いですか？" + "\n" + na5 + ":〇";
        }
        else if (a5 == 5 && a41 == 1)
        {
            _text6.text = "質問：あなたより低いですか？" + "\n" + na5 + ":×";
        }
        else if (a5 == 6 && a40 == 1)
        {
            _text6.text = "質問：あなたより重いですか？" + "\n" + na5 + ":〇";
        }
        else if (a5 == 6 && a41 == 1)
        {
            _text6.text = "質問：あなたより重いですか？" + "\n" + na5 + ":×";
        }
        else if (a5 == 7 && a40 == 1)
        {
            _text6.text = "質問：あなたより軽いですか？" + "\n" + na5 + ":〇";
        }
        else if (a5 == 7 && a41 == 1)
        {
            _text6.text = "質問：あなたより軽いですか？" + "\n" + na5 + ":×";
        }


        if (a6 == 1 && a42 == 1)
        {
            _text7.text = "質問：服の色は黒ですか？" + "\n" + na6 + ":〇";
        }
        else if (a6 == 1 && a43 == 1)
        {
            _text7.text = "質問：服の色は黒ですか？" + "\n" + na6 + ":×";
        }
        else if (a6 == 2 && a42 == 1)
        {
            _text7.text = "質問：服の色は赤ですか？" + "\n" + na6 + ":〇";
        }
        else if (a6 == 2 && a43 == 1)
        {
            _text7.text = "質問：服の色は赤ですか？" + "\n" + na6 + ":×";
        }
        else if (a6 == 3 && a42 == 1)
        {
            _text7.text = "質問：服の色は白ですか？" + "\n" + na6 + ":〇";
        }
        else if (a6 == 3 && a43 == 1)
        {
            _text7.text = "質問：服の色は白ですか？" + "\n" + na6 + ":×";
        }
        else if (a6 == 4 && a42 == 1)
        {
            _text7.text = "質問：あなたより高いですか？" + "\n" + na6 + ":〇";
        }
        else if (a6 == 4 && a43 == 1)
        {
            _text7.text = "質問：あなたより高いですか？" + "\n" + na6 + ":×";
        }
        else if (a6 == 5 && a42 == 1)
        {
            _text7.text = "質問：あなたより低いですか？" + "\n" + na6 + ":〇";
        }
        else if (a6 == 5 && a43 == 1)
        {
            _text7.text = "質問：あなたより低いですか？" + "n\n" + na6 + ":×";
        }
        else if (a6 == 6 && a42 == 1)
        {
            _text7.text = "質問：あなたより重いですか？" + "\n" + na6 + ":〇";
        }
        else if (a6 == 6 && a43 == 1)
        {
            _text7.text = "質問：あなたより重いですか？" + "\n" + na6 + ":×";
        }
        else if (a6 == 7 && a42 == 1)
        {
            _text7.text = "質問：あなたより軽いですか？" + "\n" + na6 + ":〇";
        }
        else if (a6 == 7 && a43 == 1)
        {
            _text7.text = "質問：あなたより軽いですか？" + "\n" + na6 + ":×";
        }

        if (a7 == 1 && a44 == 1)
        {
            _text8.text = "質問：服の色は黒ですか？" + "\n" + na7 + ":〇";
        }
        else if (a7 == 1 && a45 == 1)
        {
            _text8.text = "質問：服の色は黒ですか？" + "\n" + na7 + ":×";
        }
        else if (a7 == 2 && a44 == 1)
        {
            _text8.text = "質問：服の色は赤ですか？" + "\n" + na7 + ":〇";
        }
        else if (a7 == 2 && a45 == 1)
        {
            _text8.text = "質問：服の色は赤ですか？" + "\n" + na7 + ":×";
        }
        else if (a7 == 3 && a44 == 1)
        {
            _text8.text = "質問：服の色は白ですか？" + "\n" + na7 + ":〇";
        }
        else if (a7 == 3 && a45 == 1)
        {
            _text8.text = "質問：服の色は白ですか？" + "\n" + na7 + ":×";
        }
        else if (a7 == 4 && a44 == 1)
        {
            _text8.text = "質問：あなたより高いですか？" + "\n" + na7 + ":〇";
        }
        else if (a7 == 4 && a45 == 1)
        {
            _text8.text = "質問：あなたより高いですか？" + "\n" + na7 + ":×";
        }
        else if (a7 == 5 && a44 == 1)
        {
            _text8.text = "質問：あなたより低いですか？" + "\n" + na7 + ":〇";
        }
        else if (a7 == 5 && a45 == 1)
        {
            _text8.text = "質問：あなたより低いですか？" + "\n" + na7 + ":×";
        }
        else if (a7 == 6 && a44 == 1)
        {
            _text8.text = "質問：あなたより重いですか？" + "\n" + na7 + ":〇";
        }
        else if (a7 == 6 && a45 == 1)
        {
            _text8.text = "質問：あなたより重いですか？" + "\n" + na7 + ":×";
        }
        else if (a7 == 7 && a44 == 1)
        {
            _text8.text = "質問：あなたより軽いですか？" + "\n" + na7 + ":〇";
        }
        else if (a7 == 7 && a45 == 1)
        {
            _text8.text = "質問：あなたより軽いですか？" + "\n" + na7 + ":×";
        }
        if (a8 == 1 && a46 == 1)
        {
            _text9.text = "質問：服の色は黒ですか？" + "\n" + na8 + ":〇";
        }
        else if (a8 == 1 && a47 == 1)
        {
            _text9.text = "質問：服の色は黒ですか？" + "\n" + na8 + ":×";
        }
        else if (a8 == 2 && a46 == 1)
        {
            _text9.text = "質問：服の色は赤ですか？" + "\n" + na8 + ":〇";
        }
        else if (a8 == 2 && a47 == 1)
        {
            _text9.text = "質問：服の色は赤ですか？" + "\n" + na8 + ":×";
        }
        else if (a8 == 3 && a46 == 1)
        {
            _text9.text = "質問：服の色は白ですか？" + "\n" + na8 + ":〇";
        }
        else if (a8 == 3 && a47 == 1)
        {
            _text9.text = "質問：服の色は白ですか？" + "\n" + na8 + ":×";
        }
        else if (a8 == 4 && a46 == 1)
        {
            _text9.text = "質問：あなたより高いですか？" + "\n" + na8 + ":〇";
        }
        else if (a8 == 4 && a47 == 1)
        {
            _text9.text = "質問：あなたより高いですか？" + "\n" + na8 + ":×";
        }
        else if (a8 == 5 && a46 == 1)
        {
            _text9.text = "質問：あなたより低いですか？" + "\n" + na8 + ":〇";
        }
        else if (a8 == 5 && a47 == 1)
        {
            _text9.text = "質問：あなたより低いですか？" + "\n" + na8 + ":×";
        }
        else if (a8 == 6 && a46 == 1)
        {
            _text9.text = "質問：あなたより重いですか？" + "\n" + na8 + ":〇";
        }
        else if (a8 == 6 && a47 == 1)
        {
            _text9.text = "質問：あなたより重いですか？" + "\n" + na8 + ":×";
        }
        else if (a8 == 7 && a46 == 1)
        {
            _text9.text = "質問：あなたより軽いですか？" + "\n" + na8 + ":〇";
        }
        else if (a8 == 7 && a47 == 1)
        {
            _text9.text = "質問：あなたより軽いですか？" + "\n" + na8 + ":×";
        }

        if (a9 == 1 && a48 == 1)
        {
            _text10.text = "質問：服の色は黒ですか？" + "\n" + na9 + ":〇";
        }
        else if (a9 == 1 && a49 == 1)
        {
            _text10.text = "質問：服の色は黒ですか？" + "\n" + na9 + ":×";
        }
        else if (a9 == 2 && a48 == 1)
        {
            _text10.text = "質問：服の色は赤ですか？" + "\n" + na9 + ":〇";
        }
        else if (a9 == 2 && a49 == 1)
        {
            _text10.text = "質問：服の色は赤ですか？" + "\n" + na9 + ":×";
        }
        else if (a9 == 3 && a48 == 1)
        {
            _text10.text = "質問：服の色は白ですか？" + "\n" + na9 + ":〇";
        }
        else if (a9 == 3 && a49 == 1)
        {
            _text10.text = "質問：服の色は白ですか？" + "\n" + na9 + ":×";
        }
        else if (a9 == 4 && a48 == 1)
        {
            _text10.text = "質問：あなたより高いですか？" + "\n" + na9 + ":〇";
        }
        else if (a9 == 4 && a49 == 1)
        {
            _text10.text = "質問：あなたより高いですか？" + "\n" + na9 + ":×";
        }
        else if (a9 == 5 && a48 == 1)
        {
            _text10.text = "質問：あなたより低いですか？" + "\n" + na9 + ":〇";
        }
        else if (a9 == 5 && a49 == 1)
        {
            _text10.text = "質問：あなたより低いですか？" + "n\n" + na9 + ":×";
        }
        else if (a9 == 6 && a48 == 1)
        {
            _text10.text = "質問：あなたより重いですか？" + "\n" + na9 + ":〇";
        }
        else if (a9 == 6 && a49 == 1)
        {
            _text10.text = "質問：あなたより重いですか？" + "\n" + na9 + ":×";
        }
        else if (a9 == 7 && a48 == 1)
        {
            _text10.text = "質問：あなたより軽いですか？" + "\n" + na9 + ":〇";
        }
        else if (a9 == 7 && a49 == 1)
        {
            _text10.text = "質問：あなたより軽いですか？" + "\n" + na9 + ":×";
        }

        if (a10 == 1 && a50 == 1)
        {
            _text11.text = "質問：服の色は黒ですか？" + "\n" + na10 + ":〇";
        }
        else if (a10 == 1 && a51 == 1)
        {
            _text11.text = "質問：服の色は黒ですか？" + "\n" + na10 + ":×";
        }
        else if (a10 == 2 && a50 == 1)
        {
            _text11.text = "質問：服の色は赤ですか？" + "\n" + na10 + ":〇";
        }
        else if (a10 == 2 && a51 == 1)
        {
            _text11.text = "質問：服の色は赤ですか？" + "\n" + na10 + ":×";
        }
        else if (a10 == 3 && a50 == 1)
        {
            _text11.text = "質問：服の色は白ですか？" + "\n" + na10 + ":〇";
        }
        else if (a10 == 3 && a51 == 1)
        {
            _text11.text = "質問：服の色は白ですか？" + "\n" + na10 + ":×";
        }
        else if (a10 == 4 && a50 == 1)
        {
            _text11.text = "質問：あなたより高いですか？" + "\n" + na10 + ":〇";
        }
        else if (a10 == 4 && a51 == 1)
        {
            _text11.text = "質問：あなたより高いですか？" + "\n" + na10 + ":×";
        }
        else if (a10 == 5 && a50 == 1)
        {
            _text11.text = "質問：あなたより低いですか？" + "\n" + na10 + ":〇";
        }
        else if (a10 == 5 && a51 == 1)
        {
            _text11.text = "質問：あなたより低いですか？" + "\n" + na10 + ":×";
        }
        else if (a10 == 6 && a50 == 1)
        {
            _text11.text = "質問：あなたより重いですか？" + "\n" + na10 + ":〇";
        }
        else if (a10 == 6 && a51 == 1)
        {
            _text11.text = "質問：あなたより重いですか？" + "\n" + na10 + ":×";
        }
        else if (a10 == 7 && a50 == 1)
        {
            _text11.text = "質問：あなたより軽いですか？" + "\n" + na10 + ":〇";
        }
        else if (a10 == 7 && a51 == 1)
        {
            _text11.text = "質問：あなたより軽いですか？" + "\n" + na10 + ":×";
        }
        if (a11 == 1 && a52 == 1)
        {
            _text12.text = "質問：服の色は黒ですか？" + "\n" + na11 + ":〇";
        }
        else if (a11 == 1 && a53 == 1)
        {
            _text12.text = "質問：服の色は黒ですか？" + "\n" + na11 + ":×";
        }
        else if (a11 == 2 && a52 == 1)
        {
            _text12.text = "質問：服の色は赤ですか？" + "\n" + na11 + ":〇";
        }
        else if (a11 == 2 && a53 == 1)
        {
            _text12.text = "質問：服の色は赤ですか？" + "\n" + na11 + ":×";
        }
        else if (a11 == 3 && a52 == 1)
        {
            _text12.text = "質問：服の色は白ですか？" + "\n" + na11 + ":〇";
        }
        else if (a11 == 3 && a53 == 1)
        {
            _text12.text = "質問：服の色は白ですか？" + "\n" + na11 + ":×";
        }
        else if (a11 == 4 && a52 == 1)
        {
            _text12.text = "質問：あなたより高いですか？" + "\n" + na11 + ":〇";
        }
        else if (a11 == 4 && a53 == 1)
        {
            _text12.text = "質問：あなたより高いですか？" + "\n" + na11 + ":×";
        }
        else if (a11 == 5 && a52 == 1)
        {
            _text12.text = "質問：あなたより低いですか？" + "\n" + na11 + ":〇";
        }
        else if (a11 == 5 && a53 == 1)
        {
            _text12.text = "質問：あなたより低いですか？" + "\n" + na11 + ":×";
        }
        else if (a11 == 6 && a52 == 1)
        {
            _text12.text = "質問：あなたより重いですか？" + "\n" + na11 + ":〇";
        }
        else if (a11 == 6 && a53 == 1)
        {
            _text12.text = "質問：あなたより重いですか？" + "\n" + na11 + ":×";
        }
        else if (a11 == 7 && a52 == 1)
        {
            _text12.text = "質問：あなたより軽いですか？" + "\n" + na11 + ":〇";
        }
        else if (a11 == 7 && a53 == 1)
        {
            _text12.text = "質問：あなたより軽いですか？" + "\n" + na11 + ":×";
        }

        if (a12 == 1 && a54 == 1)
        {
            _text13.text = "質問：服の色は黒ですか？" + "\n" + na12 + ":〇";
        }
        else if (a12 == 1 && a55 == 1)
        {
            _text13.text = "質問：服の色は黒ですか？" + "\n" + na12 + ":×";
        }
        else if (a12 == 2 && a54 == 1)
        {
            _text13.text = "質問：服の色は赤ですか？" + "\n" + na12 + ":〇";
        }
        else if (a12 == 2 && a55 == 1)
        {
            _text13.text = "質問：服の色は赤ですか？" + "\n" + na12 + ":×";
        }
        else if (a12 == 3 && a54 == 1)
        {
            _text13.text = "質問：服の色は白ですか？" + "\n" + na12 + ":〇";
        }
        else if (a12 == 3 && a55 == 1)
        {
            _text13.text = "質問：服の色は白ですか？" + "\n" + na12 + ":×";
        }
        else if (a12 == 4 && a54 == 1)
        {
            _text13.text = "質問：あなたより高いですか？" + "\n" + na12 + ":〇";
        }
        else if (a12 == 4 && a55 == 1)
        {
            _text13.text = "質問：あなたより高いですか？" + "\n" + na12 + ":×";
        }
        else if (a12 == 5 && a54 == 1)
        {
            _text13.text = "質問：あなたより低いですか？" + "\n" + na12 + ":〇";
        }
        else if (a12 == 5 && a55 == 1)
        {
            _text13.text = "質問：あなたより低いですか？" + "\n" + na12 + ":×";
        }
        else if (a12 == 6 && a54 == 1)
        {
            _text13.text = "質問：あなたより重いですか？" + "\n" + na12 + ":〇";
        }
        else if (a12 == 6 && a55 == 1)
        {
            _text13.text = "質問：あなたより重いですか？" + "\n" + na12 + ":×";
        }
        else if (a12 == 7 && a54 == 1)
        {
            _text13.text = "質問：あなたより軽いですか？" + "\n" + na12 + ":〇";
        }
        else if (a12 == 7 && a55 == 1)
        {
            _text13.text = "質問：あなたより軽いですか？" + "\n" + na12 + ":×";
        }


        if (a13 == 1 && a56 == 1)
        {
            _text14.text = "質問：服の色は黒ですか？" + "\n" + na13 + ":〇";

        }
        else if (a13 == 1 && a57 == 1)
        {
            _text14.text = "質問：服の色は黒ですか？" + "\n" + na13 + ":×";
        }
        else if (a13 == 2 && a56 == 1)
        {
            _text14.text = "質問：服の色は赤ですか？" + "\n" + na13 + ":〇";
        }
        else if (a13 == 2 && a57 == 1)
        {
            _text14.text = "質問：服の色は赤ですか？" + "\n" + na13 + ":×";
        }
        else if (a13 == 3 && a56 == 1)
        {
            _text14.text = "質問：服の色は白ですか？" + "\n" + na13 + ":〇";
        }
        else if (a13 == 3 && a57 == 1)
        {
            _text14.text = "質問：服の色は白ですか？" + "\n" + na13 + ":×";
        }
        else if (a13 == 4 && a56 == 1)
        {
            _text14.text = "質問：あなたより高いですか？" + "\n" + na13 + ":〇";
        }
        else if (a13 == 4 && a57 == 1)
        {
            _text14.text = "質問：あなたより高いですか？" + "\n" + na13 + ":×";
        }
        else if (a13 == 5 && a56 == 1)
        {
            _text14.text = "質問：あなたより低いですか？" + "\n" + na13 + ":〇";
        }
        else if (a13 == 5 && a57 == 1)
        {
            _text14.text = "質問：あなたより低いですか？" + "\n" + na13 + ":×";
        }
        else if (a13 == 6 && a56 == 1)
        {
            _text14.text = "質問：あなたより重いですか？" + "\n" + na13 + ":〇";
        }
        else if (a13 == 6 && a57 == 1)
        {
            _text14.text = "質問：あなたより重いですか？" + "\n" + na13 + ":×";
        }
        else if (a13 == 7 && a56 == 1)
        {
            _text14.text = "質問：あなたより軽いですか？" + "\n" + na13 + ":〇";
        }
        else if (a13 == 7 && a57 == 1)
        {
            _text14.text = "質問：あなたより軽いですか？" + "\n" + na13 + ":×";
        }


        if (a14 == 1 && a58 == 1)
        {
            _text15.text = "質問：服の色は黒ですか？" + "\n" + na14 + ":〇";
        }
        else if (a14 == 1 && a59 == 1)
        {
            _text15.text = "質問：服の色は黒ですか？" + "\n" + na14 + ":×";
        }
        else if (a14 == 2 && a58 == 1)
        {
            _text15.text = "質問：服の色は赤ですか？" + "\n" + na14 + ":〇";
        }
        else if (a14 == 2 && a59 == 1)
        {
            _text15.text = "質問：服の色は赤ですか？" + "\n" + na14 + ":×";
        }
        else if (a14 == 3 && a58 == 1)
        {
            _text15.text = "質問：服の色は白ですか？" + "\n" + na14 + ":〇";
        }
        else if (a14 == 3 && a59 == 1)
        {
            _text15.text = "質問：服の色は白ですか？" + "\n" + na14 + ":×";
        }
        else if (a14 == 4 && a58 == 1)
        {
            _text15.text = "質問：あなたより高いですか？" + "\n" + na14 + ":〇";
        }
        else if (a14 == 4 && a59 == 1)
        {
            _text15.text = "質問：あなたより高いですか？" + "\n" + na14 + ":×";
        }
        else if (a14 == 5 && a58 == 1)
        {
            _text15.text = "質問：あなたより低いですか？" + "\n" + na14 + ":〇";
        }
        else if (a14 == 5 && a59 == 1)
        {
            _text15.text = "質問：あなたより低いですか？" + "n\n" + na14 + ":×";
        }
        else if (a14 == 6 && a58 == 1)
        {
            _text15.text = "質問：あなたより重いですか？" + "\n" + na14 + ":〇";
        }
        else if (a14 == 6 && a59 == 1)
        {
            _text15.text = "質問：あなたより重いですか？" + "\n" + na14 + ":×";
        }
        else if (a14 == 7 && a58 == 1)
        {
            _text15.text = "質問：あなたより軽いですか？" + "\n" + na14 + ":〇";
        }
        else if (a14 == 7 && a59 == 1)
        {
            _text15.text = "質問：あなたより軽いですか？" + "\n" + na14 + ":×";
        }

        if (a15 == 1 && a60 == 1)
        {
            _text16.text = "質問：服の色は黒ですか？" + "\n" + na15 + ":〇";
        }
        else if (a15 == 1 && a61 == 1)
        {
            _text16.text = "質問：服の色は黒ですか？" + "\n" + na15 + ":×";
        }
        else if (a15 == 2 && a60 == 1)
        {
            _text16.text = "質問：服の色は赤ですか？" + "\n" + na15 + ":〇";
        }
        else if (a15 == 2 && a61 == 1)
        {
            _text16.text = "質問：服の色は赤ですか？" + "\n" + na15 + ":×";
        }
        else if (a15 == 3 && a60 == 1)
        {
            _text16.text = "質問：服の色は白ですか？" + "\n" + na15 + ":〇";
        }
        else if (a15 == 3 && a61 == 1)
        {
            _text16.text = "質問：服の色は白ですか？" + "\n" + na15 + ":×";
        }
        else if (a15 == 4 && a60 == 1)
        {
            _text16.text = "質問：あなたより高いですか？" + "\n" + na15 + ":〇";
        }
        else if (a15 == 4 && a61 == 1)
        {
            _text16.text = "質問：あなたより高いですか？" + "\n" + na15 + ":×";
        }
        else if (a15 == 5 && a60 == 1)
        {
            _text16.text = "質問：あなたより低いですか？" + "\n" + na15 + ":〇";
        }
        else if (a15 == 5 && a61 == 1)
        {
            _text16.text = "質問：あなたより低いですか？" + "\n" + na15 + ":×";
        }
        else if (a15 == 6 && a60 == 1)
        {
            _text16.text = "質問：あなたより重いですか？" + "\n" + na15 + ":〇";
        }
        else if (a15 == 6 && a61 == 1)
        {
            _text16.text = "質問：あなたより重いですか？" + "\n" + na15 + ":×";
        }
        else if (a15 == 7 && a60 == 1)
        {
            _text16.text = "質問：あなたより軽いですか？" + "\n" + na15 + ":〇";
        }
        else if (a15 == 7 && a61 == 1)
        {
            _text16.text = "質問：あなたより軽いですか？" + "\n" + na15 + ":×";
        }
        if (a16 == 1 && a62 == 1)
        {
            _text17.text = "質問：服の色は黒ですか？" + "\n" + na16 + ":〇";
        }
        else if (a16 == 1 && a63 == 1)
        {
            _text17.text = "質問：服の色は黒ですか？" + "\n" + na16 + ":×";
        }
        else if (a16 == 2 && a62 == 1)
        {
            _text17.text = "質問：服の色は赤ですか？" + "\n" + na16 + ":〇";
        }
        else if (a16 == 2 && a63 == 1)
        {
            _text17.text = "質問：服の色は赤ですか？" + "\n" + na16 + ":×";
        }
        else if (a16 == 3 && a62 == 1)
        {
            _text17.text = "質問：服の色は白ですか？" + "\n" + na16 + ":〇";
        }
        else if (a16 == 3 && a63 == 1)
        {
            _text17.text = "質問：服の色は白ですか？" + "\n" + na16 + ":×";
        }
        else if (a16 == 4 && a62 == 1)
        {
            _text17.text = "質問：あなたより高いですか？" + "\n" + na16 + ":〇";
        }
        else if (a16 == 4 && a63 == 1)
        {
            _text17.text = "質問：あなたより高いですか？" + "\n" + na16 + ":×";
        }
        else if (a16 == 5 && a62 == 1)
        {
            _text17.text = "質問：あなたより低いですか？" + "\n" + na16 + ":〇";
        }
        else if (a16 == 5 && a63 == 1)
        {
            _text17.text = "質問：あなたより低いですか？" + "\n" + na16 + ":×";
        }
        else if (a16 == 6 && a62 == 1)
        {
            _text17.text = "質問：あなたより重いですか？" + "\n" + na16 + ":〇";
        }
        else if (a16 == 6 && a63 == 1)
        {
            _text17.text = "質問：あなたより重いですか？" + "\n" + na16 + ":×";
        }
        else if (a16 == 7 && a62 == 1)
        {
            _text17.text = "質問：あなたより軽いですか？" + "\n" + na16 + ":〇";
        }
        else if (a16 == 7 && a63 == 1)
        {
            _text17.text = "質問：あなたより軽いですか？" + "\n" + na16 + ":×";
        }


    }


}


