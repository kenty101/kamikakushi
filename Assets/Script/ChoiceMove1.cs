using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class ChoiceMove1 : MonoBehaviour
{
    public GameObject[] rooms;
    public GameObject panelfade;
    public GameObject Day;
    public GameObject[] Qestions;
    public GameObject[] Qestions2;
    public GameObject[] characters;
    public GameObject[] Nos;
    public GameObject[] Yess;
    public GameObject[] Questions;
    public GameObject BlackPanel;
    public GameObject own;
    public GameObject[] Meibos;
    public GameObject Over;
    public GameObject Clear;
    public GameObject set;
    public GameObject close;
    public GameObject[] Images;
    public GameObject[] uns;
    public GameObject[] iyas;
    public GameObject[]Open;
    public GameObject kakunin;
    public GameObject[] kao;
    [SerializeField] AudioClip aclip;
    [SerializeField] AudioClip bclip;
    [SerializeField] AudioClip cclip;
    [SerializeField] AudioClip dclip;
    [SerializeField] AudioClip eclip;
    [SerializeField] AudioClip fclip;
    [SerializeField] AudioClip gclip;
    [SerializeField] AudioClip hclip;
    [SerializeField] AudioClip iclip;
    [SerializeField] AudioClip jclip;
    [SerializeField] AudioClip kclip;



    SoundManager soundManager;
    Count count;
    Black black;
    Tarou tarou;
    Timer timer;
    Memory memory;
 
    public int a = 0;
    public int b = 2;
    public int c = 0;
    public int d = 1;
    public int e = 0;
    public int f = 1;
    public int g = 2;
    public int h = 3;
    public int i = 4;
    public int j = 5;
    public int k = 6;
    public int L = 173;
    public int N = 70;
    public int M = 0;





    void Start()
    {
        count = GameObject.Find("Numbers").GetComponent<Count>();
        black = GameObject.Find("Blackout").GetComponent<Black>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        memory = GameObject.Find("Textmemo").GetComponent<Memory>();
    }
    public void hiraku()
    {
        soundManager.PlaySe(aclip);

        Open[0].SetActive(true);
        Open[1].SetActive(true);

    }
    public void hiraku1()
    {
        soundManager.PlaySe(aclip);
        Open[1].SetActive(false);

        Open[2].SetActive(true);

    }
    public void hiraku2()
    {
        soundManager.PlaySe(aclip);
        Open[2].SetActive(false);

        Open[3].SetActive(true);

    }
    public void hiraku3()
    {
        soundManager.PlaySe(aclip);
        Open[3].SetActive(false);

        Open[4].SetActive(true);


    }
    public void hiraku4()
    {
        soundManager.PlaySe(aclip);

        Open[2].SetActive(false);
        Open[0].SetActive(false);



    }
    public void shimeru()
    {
        soundManager.PlaySe(aclip);

        Open[0].SetActive(false);


    }
    public void shimeru1()
    {
        soundManager.PlaySe(aclip);

        Open[2].SetActive(false);
        Open[1].SetActive(true);

    }
    public void shimeru2()
    {
        soundManager.PlaySe(aclip);

        Open[3].SetActive(false);
        Open[2].SetActive(true);

    }
    public void shimeru4()
    {
        soundManager.PlaySe(aclip);

        Open[4].SetActive(false);
        Open[3].SetActive(true);

    }
    public void modoru1()
    {
        rooms[2].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru2()
    {
        rooms[3].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru3()
    {
        rooms[4].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru4()
    {
        rooms[5].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru5()
    {
        rooms[6].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru6()
    {
        rooms[7].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru7()
    {
        rooms[8].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru8()
    {
        rooms[9].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru9()
    {
        rooms[10].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru10()
    {
        rooms[11].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru11()
    {
        rooms[12].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru12()
    {
        rooms[13].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru13()
    {
        rooms[14].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru14()
    {
        rooms[15].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru15()
    {
        rooms[16].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru16()
    {
        rooms[17].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru17()
    {
        rooms[18].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru18()
    {
        rooms[19].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru19()
    {
        rooms[20].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru20()
    {
        rooms[21].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru21()
    {
        rooms[22].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru22()
    {
        rooms[23].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru23()
    {
        rooms[24].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru24()
    {
        rooms[25].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru25()
    {
        rooms[26].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru26()
    {
        rooms[27].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru27()
    {
        rooms[28].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru28()
    {
        rooms[29].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru29()
    {
        rooms[30].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void modoru30()
    {
        rooms[31].SetActive(false);
        soundManager.PlaySe(bclip);
        soundManager.PlayBgm(cclip);
        Day.SetActive(false);
        rooms[1].SetActive(true);
    }
    public void confirmation()
    {
        kakunin.SetActive(true);
        Images[0].SetActive(true);
        uns[0].SetActive(true);
        iyas[0].SetActive(true);
    }
    public void miss()
    {
        kakunin.SetActive(false);
        Images[0].SetActive(false);
        uns[0].SetActive(false);
        iyas[0].SetActive(false);
    }
    public void confirmation1()
    {
        kakunin.SetActive(true);
        Images[1].SetActive(true);
        uns[1].SetActive(true);
        iyas[1].SetActive(true);
    }
    public void miss1()
    {
        kakunin.SetActive(false);
        Images[1].SetActive(false);
        uns[1].SetActive(false);
        iyas[1].SetActive(false);
    }
    public void confirmation2()
    {
        kakunin.SetActive(true);
        Images[2].SetActive(true);
        uns[2].SetActive(true);
        iyas[2].SetActive(true);
    }
    public void miss2()
    {
        kakunin.SetActive(false);
        Images[2].SetActive(false);
        uns[2].SetActive(false);
        iyas[2].SetActive(false);
    }
    public void confirmation3()
    {
        kakunin.SetActive(true);
        Images[3].SetActive(true);
        uns[3].SetActive(true);
        iyas[3].SetActive(true);
    }
    public void miss3()
    {
        kakunin.SetActive(false);
        Images[3].SetActive(false);
        uns[3].SetActive(false);
        iyas[3].SetActive(false);
    }
    public void confirmation4()
    {
        kakunin.SetActive(true);
        Images[4].SetActive(true);
        uns[4].SetActive(true);
        iyas[4].SetActive(true);
    }
    public void miss4()
    {
        kakunin.SetActive(false);
        Images[4].SetActive(false);
        uns[4].SetActive(false);
        iyas[4].SetActive(false);
    }
    public void confirmation5()
    {
        kakunin.SetActive(true);
        Images[5].SetActive(true);
        uns[5].SetActive(true);
        iyas[5].SetActive(true);
    }
    public void miss5()
    {
        kakunin.SetActive(false);
        Images[5].SetActive(false);
        uns[5].SetActive(false);
        iyas[5].SetActive(false);
    }
    public void confirmation6()
    {
        kakunin.SetActive(true);
        Images[6].SetActive(true);
        uns[6].SetActive(true);
        iyas[6].SetActive(true);
    }
    public void miss6()
    {
        kakunin.SetActive(false);
        Images[6].SetActive(false);
        uns[6].SetActive(false);
        iyas[6].SetActive(false);
    }
    public void confirmation7()
    {
        kakunin.SetActive(true);
        Images[7].SetActive(true);
        uns[7].SetActive(true);
        iyas[7].SetActive(true);
    }
    public void miss7()
    {
        kakunin.SetActive(false);
        Images[7].SetActive(false);
        uns[7].SetActive(false);
        iyas[7].SetActive(false);
    }
    public void confirmation8()
    {
        kakunin.SetActive(true);
        Images[8].SetActive(true);
        uns[8].SetActive(true);
        iyas[8].SetActive(true);
    }
    public void miss8()
    {
        kakunin.SetActive(false);
        Images[8].SetActive(false);
        uns[8].SetActive(false);
        iyas[8].SetActive(false);
    }
    public void confirmation9()
    {
        kakunin.SetActive(true);
        Images[9].SetActive(true);
        uns[9].SetActive(true);
        iyas[9].SetActive(true);
    }
    public void miss9()
    {
        kakunin.SetActive(false);
        Images[9].SetActive(false);
        uns[9].SetActive(false);
        iyas[9].SetActive(false);
    }
    public void confirmation10()
    {
        kakunin.SetActive(true);
        Images[10].SetActive(true);
        uns[10].SetActive(true);
        iyas[10].SetActive(true);
    }
    public void miss10()
    {
        kakunin.SetActive(false);
        Images[10].SetActive(false);
        uns[10].SetActive(false);
        iyas[10].SetActive(false);
    }
    public void confirmation11()
    {
        kakunin.SetActive(true);
        Images[11].SetActive(true);
        uns[11].SetActive(true);
        iyas[11].SetActive(true);
    }
    public void miss11()
    {
        kakunin.SetActive(false);
        Images[11].SetActive(false);
        uns[11].SetActive(false);
        iyas[11].SetActive(false);
    }
    public void confirmation12()
    {
        kakunin.SetActive(true);
        Images[12].SetActive(true);
        uns[12].SetActive(true);
        iyas[12].SetActive(true);
    }
    public void miss12()
    {
        kakunin.SetActive(false);
        Images[12].SetActive(false);
        uns[12].SetActive(false);
        iyas[12].SetActive(false);
    }
    public void confirmation13()
    {
        kakunin.SetActive(true);
        Images[13].SetActive(true);
        uns[13].SetActive(true);
        iyas[13].SetActive(true);
    }
    public void miss13()
    {
        kakunin.SetActive(false);
        Images[13].SetActive(false);
        uns[13].SetActive(false);
        iyas[13].SetActive(false);
    }
    public void confirmation14()
    {
        kakunin.SetActive(true);
        Images[14].SetActive(true);
        uns[14].SetActive(true);
        iyas[14].SetActive(true);
    }
    public void miss14()
    {
        kakunin.SetActive(false);
        Images[14].SetActive(false);
        uns[14].SetActive(false);
        iyas[14].SetActive(false);
    }
    public void confirmation15()
    {
        kakunin.SetActive(true);
        Images[15].SetActive(true);
        uns[15].SetActive(true);
        iyas[15].SetActive(true);
    }
    public void miss15()
    {
        kakunin.SetActive(false);
        Images[15].SetActive(false);
        uns[15].SetActive(false);
        iyas[15].SetActive(false);
    }
    public void confirmation16()
    {
        kakunin.SetActive(true);
        Images[16].SetActive(true);
        uns[16].SetActive(true);
        iyas[16].SetActive(true);
    }
    public void miss16()
    {
        kakunin.SetActive(false);
        Images[16].SetActive(false);
        uns[16].SetActive(false);
        iyas[16].SetActive(false);
    }
    public void confirmation17()
    {
        kakunin.SetActive(true);
        Images[17].SetActive(true);
        uns[17].SetActive(true);
        iyas[17].SetActive(true);
    }
    public void miss17()
    {
        kakunin.SetActive(false);
        Images[17].SetActive(false);
        uns[17].SetActive(false);
        iyas[17].SetActive(false);
    }
    public void confirmation18()
    {
        kakunin.SetActive(true);
        Images[18].SetActive(true);
        uns[18].SetActive(true);
        iyas[18].SetActive(true);
    }
    public void miss18()
    {
        kakunin.SetActive(false);
        Images[18].SetActive(false);
        uns[18].SetActive(false);
        iyas[18].SetActive(false);
    }
    public void confirmation19()
    {
        kakunin.SetActive(true);
        Images[19].SetActive(true);
        uns[19].SetActive(true);
        iyas[19].SetActive(true);
    }
    public void miss19()
    {
        kakunin.SetActive(false);
        Images[19].SetActive(false);
        uns[19].SetActive(false);
        iyas[19].SetActive(false);
    }
    public void confirmation20()
    {
        kakunin.SetActive(true);
        Images[20].SetActive(true);
        uns[20].SetActive(true);
        iyas[20].SetActive(true);
    }
    public void miss20()
    {
        kakunin.SetActive(false);
        Images[20].SetActive(false);
        uns[20].SetActive(false);
        iyas[20].SetActive(false);
    }
    public void confirmation21()
    {
        kakunin.SetActive(true);
        Images[21].SetActive(true);
        uns[21].SetActive(true);
        iyas[21].SetActive(true);
    }
    public void miss21()
    {
        kakunin.SetActive(false);
        Images[21].SetActive(false);
        uns[21].SetActive(false);
        iyas[21].SetActive(false);
    }
    public void confirmation22()
    {
        kakunin.SetActive(true);
        Images[22].SetActive(true);
        uns[22].SetActive(true);
        iyas[22].SetActive(true);
    }
    public void miss22()
    {
        kakunin.SetActive(false);
        Images[22].SetActive(false);
        uns[22].SetActive(false);
        iyas[22].SetActive(false);
    }
    public void confirmation23()
    {
        kakunin.SetActive(true);
        Images[23].SetActive(true);
        uns[23].SetActive(true);
        iyas[23].SetActive(true);
    }
    public void miss23()
    {
        kakunin.SetActive(false);
        Images[23].SetActive(false);
        uns[23].SetActive(false);
        iyas[23].SetActive(false);
    }
    public void confirmation24()
    {
        kakunin.SetActive(true);
        Images[24].SetActive(true);
        uns[24].SetActive(true);
        iyas[24].SetActive(true);
    }
    public void miss24()
    {
        kakunin.SetActive(false);
        Images[24].SetActive(false);
        uns[24].SetActive(false);
        iyas[24].SetActive(false);
    }
    public void confirmation25()
    {
        kakunin.SetActive(true);
        Images[25].SetActive(true);
        uns[25].SetActive(true);
        iyas[25].SetActive(true);
    }
    public void miss25()
    {
        kakunin.SetActive(false);
        Images[25].SetActive(false);
        uns[25].SetActive(false);
        iyas[25].SetActive(false);
    }
    public void confirmation26()
    {
        kakunin.SetActive(true);
        Images[26].SetActive(true);
        uns[26].SetActive(true);
        iyas[26].SetActive(true);
    }
    public void miss26()
    {
        kakunin.SetActive(false);
        Images[26].SetActive(false);
        uns[26].SetActive(false);
        iyas[26].SetActive(false);
    }
    public void confirmation27()
    {
        kakunin.SetActive(true);
        Images[27].SetActive(true);
        uns[27].SetActive(true);
        iyas[27].SetActive(true);
    }
    public void miss27()
    {
        kakunin.SetActive(false);
        Images[27].SetActive(false);
        uns[27].SetActive(false);
        iyas[27].SetActive(false);
    }
    public void confirmation28()
    {
        kakunin.SetActive(true);
        Images[28].SetActive(true);
        uns[28].SetActive(true);
        iyas[28].SetActive(true);
    }
    public void miss28()
    {
        kakunin.SetActive(false);
        Images[28].SetActive(false);
        uns[28].SetActive(false);
        iyas[28].SetActive(false);
    }
    public void confirmation29()
    {
        kakunin.SetActive(true);
        Images[29].SetActive(true);
        uns[29].SetActive(true);
        iyas[29].SetActive(true);
    }
    public void miss29()
    {
        kakunin.SetActive(false);
        Images[29].SetActive(false);
        uns[29].SetActive(false);
        iyas[29].SetActive(false);
    }


    public void On()
    {
        soundManager.PlaySe(eclip);

        set.SetActive(true);
    }
    public void Off()
    {
        soundManager.PlaySe(eclip);

        set.SetActive(false);
    }
    public void open()
    {
        soundManager.PlaySe(aclip);

        close.SetActive(true);
    }
    public void  offback()
    {
        soundManager.PlaySe(aclip);

        close.SetActive(false);
    }
    public void Back()
    {
        soundManager.PlaySe(bclip);


        rooms[0].SetActive(true);

        rooms[1].SetActive(false);
        Day.SetActive(true);
    }
    public void Back1()
    {
        soundManager.PlaySe(aclip);


        rooms[34].SetActive(false);
    }
    public void MeiboBack()
    {
        soundManager.PlaySe(aclip);


        Meibos[0].SetActive(false);
        rooms[34].SetActive(true);

    }
    public void MeiboBack1()
    {
        soundManager.PlaySe(aclip);


        Meibos[1].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack2()
    {
        soundManager.PlaySe(aclip);


        Meibos[2].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack3()
    {
        soundManager.PlaySe(aclip);


        Meibos[3].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack4()
    {
        soundManager.PlaySe(aclip);


        Meibos[4].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack5()
    {
        soundManager.PlaySe(aclip);


        Meibos[5].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack6()
    {
        soundManager.PlaySe(aclip);


        Meibos[6].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack7()
    {
        soundManager.PlaySe(aclip);


        Meibos[7].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack8()
    {

        soundManager.PlaySe(aclip);

        Meibos[8].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack9()
    {
        soundManager.PlaySe(aclip);


        Meibos[9].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack10()
    {
        soundManager.PlaySe(aclip);


        Meibos[10].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack11()
    {
        soundManager.PlaySe(aclip);


        Meibos[11].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack12()
    {
        soundManager.PlaySe(aclip);


        Meibos[12].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack13()
    {
        soundManager.PlaySe(aclip);


        Meibos[13].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack14()
    {
        soundManager.PlaySe(aclip);


        Meibos[14].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack15()
    {
        soundManager.PlaySe(aclip);


        Meibos[15].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack16()
    {
        soundManager.PlaySe(aclip);


        Meibos[16].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack17()
    {
        soundManager.PlaySe(aclip);


        Meibos[17].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack18()
    {

        soundManager.PlaySe(aclip);

        Meibos[18].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack19()
    {
        soundManager.PlaySe(aclip);


        Meibos[19].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack20()
    {
        soundManager.PlaySe(aclip);


        Meibos[20].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack21()
    {
        soundManager.PlaySe(aclip);


        Meibos[21].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack22()
    {
        soundManager.PlaySe(aclip);


        Meibos[22].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack23()
    {
        soundManager.PlaySe(aclip);


        Meibos[23].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack24()
    {
        soundManager.PlaySe(aclip);


        Meibos[24].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack25()
    {
        soundManager.PlaySe(aclip);


        Meibos[25].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack26()
    {
        soundManager.PlaySe(aclip);


        Meibos[26].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack27()
    {
        soundManager.PlaySe(aclip);


        Meibos[27].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack28()
    {

        soundManager.PlaySe(aclip);

        Meibos[28].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboBack29()
    {
        soundManager.PlaySe(aclip);


        Meibos[29].SetActive(false);
        rooms[34].SetActive(true);
    }
    public void MeiboGo0()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(true);
     
    }
    public void MeiboGo()
    {
        soundManager.PlaySe(aclip);

        Meibos[0].SetActive(true);
        rooms[34].SetActive(false);

    }
    public void MeiboGo1()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[1].SetActive(true);
    }
    public void MeiboGo2()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[2].SetActive(true);
    }
    public void MeiboGo3()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[3].SetActive(true);
    }
    public void MeiboGo4()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[4].SetActive(true);
    }
    public void MeiboGo5()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[5].SetActive(true);
    }
    public void MeiboGo6()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[6].SetActive(true);
    }
    public void MeiboGo7()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[7].SetActive(true);
    }
    public void MeiboGo8()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[8].SetActive(true);
    }
    public void MeiboGo9()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[9].SetActive(true);
    }
    public void MeiboGo10()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[10].SetActive(true);
    }
    public void MeiboGo11()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[11].SetActive(true);
    }
    public void MeiboGo12()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[12].SetActive(true);
    }
    public void MeiboGo13()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[13].SetActive(true);
    }
    public void MeiboGo14()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[14].SetActive(true);
    }
    public void MeiboGo15()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[15].SetActive(true);
    }
    public void MeiboGo16()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[16].SetActive(true);
    }
    public void MeiboGo17()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[17].SetActive(true);
    }
    public void MeiboGo18()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[18].SetActive(true);
    }
    public void MeiboGo19()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[19].SetActive(true);
    }
    public void Move(string direction)
    {
        rooms[0].SetActive(false);
        if (direction == "right")
        {
            Day.SetActive(false);
        }
        soundManager.PlaySe(bclip);

        rooms[1].SetActive(true);
    }
    public void MeiboGo20()
    {
        soundManager.PlaySe(aclip);

        Meibos[20].SetActive(true);
        rooms[34].SetActive(false);

    }
    public void MeiboGo21()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[21].SetActive(true);
    }
    public void MeiboGo22()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[22].SetActive(true);
    }
    public void MeiboGo23()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[23].SetActive(true);
    }
    public void MeiboGo24()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[24].SetActive(true);
    }
    public void MeiboGo25()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[25].SetActive(true);
    }
    public void MeiboGo26()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[26].SetActive(true);
    }
    public void MeiboGo27()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[27].SetActive(true);
    }
    public void MeiboGo28()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[28].SetActive(true);
    }
    public void MeiboGo29()
    {
        soundManager.PlaySe(aclip);

        rooms[34].SetActive(false);
        Meibos[29].SetActive(true);
    }


    public void Qestion(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);

        if (direction == "Qestion")
        {
            Day.SetActive(true);
        }
        rooms[2].SetActive(true);

    }

    public void Qestion1(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion1")
        {
            Day.SetActive(true);

        }

  
        rooms[3].SetActive(true);

    }
    public void Qestion2(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion2")
        {
            Day.SetActive(true);

        }
  
        rooms[4].SetActive(true);
     
    }
    public void Qestion3(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion3")
        {
            Day.SetActive(true);

        }
   
        rooms[5].SetActive(true);
    
    }
    public void Qestion5(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion5")
        {
            Day.SetActive(true);

        }

        rooms[6].SetActive(true);
  
    }
    public void Qestion9(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion9")
        {
            Day.SetActive(true);

        }
  
        rooms[10].SetActive(true);
 
    }
    public void Qestion10(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion10")
        {
            Day.SetActive(true);

        }
   
        rooms[11].SetActive(true);
       
    }
    public void Qestion6(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion6")
        {
            Day.SetActive(true);

        }

        rooms[7].SetActive(true);
 
    }
    public void Qestion7(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion7")
        {
            Day.SetActive(true);

        }

        rooms[8].SetActive(true);
     
    }
    public void Qestion8(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion8")
        {
            Day.SetActive(true);

        }
 
        rooms[9].SetActive(true);
   
    }

    public void Qestion11(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);

        if (direction == "Qestion11")
        {
            Day.SetActive(true);
        }
        rooms[12].SetActive(true);

    }

    public void Qestion12(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion12")
        {
            Day.SetActive(true);

        }

        rooms[13].SetActive(true);

    }
    public void Qestion13(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion13")
        {
            Day.SetActive(true);

        }

        rooms[14].SetActive(true);
    
    }
    public void Qestion14(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion14")
        {
            Day.SetActive(true);

        }

        rooms[15].SetActive(true);
 
    }
    public void Qestion15(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion15")
        {
            Day.SetActive(true);

        }

        rooms[16].SetActive(true);
     
    }
    public void Qestion16(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion16")
        {
            Day.SetActive(true);

        }

        rooms[17].SetActive(true);
    
    }
    public void Qestion17(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion17")
        {
            Day.SetActive(true);

        }

        rooms[18].SetActive(true);
     
    }
    public void Qestion19(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion19")
        {
            Day.SetActive(true);

        }
 
        rooms[20].SetActive(true);
   
    }
    public void Qestion20(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion20")
        {
            Day.SetActive(true);

        }

        rooms[21].SetActive(true);
      
    }
    public void Qestion18(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion18")
        {
            Day.SetActive(true);

        }

        rooms[19].SetActive(true);

    }
    public void Qestion21(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);

        if (direction == "Qestion21")
        {
            Day.SetActive(true);
        }
        rooms[22].SetActive(true);

    }

    public void Qestion22(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion22")
        {
            Day.SetActive(true);

        }

        rooms[23].SetActive(true);

    }
    public void Qestion23(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion23")
        {
            Day.SetActive(true);

        }

        rooms[24].SetActive(true);

    }
    public void Qestion24(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion24")
        {
            Day.SetActive(true);

        }

        rooms[25].SetActive(true);
 
    }
    public void Qestion25(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion25")
        {
            Day.SetActive(true);

        }
 
        rooms[26].SetActive(true);
 
    }
    public void Qestion26(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion26")
        {
            Day.SetActive(true);

        }

        rooms[27].SetActive(true);

    }
    public void Qestion27(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion27")
        {
            Day.SetActive(true);

        }

        rooms[28].SetActive(true);

    }
    public void Qestion29(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion29")
        {
            Day.SetActive(true);

        }

        rooms[30].SetActive(true);

    }
    public void Qestion30(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion30")
        {
            Day.SetActive(true);

        }

        rooms[31].SetActive(true);

    }
    public void Qestion28(string direction)
    {
        rooms[1].SetActive(false);
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(dclip);
        if (direction == "Qestion28")
        {
            Day.SetActive(true);

        }
   
        rooms[29].SetActive(true);

    }
    public void Black()
    {

        GameObject God = GameObject.FindWithTag("God");
        
        GameObject Believer = GameObject.FindWithTag("Believer");
            GameObject Beliver2 = GameObject.FindWithTag("Beliver2");

        tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
        soundManager.PlaySe(eclip);

        if (tarou.b == "Black")            
        {
           if(Believer == characters[a])
           {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                    Nos[a].SetActive(true);
                    Yess[a].SetActive(false);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);

                    panelfade.SetActive(true);
           }
           else if(God == characters[a])
           {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                    Nos[a].SetActive(true);
                    Yess[a].SetActive(false);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);

                    panelfade.SetActive(true);
           }
           else if (Beliver2 == characters[a])
           {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
           }
           else
           {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                    Nos[a].SetActive(false);
                    Yess[a].SetActive(true);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);

                    panelfade.SetActive(true);

           }




        }
        else
        {
           if (Believer == characters[a])
           {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                    Nos[a].SetActive(false);
                    Yess[a].SetActive(true);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);
     
                    panelfade.SetActive(true);
           }
           else if (God == characters[a])
           {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                    Nos[a].SetActive(false);
                    Yess[a].SetActive(true);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);
     
                    panelfade.SetActive(true);
           }
           else if (Beliver2 == characters[a])
           {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
           }
           else
           {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                    Nos[a].SetActive(true);
                    Yess[a].SetActive(false);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);
          
                    panelfade.SetActive(true);

           }
        }
        if (tarou.b == "Black&Red")
        {
            if (Believer == characters[a])
            {
                soundManager.PlaySe(eclip);
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

                panelfade.SetActive(true);
            }
            else if (God == characters[a])
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

                panelfade.SetActive(true);
            }
            else if (Beliver2 == characters[a])
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

                panelfade.SetActive(true);
            }
            else
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);

                panelfade.SetActive(true);

            }
        }               
        if (tarou.b == "Black&White")
        {
            if (Believer == characters[a])
            {
                soundManager.PlaySe(eclip);
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

                panelfade.SetActive(true);
            }
            else if (God == characters[a])
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

                panelfade.SetActive(true);
            }
            else if (Beliver2 == characters[a])
            {
                soundManager.PlaySe(eclip);
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

                panelfade.SetActive(true);
            }
            else
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);

                panelfade.SetActive(true);

            }
        }
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "太郎";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "太郎";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "太郎";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "太郎";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "太郎";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "太郎";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "太郎";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "太郎";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "太郎";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "太郎";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "太郎";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "太郎";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "太郎";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "太郎";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "太郎";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "太郎";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "太郎";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "太郎";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "太郎";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "太郎";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "太郎";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "太郎";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "太郎";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "太郎";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "太郎";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "太郎";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "太郎";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "太郎";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "太郎";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "太郎";

        }

    }

    public void Red()
    {
        GameObject God = GameObject.FindWithTag("God");
        tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
        GameObject Believer = GameObject.FindWithTag("Believer");
        GameObject Beliver2 = GameObject.FindWithTag("Beliver2");
        soundManager.PlaySe(eclip);

        if (tarou.b == "Red")
        {
            if (Believer == characters[a])
            {
  

                Questions[a].SetActive(false);
                    Nos[a].SetActive(true);
                    Yess[a].SetActive(false);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);

                    panelfade.SetActive(true);
            }
            else if (God == characters[a])
            {
 

                Questions[a].SetActive(false);
                    Nos[a].SetActive(true);
                    Yess[a].SetActive(false);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);
 
                    panelfade.SetActive(true);
            }
            else if (Beliver2 == characters[a])
            {


                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
            else
            {


                Questions[a].SetActive(false);
                    Nos[a].SetActive(false);
                    Yess[a].SetActive(true);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);
   
                    panelfade.SetActive(true);

            }
        }
        else
        {
           if (Believer == characters[a])
           {
  

                Questions[a].SetActive(false);
                    Nos[a].SetActive(false);
                    Yess[a].SetActive(true);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);

                    panelfade.SetActive(true);
           }
           else if (God == characters[0])
           {
  
                Questions[a].SetActive(false);
                    Nos[a].SetActive(false);
                    Yess[a].SetActive(true);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);

                    panelfade.SetActive(true);
           }
           else if (Beliver2 == characters[a])
           {


                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
           }
           else
           {


                Questions[a].SetActive(false);
                    Nos[a].SetActive(true);
                    Yess[a].SetActive(false);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);

                    panelfade.SetActive(true);

           }

        }
        if (tarou.b == "Black&Red")
        {
            if (Believer == characters[a])
            {
                soundManager.PlaySe(eclip);
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

            }
            else if (God == characters[a])
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

            }
            else if (Beliver2 == characters[a])
            {
                soundManager.PlaySe(eclip);
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

            }
            else
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);


            }
        }
        if (tarou.b == "Redk&White")
        {
            if (Believer == characters[a])
            {
                soundManager.PlaySe(eclip);
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

            }
            else if (God == characters[a])
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

            }
            else if (Beliver2 == characters[a])
            {
                soundManager.PlaySe(eclip);
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);
            }
            else
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);


            }
        }
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "太郎";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "太郎";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "太郎";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "太郎";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "太郎";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "太郎";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "太郎";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "太郎";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "太郎";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "太郎";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "太郎";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "太郎";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "太郎";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "太郎";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "太郎";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "太郎";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "太郎";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "太郎";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "太郎";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "太郎";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "太郎";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "太郎";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "太郎";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "太郎";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "太郎";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "太郎";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "太郎";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "太郎";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "太郎";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "太郎";

        }


    }
    public void White()
    {
         GameObject God = GameObject.FindWithTag("God");
         tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
         GameObject Believer = GameObject.FindWithTag("Believer");
        GameObject Beliver2 = GameObject.FindWithTag("Beliver2");

        soundManager.PlaySe(eclip);

        if (tarou.b == "White")
                {

            if (Believer == characters[a])
            {
                     
                      Questions[a].SetActive(false);
                        Nos[a].SetActive(true);
                        Yess[a].SetActive(false);
                        Invoke("blaky", 1.0f);
                        Invoke("Fadeout", 2.0f);
                        Invoke("fade", 3.0f);

                        panelfade.SetActive(true);
            }
            else if (God == characters[a])
            {
           

                Questions[a].SetActive(false);
                        Nos[a].SetActive(true);
                        Yess[a].SetActive(false);
                        Invoke("blaky", 1.0f);
                        Invoke("Fadeout", 2.0f);
                        Invoke("fade", 3.0f);
     
                        panelfade.SetActive(true);
            }
            else if (Beliver2 == characters[a])
            {

                    Questions[a].SetActive(false);
                    Nos[a].SetActive(true);
                    Yess[a].SetActive(false);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);

                    panelfade.SetActive(true);
            }
            else
            {
                        Questions[a].SetActive(false);
                        Nos[a].SetActive(false);
                        Yess[a].SetActive(true);
                        Invoke("blaky", 1.0f);
                        Invoke("Fadeout", 2.0f);
                        Invoke("fade", 3.0f);

                        panelfade.SetActive(true);

            }
        }
        else
        {
                if (Believer == characters[a])
                {
                        Questions[a].SetActive(false);
                        Nos[a].SetActive(false);
                        Yess[a].SetActive(true);
                        Invoke("blaky", 1.0f);
                        Invoke("Fadeout", 2.0f);
                        Invoke("fade", 3.0f);
 
                        panelfade.SetActive(true);
                }
                else if (God == characters[a])
                {
                        Questions[a].SetActive(false);
                        Nos[a].SetActive(false);
                        Yess[a].SetActive(true);
                        Invoke("blaky", 1.0f);
                        Invoke("Fadeout", 2.0f);
                        Invoke("fade", 3.0f);

                        panelfade.SetActive(true);
                }
                else if (Beliver2 == characters[a])
                {
                    Questions[a].SetActive(false);
                    Nos[a].SetActive(false);
                    Yess[a].SetActive(true);
                    Invoke("blaky", 1.0f);
                    Invoke("Fadeout", 2.0f);
                    Invoke("fade", 3.0f);

                    panelfade.SetActive(true);
                }
                else
                {
                        Questions[a].SetActive(false);
                        Nos[a].SetActive(true);
                        Yess[a].SetActive(false);
                        Invoke("blaky", 1.0f);
                        Invoke("Fadeout", 2.0f);
                        Invoke("fade", 3.0f);

                        panelfade.SetActive(true);

                }

        }

        if (tarou.b == "Black&White")
        {
            if (Believer == characters[a])
            {
                soundManager.PlaySe(eclip);
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

                panelfade.SetActive(true);
            }
            else if (God == characters[a])
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

                panelfade.SetActive(true);
            }
            else if (Beliver2 == characters[a])
            {
                    soundManager.PlaySe(eclip);
                    Questions[a].SetActive(false);
                    Nos[a].SetActive(true);
                    Yess[a].SetActive(false);

                    panelfade.SetActive(true);
            }
            else
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);

                panelfade.SetActive(true);

            }
        }
        if (tarou.b == "Red&White")
        {
            if (Believer == characters[a])
            {
                soundManager.PlaySe(eclip);
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

            }
            else if (God == characters[a])
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);

            }
            else if (Beliver2 == characters[a])
            {
                    soundManager.PlaySe(eclip);
                    Questions[a].SetActive(false);
                    Nos[a].SetActive(true);
                    Yess[a].SetActive(false);

            }
            else
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);


            }
        }
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "太郎";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "太郎";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "太郎";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "太郎";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "太郎";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "太郎";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "太郎";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "太郎";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "太郎";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "太郎";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "太郎";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "太郎";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "太郎";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "太郎";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "太郎";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "太郎";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "太郎";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "太郎";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "太郎";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "太郎";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "太郎";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "太郎";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "太郎";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "太郎";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "太郎";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "太郎";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "太郎";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "太郎";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "太郎";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "太郎";

        }


    }
    public void High()
    {
                GameObject God = GameObject.FindWithTag("God");
                tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
                GameObject Believer = GameObject.FindWithTag("Believer");
        GameObject Beliver2 = GameObject.FindWithTag("Beliver2");

        soundManager.PlaySe(eclip);


        if (tarou.a > L)
        {
            if (Believer == characters[a])
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
            else if (God == characters[a])
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
            else if (Beliver2 == characters[a])
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
            else
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);

            }
        }
        else
        {
            if (Believer == characters[a])
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
            else if (God == characters[0])
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
        
            else if (Beliver2 == characters[0])
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
            else
                    {
                        Questions[a].SetActive(false);
                        Nos[a].SetActive(true);
                        Yess[a].SetActive(false);
                        Invoke("blaky", 1.0f);
                        Invoke("Fadeout", 2.0f);
                        Invoke("fade", 3.0f);

                        panelfade.SetActive(true);

                    }
                }
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "太郎";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "太郎";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "太郎";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "太郎";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "太郎";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "太郎";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "太郎";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "太郎";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "太郎";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "太郎";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "太郎";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "太郎";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "太郎";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "太郎";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "太郎";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "太郎";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "太郎";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "太郎";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "太郎";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "太郎";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "太郎";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "太郎";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "太郎";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "太郎";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "太郎";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "太郎";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "太郎";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "太郎";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "太郎";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "太郎";

        }


    }
    public void Low()
    {
                    GameObject God = GameObject.FindWithTag("God");
                    tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
                    GameObject Believer = GameObject.FindWithTag("Believer");
        GameObject Beliver2 = GameObject.FindWithTag("Beliver2");

        soundManager.PlaySe(eclip);


        if (tarou.a < L)
                    {
                        if (Believer == characters[a])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(true);
                            Yess[a].SetActive(false);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);
 
                            panelfade.SetActive(true);
                        }
                        else if (God == characters[a])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(true);
                            Yess[a].SetActive(false);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);
                        }
            else if (Beliver2 == characters[a])
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
            else
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(false);
                            Yess[a].SetActive(true);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);

                        }
                    }
                    else
                    {
                        if (Believer == characters[0])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(false);
                            Yess[a].SetActive(true);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);
                        }
                        else if (God == characters[0])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(false);
                            Yess[a].SetActive(true);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);
                        }
                        else
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(true);
                            Yess[a].SetActive(false);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);

                        }
                    }
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "太郎";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "太郎";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "太郎";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "太郎";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "太郎";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "太郎";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "太郎";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "太郎";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "太郎";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "太郎";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "太郎";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "太郎";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "太郎";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "太郎";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "太郎";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "太郎";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "太郎";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "太郎";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "太郎";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "太郎";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "太郎";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "太郎";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "太郎";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "太郎";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "太郎";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "太郎";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "太郎";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "太郎";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "太郎";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "太郎";

        }



    }
    public void Hevy()
    {
                    GameObject God = GameObject.FindWithTag("God");
                    GameObject Believer = GameObject.FindWithTag("Believer");
                    tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
        GameObject Beliver2 = GameObject.FindWithTag("Beliver2");

        soundManager.PlaySe(eclip);

        if (tarou.c > N)
                    {
                        if (Believer == characters[a])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(true);
                            Yess[a].SetActive(false);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);
                        }
                        else if (God == characters[a])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(true);
                            Yess[a].SetActive(false);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);
                        }
            else if (Beliver2 == characters[a])
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
            else
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(false);
                            Yess[a].SetActive(true);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);
  
                            panelfade.SetActive(true);

                        }
                    }
                    else
                    {
                        if (Believer == characters[a])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(false);
                            Yess[a].SetActive(true);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);
                        }
                        else if (God == characters[a])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(false);
                            Yess[a].SetActive(true);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);
                        }
            else if (Beliver2 == characters[a])
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
            else
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(true);
                            Yess[a].SetActive(false);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);

                        }

                    }
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "太郎";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "太郎";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "太郎";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "太郎";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "太郎";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "太郎";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "太郎";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "太郎";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "太郎";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "太郎";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "太郎";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "太郎";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "太郎";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "太郎";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "太郎";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "太郎";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "太郎";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "太郎";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "太郎";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "太郎";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "太郎";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "太郎";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "太郎";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "太郎";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "太郎";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "太郎";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "太郎";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "太郎";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "太郎";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "太郎";

        }


    }
    public void karui()
    {
                    GameObject God = GameObject.FindWithTag("God");
                    GameObject Believer = GameObject.FindWithTag("Believer");
                    tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
        GameObject Beliver2 = GameObject.FindWithTag("Beliver2");

        soundManager.PlaySe(eclip);

        if (tarou.c < N)
                    {
                        if (Believer == characters[a])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(true);
                            Yess[a].SetActive(false);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);
                        }
                        else if (God == characters[a])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(true);
                            Yess[a].SetActive(false);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);
                        }
            else if (Beliver2 == characters[a])
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(true);
                Yess[a].SetActive(false);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
            else
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(false);
                            Yess[a].SetActive(true);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);

                        }
                    }
                    else
                    {
                        if (Believer == characters[a])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(false);
                            Yess[a].SetActive(true);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);
                        }
                        else if (God == characters[a])
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(false);
                            Yess[a].SetActive(true);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);
                        }
            else if (Beliver2 == characters[a])
            {
                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);
                Invoke("blaky", 1.0f);
                Invoke("Fadeout", 2.0f);
                Invoke("fade", 3.0f);

                panelfade.SetActive(true);
            }
            else
                        {
                            Questions[a].SetActive(false);
                            Nos[a].SetActive(true);
                            Yess[a].SetActive(false);
                            Invoke("blaky", 1.0f);
                            Invoke("Fadeout", 2.0f);
                            Invoke("fade", 3.0f);

                            panelfade.SetActive(true);

                        }
                    }
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "太郎";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "太郎";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "太郎";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "太郎";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "太郎";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "太郎";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "太郎";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "太郎";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "太郎";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "太郎";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "太郎";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "太郎";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "太郎";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "太郎";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "太郎";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "太郎";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "太郎";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "太郎";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "太郎";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "太郎";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "太郎";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "太郎";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "太郎";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "太郎";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "太郎";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "太郎";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "太郎";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "太郎";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "太郎";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "太郎";

        }

    }



    public void Black1()
    {
        a = 1;
        b = 3;
        c = 2;
        d = 3;
        e = 7;
        f = 8;
        g = 9;
        h = 10;
        i = 11;
        j = 12;
        k = 13;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "茂";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "茂";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "茂";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "茂";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "茂";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "茂";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "茂";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "茂";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "茂";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "茂";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "茂";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "茂";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "茂";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "茂";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "茂";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "茂";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "茂";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "茂";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "茂";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "茂";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "茂";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "茂";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "茂";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "茂";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "茂";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "茂";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "茂";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "茂";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "茂";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "茂";

        }

    }
    public void Red1()
    {
        a = 1;
        b = 3;
        c = 2;
        d = 3;
        e = 7;
        f = 8;
        g = 9;
        h = 10;
        i = 11;
        j = 12;
        k = 13;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "茂";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "茂";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "茂";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "茂";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "茂";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "茂";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "茂";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "茂";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "茂";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "茂";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "茂";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "茂";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "茂";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "茂";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "茂";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "茂";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "茂";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "茂";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "茂";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "茂";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "茂";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "茂";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "茂";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "茂";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "茂";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "茂";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "茂";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "茂";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "茂";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "茂";

        }

    }
    public void White1()
    {
        a = 1;
        b = 3;
        c = 2;
        d = 3;
        e = 7;
        f = 8;
        g = 9;
        h = 10;
        i = 11;
        j = 12;
        k = 13;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "茂";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "茂";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "茂";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "茂";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "茂";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "茂";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "茂";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "茂";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "茂";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "茂";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "茂";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "茂";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "茂";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "茂";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "茂";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "茂";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "茂";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "茂";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "茂";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "茂";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "茂";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "茂";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "茂";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "茂";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "茂";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "茂";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "茂";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "茂";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "茂";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "茂";

        }
    }

    public void High1()
    {
        a = 1;
        b = 3;
        c = 2;
        d = 3;
        e = 7;
        f = 8;
        g = 9;
        h = 10;
        i = 11;
        j = 12;
        k = 13;
        L = 168;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "茂";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "茂";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "茂";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "茂";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "茂";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "茂";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "茂";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "茂";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "茂";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "茂";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "茂";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "茂";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "茂";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "茂";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "茂";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "茂";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "茂";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "茂";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "茂";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "茂";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "茂";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "茂";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "茂";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "茂";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "茂";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "茂";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "茂";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "茂";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "茂";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "茂";

        }

    }
    public void Low1()
    {
        a = 1;
        b = 3;
        c = 2;
        d = 3;
        e = 7;
        f = 8;
        g = 9;
        h = 10;
        i = 11;
        j = 12;
        k = 13;
        L = 168;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "茂";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "茂";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "茂";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "茂";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "茂";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "茂";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "茂";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "茂";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "茂";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "茂";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "茂";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "茂";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "茂";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "茂";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "茂";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "茂";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "茂";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "茂";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "茂";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "茂";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "茂";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "茂";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "茂";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "茂";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "茂";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "茂";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "茂";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "茂";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "茂";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "茂";

        }
    }
    public void Hevy1()
    {
        a = 1;
        b = 3;
        c = 2;
        d = 3;
        e = 7;
        f = 8;
        g = 9;
        h = 10;
        i = 11;
        j = 12;
        k = 13;
        N = 59;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "茂";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "茂";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "茂";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "茂";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "茂";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "茂";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "茂";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "茂";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "茂";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "茂";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "茂";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "茂";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "茂";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "茂";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "茂";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "茂";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "茂";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "茂";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "茂";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "茂";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "茂";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "茂";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "茂";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "茂";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "茂";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "茂";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "茂";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "茂";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "茂";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "茂";

        }
    }
    public void karui1()
    {
        a = 1;
        b = 3;
        c = 2;
        d = 3;
        e = 7;
        f = 8;
        g = 9;
        h = 10;
        i = 11;
        j = 12;
        k = 13;
        N = 59;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "茂";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "茂";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "茂";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "茂";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "茂";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "茂";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "茂";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "茂";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "茂";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "茂";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "茂";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "茂";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "茂";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "茂";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "茂";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "茂";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "茂";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "茂";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "茂";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "茂";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "茂";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "茂";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "茂";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "茂";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "茂";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "茂";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "茂";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "茂";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "茂";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "茂";

        }
    }
    public void Black2()
    {
        a = 2;
        b = 4;
        c = 4;
        d = 5;
        e = 14;
        f = 15;
        g = 16;
        h = 17;
        i = 18;
        j = 19;
        k = 20;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "B太";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "B太";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "B太";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "B太";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "B太";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "B太";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "B太";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "B太";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "B太";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "B太";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "B太";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "B太";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "B太";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "B太";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "B太";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "B太";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "B太";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "B太";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "B太";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "B太";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "B太";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "B太";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "B太";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "B太";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "B太";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "B太";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "B太";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "B太";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "B太";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "B太";

        }

    }
    public void Red2()
    {
        a = 2;
        b = 4;
        c = 4;
        d = 5;
        e = 14;
        f = 15;
        g = 16;
        h = 17;
        i = 18;
        j = 19;
        k = 20;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "B太";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "B太";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "B太";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "B太";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "B太";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "B太";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "B太";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "B太";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "B太";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "B太";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "B太";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "B太";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "B太";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "B太";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "B太";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "B太";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "B太";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "B太";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "B太";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "B太";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "B太";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "B太";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "B太";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "B太";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "B太";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "B太";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "B太";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "B太";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "B太";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "B太";

        }
    }
    public void White2()
    {
        a = 2;
        b = 4;
        c = 4;
        d = 5;
        e = 14;
        f = 15;
        g = 16;
        h = 17;
        i = 18;
        j = 19;
        k = 20;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "B太";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "B太";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "B太";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "B太";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "B太";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "B太";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "B太";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "B太";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "B太";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "B太";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "B太";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "B太";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "B太";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "B太";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "B太";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "B太";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "B太";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "B太";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "B太";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "B太";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "B太";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "B太";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "B太";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "B太";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "B太";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "B太";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "B太";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "B太";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "B太";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "B太";

        }
    }

    public void High2()
    {
        a = 2;
        b = 4;
        c = 4;
        d = 5;
        e = 14;
        f = 15;
        g = 16;
        h = 17;
        i = 18;
        j = 19;
        k = 20;
        L = 164;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "B太";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "B太";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "B太";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "B太";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "B太";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "B太";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "B太";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "B太";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "B太";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "B太";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "B太";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "B太";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "B太";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "B太";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "B太";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "B太";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "B太";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "B太";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "B太";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "B太";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "B太";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "B太";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "B太";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "B太";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "B太";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "B太";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "B太";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "B太";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "B太";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "B太";

        }
    }
    public void Low2()
    {
        a = 2;
        b = 4;
        c = 4;
        d = 5;
        e = 14;
        f = 15;
        g = 16;
        h = 17;
        i = 18;
        j = 19;
        k = 20;
        L = 164;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "B太";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "B太";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "B太";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "B太";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "B太";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "B太";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "B太";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "B太";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "B太";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "B太";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "B太";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "B太";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "B太";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "B太";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "B太";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "B太";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "B太";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "B太";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "B太";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "B太";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "B太";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "B太";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "B太";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "B太";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "B太";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "B太";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "B太";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "B太";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "B太";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "B太";

        }
    }
    public void Hevy2()
    　　{
        a = 2;
        b = 4;
        c = 4;
        d = 5;
        e = 14;
        f = 15;
        g = 16;
        h = 17;
        i = 18;
        j = 19;
        k = 20;
        N = 55;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "B太";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "B太";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "B太";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "B太";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "B太";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "B太";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "B太";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "B太";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "B太";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "B太";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "B太";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "B太";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "B太";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "B太";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "B太";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "B太";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "B太";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "B太";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "B太";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "B太";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "B太";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "B太";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "B太";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "B太";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "B太";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "B太";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "B太";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "B太";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "B太";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "B太";

        }
    }

    public void karui2()
    {
        a = 2;
        b = 4;
        c = 4;
        d = 5;
        e = 14;
        f = 15;
        g = 16;
        h = 17;
        i = 18;
        j = 19;
        k = 20;
        N = 55;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "B太";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "B太";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "B太";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "B太";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "B太";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "B太";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "B太";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "B太";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "B太";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "B太";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "B太";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "B太";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "B太";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "B太";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "B太";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "B太";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "B太";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "B太";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "B太";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "B太";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "B太";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "B太";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "B太";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "B太";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "B太";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "B太";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "B太";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "B太";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "B太";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "B太";

        }

    }
    public void Black3()
    {
        a = 3;
        b = 5;
        c = 6;
        d = 7;
        e = 21;
        f = 22;
        g = 23;
        h = 24;
        i = 25;
        j = 26;
        k = 27;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "レイコ";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "レイコ";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "レイコ";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "レイコ";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "レイコ";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "レイコ";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "レイコ";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "レイコ";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "レイコ";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "レイコ";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "レイコ";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "レイコ";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "レイコ";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "レイコ";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "レイコ";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "レイコ";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "レイコ";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "レイコ";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "レイコ";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "レイコ";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "レイコ";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "レイコ";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "レイコ";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "レイコ";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "レイコ";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "レイコ";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "レイコ";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "レイコ";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "レイコ";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "レイコ";

        }
    }
    public void Red3()
    {
        a = 3;
        b = 5;
        c = 6;
        d = 7;
        e = 21;
        f = 22;
        g = 23;
        h = 24;
        i = 25;
        j = 26;
        k = 27;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "レイコ";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "レイコ";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "レイコ";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "レイコ";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "レイコ";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "レイコ";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "レイコ";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "レイコ";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "レイコ";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "レイコ";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "レイコ";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "レイコ";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "レイコ";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "レイコ";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "レイコ";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "レイコ";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "レイコ";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "レイコ";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "レイコ";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "レイコ";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "レイコ";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "レイコ";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "レイコ";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "レイコ";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "レイコ";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "レイコ";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "レイコ";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "レイコ";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "レイコ";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "レイコ";

        }

    }
    public void White3()
    {
        a = 3;
        b = 5;
        c = 6;
        d = 7;
        e = 21;
        f = 22;
        g = 23;
        h = 24;
        i = 25;
        j = 26;
        k = 27;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "レイコ";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "レイコ";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "レイコ";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "レイコ";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "レイコ";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "レイコ";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "レイコ";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "レイコ";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "レイコ";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "レイコ";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "レイコ";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "レイコ";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "レイコ";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "レイコ";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "レイコ";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "レイコ";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "レイコ";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "レイコ";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "レイコ";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "レイコ";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "レイコ";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "レイコ";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "レイコ";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "レイコ";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "レイコ";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "レイコ";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "レイコ";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "レイコ";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "レイコ";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "レイコ";

        }
    }

    public void High3()
    {
        a = 3;
        b = 5;
        c = 6;
        d = 7;
        e = 21;
        f = 22;
        g = 23;
        h = 24;
        i = 25;
        j = 26;
        k = 27;
        L = 157;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "レイコ";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "レイコ";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "レイコ";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "レイコ";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "レイコ";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "レイコ";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "レイコ";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "レイコ";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "レイコ";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "レイコ";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "レイコ";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "レイコ";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "レイコ";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "レイコ";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "レイコ";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "レイコ";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "レイコ";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "レイコ";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "レイコ";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "レイコ";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "レイコ";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "レイコ";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "レイコ";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "レイコ";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "レイコ";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "レイコ";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "レイコ";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "レイコ";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "レイコ";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "レイコ";

        }

    }
    public void Low3()
    {
        a = 3;
        b = 5;
        c = 6;
        d = 7;
        e = 21;
        f = 22;
        g = 23;
        h = 24;
        i = 25;
        j = 26;
        k = 27;
        L = 157;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "レイコ";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "レイコ";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "レイコ";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "レイコ";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "レイコ";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "レイコ";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "レイコ";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "レイコ";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "レイコ";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "レイコ";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "レイコ";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "レイコ";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "レイコ";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "レイコ";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "レイコ";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "レイコ";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "レイコ";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "レイコ";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "レイコ";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "レイコ";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "レイコ";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "レイコ";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "レイコ";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "レイコ";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "レイコ";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "レイコ";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "レイコ";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "レイコ";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "レイコ";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "レイコ";

        }

    }
    public void Hevy3()
    {
        a = 3;
        b = 5;
        c = 6;
        d = 7;
        e = 21;
        f = 22;
        g = 23;
        h = 24;
        i = 25;
        j = 26;
        k = 27;
        N = 49;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "レイコ";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "レイコ";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "レイコ";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "レイコ";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "レイコ";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "レイコ";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "レイコ";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "レイコ";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "レイコ";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "レイコ";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "レイコ";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "レイコ";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "レイコ";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "レイコ";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "レイコ";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "レイコ";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "レイコ";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "レイコ";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "レイコ";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "レイコ";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "レイコ";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "レイコ";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "レイコ";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "レイコ";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "レイコ";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "レイコ";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "レイコ";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "レイコ";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "レイコ";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "レイコ";

        }

    }
    public void karui3()
    {
        a = 3;
        b = 5;
        c = 6;
        d = 7;
        e = 21;
        f = 22;
        g = 23;
        h = 24;
        i = 25;
        j = 26;
        k = 27;
        N = 49;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "レイコ";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "レイコ";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "レイコ";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "レイコ";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "レイコ";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "レイコ";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "レイコ";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "レイコ";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "レイコ";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "レイコ";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "レイコ";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "レイコ";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "レイコ";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "レイコ";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "レイコ";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "レイコ";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "レイコ";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "レイコ";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "レイコ";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "レイコ";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "レイコ";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "レイコ";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "レイコ";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "レイコ";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "レイコ";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "レイコ";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "レイコ";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "レイコ";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "レイコ";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "レイコ";

        }

    }
    public void Black4()
    {
        a = 4;
        b = 6;
        c = 8;
        d = 9;
        e = 28;
        f = 29;
        g = 30;
        h = 31;
        i = 32;
        j = 33;
        k = 34;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "翔子";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "翔子";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "翔子";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "翔子";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "翔子";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "翔子";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "翔子";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "翔子";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "翔子";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "翔子";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "翔子";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "翔子";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "翔子";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "翔子";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "翔子";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "翔子";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "翔子";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "翔子";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "翔子";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "翔子";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "翔子";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "翔子";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "翔子";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "翔子";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "翔子";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "翔子";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "翔子";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "翔子";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "翔子";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "翔子";

        }

    }
    public void Red4()
    {
        a = 4;
        b = 6;
        c = 8;
        d = 9;
        e = 28;
        f = 29;
        g = 30;
        h = 31;
        i = 32;
        j = 33;
        k = 34;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "翔子";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "翔子";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "翔子";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "翔子";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "翔子";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "翔子";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "翔子";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "翔子";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "翔子";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "翔子";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "翔子";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "翔子";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "翔子";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "翔子";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "翔子";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "翔子";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "翔子";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "翔子";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "翔子";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "翔子";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "翔子";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "翔子";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "翔子";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "翔子";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "翔子";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "翔子";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "翔子";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "翔子";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "翔子";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "翔子";

        }
    }
    public void White4()
    {
        a = 4;
        b = 6;
        c = 8;
        d = 9;
        e = 28;
        f = 29;
        g = 30;
        h = 31;
        i = 32;
        j = 33;
        k = 34;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "翔子";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "翔子";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "翔子";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "翔子";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "翔子";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "翔子";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "翔子";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "翔子";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "翔子";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "翔子";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "翔子";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "翔子";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "翔子";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "翔子";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "翔子";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "翔子";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "翔子";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "翔子";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "翔子";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "翔子";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "翔子";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "翔子";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "翔子";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "翔子";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "翔子";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "翔子";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "翔子";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "翔子";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "翔子";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "翔子";

        }
    }

    public void High4()
    {
        a = 4;
        b = 6;
        c = 8;
        d = 9;
        e = 28;
        f = 29;
        g = 30;
        h = 31;
        i = 32;
        j = 33;
        k = 34;
        L = 165;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "翔子";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "翔子";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "翔子";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "翔子";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "翔子";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "翔子";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "翔子";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "翔子";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "翔子";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "翔子";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "翔子";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "翔子";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "翔子";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "翔子";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "翔子";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "翔子";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "翔子";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "翔子";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "翔子";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "翔子";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "翔子";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "翔子";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "翔子";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "翔子";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "翔子";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "翔子";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "翔子";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "翔子";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "翔子";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "翔子";

        }

    }
    public void Low4()
    {
        a = 4;
        b = 6;
        c = 8;
        d = 9;
        e = 28;
        f = 29;
        g = 30;
        h = 31;
        i = 32;
        j = 33;
        k = 34;
        L = 165;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "翔子";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "翔子";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "翔子";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "翔子";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "翔子";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "翔子";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "翔子";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "翔子";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "翔子";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "翔子";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "翔子";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "翔子";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "翔子";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "翔子";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "翔子";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "翔子";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "翔子";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "翔子";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "翔子";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "翔子";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "翔子";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "翔子";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "翔子";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "翔子";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "翔子";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "翔子";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "翔子";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "翔子";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "翔子";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "翔子";

        }
    }
    public void Hevy4()
    {
        a = 4;
        b = 6;
        c = 8;
        d = 9;
        e = 28;
        f = 29;
        g = 30;
        h = 31;
        i = 32;
        j = 33;
        k = 34;
        N = 50;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "翔子";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "翔子";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "翔子";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "翔子";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "翔子";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "翔子";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "翔子";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "翔子";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "翔子";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "翔子";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "翔子";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "翔子";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "翔子";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "翔子";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "翔子";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "翔子";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "翔子";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "翔子";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "翔子";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "翔子";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "翔子";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "翔子";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "翔子";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "翔子";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "翔子";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "翔子";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "翔子";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "翔子";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "翔子";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "翔子";

        }

    }
    public void karui4()
    {
        a = 4;
        b = 6;
        c = 8;
        d = 9;
        e = 28;
        f = 29;
        g = 30;
        h = 31;
        i = 32;
        j = 33;
        k = 34;
        N = 50;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "翔子";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "翔子";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "翔子";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "翔子";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "翔子";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "翔子";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "翔子";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "翔子";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "翔子";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "翔子";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "翔子";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "翔子";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "翔子";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "翔子";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "翔子";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "翔子";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "翔子";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "翔子";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "翔子";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "翔子";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "翔子";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "翔子";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "翔子";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "翔子";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "翔子";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "翔子";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "翔子";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "翔子";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "翔子";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "翔子";

        }
    }
    public void Black5()
    {
        a = 5;
        b = 7;
        c = 10;
        d = 11;
        e = 35;
        f = 36;
        g = 37;
        h = 38;
        i = 39;
        j = 40;
        k = 41;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "直美";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "直美";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "直美";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "直美";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "直美";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "直美";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "直美";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "直美";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "直美";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "直美";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "直美";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "直美";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "直美";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "直美";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "直美";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "直美";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "直美";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "直美";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "直美";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "直美";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "直美";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "直美";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "直美";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "直美";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "直美";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "直美";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "直美";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "直美";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "直美";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "直美";

        }

    }
    public void Red5()
    {
        a = 5;
        b = 7;
        c = 10;
        d = 11;
        e = 35;
        f = 36;
        g = 37;
        h = 38;
        i = 39;
        j = 40;
        k = 41;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "直美";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "直美";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "直美";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "直美";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "直美";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "直美";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "直美";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "直美";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "直美";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "直美";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "直美";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "直美";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "直美";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "直美";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "直美";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "直美";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "直美";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "直美";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "直美";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "直美";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "直美";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "直美";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "直美";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "直美";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "直美";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "直美";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "直美";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "直美";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "直美";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "直美";

        }
    }
    public void White5()
    {
        a = 5;
        b = 7;
        c = 10;
        d = 11;
        e = 35;
        f = 36;
        g = 37;
        h = 38;
        i = 39;
        j = 40;
        k = 41;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "直美";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "直美";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "直美";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "直美";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "直美";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "直美";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "直美";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "直美";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "直美";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "直美";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "直美";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "直美";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "直美";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "直美";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "直美";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "直美";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "直美";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "直美";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "直美";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "直美";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "直美";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "直美";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "直美";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "直美";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "直美";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "直美";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "直美";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "直美";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "直美";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "直美";

        }
    }

    public void High5()
    {
        a = 5;
        b = 7;
        c = 10;
        d = 11;
        e = 35;
        f = 36;
        g = 37;
        h = 38;
        i = 39;
        j = 40;
        k = 41;
        L = 148;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "直美";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "直美";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "直美";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "直美";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "直美";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "直美";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "直美";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "直美";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "直美";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "直美";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "直美";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "直美";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "直美";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "直美";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "直美";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "直美";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "直美";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "直美";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "直美";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "直美";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "直美";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "直美";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "直美";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "直美";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "直美";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "直美";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "直美";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "直美";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "直美";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "直美";

        }
    }
    public void Low5()
    {
        a = 5;
        b = 7;
        c = 10;
        d = 11;
        e = 35;
        f = 36;
        g = 37;
        h = 38;
        i = 39;
        j = 40;
        k = 41;
        L = 148;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "直美";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "直美";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "直美";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "直美";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "直美";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "直美";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "直美";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "直美";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "直美";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "直美";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "直美";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "直美";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "直美";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "直美";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "直美";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "直美";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "直美";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "直美";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "直美";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "直美";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "直美";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "直美";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "直美";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "直美";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "直美";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "直美";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "直美";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "直美";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "直美";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "直美";

        }

    }
    public void Hevy5()
    {
        a = 5;
        b = 7;
        c = 10;
        d = 11;
        e = 35;
        f = 36;
        g = 37;
        h = 38;
        i = 39;
        j = 40;
        k = 41;
        N = 45;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "直美";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "直美";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "直美";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "直美";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "直美";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "直美";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "直美";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "直美";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "直美";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "直美";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "直美";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "直美";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "直美";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "直美";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "直美";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "直美";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "直美";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "直美";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "直美";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "直美";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "直美";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "直美";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "直美";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "直美";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "直美";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "直美";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "直美";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "直美";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "直美";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "直美";

        }

    }
    public void karui5()
    {
        a = 5;
        b = 7;
        c = 10;
        d = 11;
        e = 35;
        f = 36;
        g = 37;
        h = 38;
        i = 39;
        j = 40;
        k = 41;
        N = 45;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "直美";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "直美";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "直美";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "直美";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "直美";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "直美";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "直美";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "直美";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "直美";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "直美";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "直美";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "直美";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "直美";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "直美";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "直美";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "直美";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "直美";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "直美";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "直美";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "直美";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "直美";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "直美";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "直美";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "直美";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "直美";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "直美";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "直美";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "直美";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "直美";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "直美";

        }

    }
    public void Black6()
    {
        a = 6;
        b = 8;
        c = 12;
        d = 13;
        e = 42;
        f = 43;
        g = 44;
        h = 45;
        i = 46;
        j = 47;
        k = 48;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "リッカ";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "リッカ";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "リッカ";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "リッカ";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "リッカ";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "リッカ";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "リッカ";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "リッカ";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "リッカ";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "リッカ";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "リッカ";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "リッカ";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "リッカ";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "リッカ";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "リッカ";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "リッカ";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "リッカ";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "リッカ";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "リッカ";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "リッカ";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "リッカ";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "リッカ";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "リッカ";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "リッカ";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "リッカ";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "リッカ";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "リッカ";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "リッカ";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "リッカ";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "リッカ";

        }

    }
    public void Red6()
    {
        a = 6;
        b = 8;
        c = 12;
        d = 13;
        e = 42;
        f = 43;
        g = 44;
        h = 45;
        i = 46;
        j = 47;
        k = 48;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "リッカ";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "リッカ";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "リッカ";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "リッカ";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "リッカ";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "リッカ";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "リッカ";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "リッカ";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "リッカ";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "リッカ";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "リッカ";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "リッカ";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "リッカ";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "リッカ";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "リッカ";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "リッカ";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "リッカ";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "リッカ";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "リッカ";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "リッカ";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "リッカ";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "リッカ";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "リッカ";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "リッカ";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "リッカ";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "リッカ";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "リッカ";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "リッカ";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "リッカ";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "リッカ";

        }
    }
    public void White6()
    {
        a = 6;
        b = 8;
        c = 12;
        d = 13;
        e = 42;
        f = 43;
        g = 44;
        h = 45;
        i = 46;
        j = 47;
        k = 48;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "リッカ";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "リッカ";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "リッカ";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "リッカ";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "リッカ";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "リッカ";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "リッカ";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "リッカ";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "リッカ";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "リッカ";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "リッカ";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "リッカ";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "リッカ";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "リッカ";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "リッカ";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "リッカ";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "リッカ";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "リッカ";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "リッカ";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "リッカ";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "リッカ";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "リッカ";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "リッカ";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "リッカ";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "リッカ";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "リッカ";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "リッカ";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "リッカ";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "リッカ";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "リッカ";

        }
    }

    public void High6()
    {
        a = 6;
        b = 8;
        c = 12;
        d = 13;
        e = 42;
        f = 43;
        g = 44;
        h = 45;
        i = 46;
        j = 47;
        k = 48;
        L = 151;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "リッカ";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "リッカ";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "リッカ";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "リッカ";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "リッカ";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "リッカ";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "リッカ";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "リッカ";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "リッカ";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "リッカ";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "リッカ";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "リッカ";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "リッカ";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "リッカ";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "リッカ";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "リッカ";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "リッカ";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "リッカ";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "リッカ";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "リッカ";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "リッカ";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "リッカ";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "リッカ";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "リッカ";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "リッカ";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "リッカ";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "リッカ";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "リッカ";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "リッカ";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "リッカ";

        }

    }
    public void Low6()
    {
        a = 6;
        b = 8;
        c = 12;
        d = 13;
        e = 42;
        f = 43;
        g = 44;
        h = 45;
        i = 46;
        j = 47;
        k = 48;
        L = 151;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "リッカ";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "リッカ";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "リッカ";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "リッカ";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "リッカ";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "リッカ";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "リッカ";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "リッカ";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "リッカ";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "リッカ";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "リッカ";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "リッカ";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "リッカ";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "リッカ";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "リッカ";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "リッカ";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "リッカ";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "リッカ";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "リッカ";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "リッカ";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "リッカ";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "リッカ";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "リッカ";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "リッカ";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "リッカ";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "リッカ";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "リッカ";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "リッカ";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "リッカ";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "リッカ";

        }

    }
    public void Hevy6()
    {
        a = 6;
        b = 8;
        c = 12;
        d = 13;
        e = 42;
        f = 43;
        g = 44;
        h = 45;
        i = 46;
        j = 47;
        k = 48;
        N = 48;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "リッカ";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "リッカ";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "リッカ";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "リッカ";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "リッカ";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "リッカ";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "リッカ";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "リッカ";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "リッカ";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "リッカ";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "リッカ";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "リッカ";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "リッカ";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "リッカ";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "リッカ";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "リッカ";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "リッカ";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "リッカ";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "リッカ";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "リッカ";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "リッカ";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "リッカ";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "リッカ";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "リッカ";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "リッカ";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "リッカ";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "リッカ";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "リッカ";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "リッカ";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "リッカ";

        }

    }
    public void karui6()
    {
        a = 6;
        b = 8;
        c = 12;
        d = 13;
        e = 42;
        f = 43;
        g = 44;
        h = 45;
        i = 46;
        j = 47;
        k = 48;
        N = 48;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "リッカ";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "リッカ";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "リッカ";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "リッカ";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "リッカ";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "リッカ";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "リッカ";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "リッカ";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "リッカ";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "リッカ";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "リッカ";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "リッカ";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "リッカ";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "リッカ";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "リッカ";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "リッカ";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "リッカ";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "リッカ";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "リッカ";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "リッカ";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "リッカ";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "リッカ";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "リッカ";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "リッカ";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "リッカ";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "リッカ";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "リッカ";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "リッカ";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "リッカ";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "リッカ";

        }

    }
    public void Black7()
    {
        a = 7;
        b = 9;
        c = 14;
        d = 15;
        e = 49;
        f = 50;
        g = 51;
        h = 52;
        i = 53;
        j = 54;
        k = 55;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "ネム";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "ネム";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "ネム";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "ネム";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "ネム";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "ネム";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "ネム";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "ネム";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "ネム";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "ネム";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "ネム";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "ネム";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "ネム";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "ネム";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "ネム";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "ネム";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "ネム";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "ネム";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "ネム";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "ネム";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "ネム";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "ネム";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "ネム";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "ネム";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "ネム";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "ネム";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "ネム";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "ネム";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "ネム";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "ネム";

        }
    }
    public void Red7()
    {
        a = 7;
        b = 9;
        c = 14;
        d = 15;
        e = 49;
        f = 50;
        g = 51;
        h = 52;
        i = 53;
        j = 54;
        k = 55;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "ネム";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "ネム";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "ネム";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "ネム";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "ネム";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "ネム";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "ネム";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "ネム";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "ネム";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "ネム";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "ネム";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "ネム";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "ネム";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "ネム";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "ネム";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "ネム";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "ネム";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "ネム";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "ネム";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "ネム";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "ネム";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "ネム";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "ネム";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "ネム";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "ネム";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "ネム";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "ネム";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "ネム";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "ネム";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "ネム";

        }

    }
    public void White7()
    {
        a = 7;
        b = 9;
        c = 14;
        d = 15;
        e = 49;
        f = 50;
        g = 51;
        h = 52;
        i = 53;
        j = 54;
        k = 55;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "ネム";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "ネム";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "ネム";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "ネム";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "ネム";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "ネム";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "ネム";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "ネム";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "ネム";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "ネム";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "ネム";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "ネム";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "ネム";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "ネム";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "ネム";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "ネム";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "ネム";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "ネム";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "ネム";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "ネム";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "ネム";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "ネム";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "ネム";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "ネム";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "ネム";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "ネム";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "ネム";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "ネム";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "ネム";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "ネム";

        }

    }

    public void High7()
    {
        a = 7;
        b = 9;
        c = 14;
        d = 15;
        e = 49;
        f = 50;
        g = 51;
        h = 52;
        i = 53;
        j = 54;
        k = 55;
        L = 152;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "ネム";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "ネム";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "ネム";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "ネム";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "ネム";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "ネム";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "ネム";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "ネム";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "ネム";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "ネム";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "ネム";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "ネム";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "ネム";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "ネム";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "ネム";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "ネム";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "ネム";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "ネム";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "ネム";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "ネム";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "ネム";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "ネム";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "ネム";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "ネム";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "ネム";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "ネム";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "ネム";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "ネム";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "ネム";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "ネム";

        }

    }
    public void Low7()
    {
        a = 7;
        b = 9;
        c = 14;
        d = 15;
        e = 49;
        f = 50;
        g = 51;
        h = 52;
        i = 53;
        j = 54;
        k = 55;
        L = 152;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "ネム";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "ネム";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "ネム";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "ネム";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "ネム";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "ネム";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "ネム";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "ネム";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "ネム";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "ネム";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "ネム";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "ネム";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "ネム";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "ネム";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "ネム";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "ネム";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "ネム";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "ネム";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "ネム";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "ネム";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "ネム";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "ネム";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "ネム";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "ネム";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "ネム";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "ネム";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "ネム";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "ネム";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "ネム";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "ネム";

        }

    }
    public void Hevy7()
    {
        a = 7;
        b = 9;
        c = 14;
        d = 15;
        e = 49;
        f = 50;
        g = 51;
        h = 52;
        i = 53;
        j = 54;
        k = 55;
        N = 41;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "ネム";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "ネム";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "ネム";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "ネム";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "ネム";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "ネム";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "ネム";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "ネム";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "ネム";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "ネム";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "ネム";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "ネム";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "ネム";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "ネム";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "ネム";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "ネム";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "ネム";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "ネム";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "ネム";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "ネム";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "ネム";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "ネム";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "ネム";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "ネム";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "ネム";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "ネム";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "ネム";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "ネム";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "ネム";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "ネム";

        }

    }
    public void karui7()
    {
        a = 7;
        b = 9;
        c = 14;
        d = 15;
        e = 49;
        f = 50;
        g = 51;
        h = 52;
        i = 53;
        j = 54;
        k = 55;
        N = 41;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "ネム";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "ネム";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "ネム";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "ネム";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "ネム";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "ネム";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "ネム";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "ネム";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "ネム";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "ネム";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "ネム";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "ネム";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "ネム";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "ネム";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "ネム";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "ネム";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "ネム";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "ネム";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "ネム";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "ネム";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "ネム";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "ネム";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "ネム";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "ネム";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "ネム";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "ネム";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "ネム";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "ネム";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "ネム";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "ネム";

        }

    }
    public void Black8()
    {
        a = 8;
        b = 10;
        c = 16;
        d = 17;
        e = 56;
        f = 57;
        g = 58;
        h = 59;
        i = 60;
        j = 61;
        k = 62;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "暮蔵";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "暮蔵";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "暮蔵";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "暮蔵";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "暮蔵";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "暮蔵";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "暮蔵";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "暮蔵";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "暮蔵";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "暮蔵";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "暮蔵";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "暮蔵";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "暮蔵";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "暮蔵";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "暮蔵";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "暮蔵";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "暮蔵";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "暮蔵";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "暮蔵";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "暮蔵";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "暮蔵";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "暮蔵";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "暮蔵";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "暮蔵";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "暮蔵";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "暮蔵";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "暮蔵";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "暮蔵";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "暮蔵";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "暮蔵";

        }

    }
    public void Red8()
    {
        a = 8;
        b = 10;
        c = 16;
        d = 17;
        e = 56;
        f = 57;
        g = 58;
        h = 59;
        i = 60;
        j = 61;
        k = 62;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "暮蔵";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "暮蔵";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "暮蔵";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "暮蔵";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "暮蔵";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "暮蔵";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "暮蔵";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "暮蔵";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "暮蔵";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "暮蔵";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "暮蔵";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "暮蔵";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "暮蔵";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "暮蔵";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "暮蔵";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "暮蔵";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "暮蔵";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "暮蔵";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "暮蔵";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "暮蔵";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "暮蔵";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "暮蔵";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "暮蔵";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "暮蔵";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "暮蔵";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "暮蔵";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "暮蔵";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "暮蔵";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "暮蔵";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "暮蔵";

        }
    }
    public void White8()
    {
        a = 8;
        b = 10;
        c = 16;
        d = 17;
        e = 56;
        f = 57;
        g = 58;
        h = 59;
        i = 60;
        j = 61;
        k = 62;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "暮蔵";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "暮蔵";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "暮蔵";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "暮蔵";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "暮蔵";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "暮蔵";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "暮蔵";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "暮蔵";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "暮蔵";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "暮蔵";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "暮蔵";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "暮蔵";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "暮蔵";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "暮蔵";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "暮蔵";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "暮蔵";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "暮蔵";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "暮蔵";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "暮蔵";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "暮蔵";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "暮蔵";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "暮蔵";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "暮蔵";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "暮蔵";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "暮蔵";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "暮蔵";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "暮蔵";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "暮蔵";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "暮蔵";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "暮蔵";

        }
    }

    public void High8()
    {
        a = 8;
        b = 10;
        c = 16;
        d = 17;
        e = 56;
        f = 57;
        g = 58;
        h = 59;
        i = 60;
        j = 61;
        k = 62;
        L = 163;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "暮蔵";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "暮蔵";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "暮蔵";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "暮蔵";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "暮蔵";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "暮蔵";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "暮蔵";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "暮蔵";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "暮蔵";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "暮蔵";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "暮蔵";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "暮蔵";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "暮蔵";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "暮蔵";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "暮蔵";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "暮蔵";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "暮蔵";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "暮蔵";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "暮蔵";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "暮蔵";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "暮蔵";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "暮蔵";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "暮蔵";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "暮蔵";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "暮蔵";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "暮蔵";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "暮蔵";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "暮蔵";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "暮蔵";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "暮蔵";

        }
    }
    public void Low8()
    {
        a = 8;
        b = 10;
        c = 16;
        d = 17;
        e = 56;
        f = 57;
        g = 58;
        h = 59;
        i = 60;
        j = 61;
        k = 62;
        L = 163;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "暮蔵";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "暮蔵";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "暮蔵";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "暮蔵";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "暮蔵";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "暮蔵";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "暮蔵";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "暮蔵";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "暮蔵";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "暮蔵";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "暮蔵";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "暮蔵";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "暮蔵";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "暮蔵";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "暮蔵";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "暮蔵";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "暮蔵";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "暮蔵";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "暮蔵";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "暮蔵";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "暮蔵";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "暮蔵";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "暮蔵";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "暮蔵";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "暮蔵";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "暮蔵";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "暮蔵";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "暮蔵";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "暮蔵";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "暮蔵";

        }
    }
    public void Hevy8()
    {
        a = 8;
        b = 10;
        c = 16;
        d = 17;
        e = 56;
        f = 57;
        g = 58;
        h = 59;
        i = 60;
        j = 61;
        k = 62;
        N = 62;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "暮蔵";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "暮蔵";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "暮蔵";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "暮蔵";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "暮蔵";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "暮蔵";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "暮蔵";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "暮蔵";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "暮蔵";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "暮蔵";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "暮蔵";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "暮蔵";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "暮蔵";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "暮蔵";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "暮蔵";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "暮蔵";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "暮蔵";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "暮蔵";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "暮蔵";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "暮蔵";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "暮蔵";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "暮蔵";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "暮蔵";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "暮蔵";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "暮蔵";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "暮蔵";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "暮蔵";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "暮蔵";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "暮蔵";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "暮蔵";

        }
    }
    public void karui8()
    {
        a = 8;
        b = 10;
        c = 16;
        d = 17;
        e = 56;
        f = 57;
        g = 58;
        h = 59;
        i = 60;
        j = 61;
        k = 62;
        N = 62;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "暮蔵";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "暮蔵";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "暮蔵";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "暮蔵";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "暮蔵";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "暮蔵";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "暮蔵";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "暮蔵";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "暮蔵";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "暮蔵";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "暮蔵";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "暮蔵";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "暮蔵";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "暮蔵";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "暮蔵";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "暮蔵";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "暮蔵";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "暮蔵";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "暮蔵";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "暮蔵";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "暮蔵";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "暮蔵";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "暮蔵";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "暮蔵";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "暮蔵";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "暮蔵";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "暮蔵";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "暮蔵";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "暮蔵";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "暮蔵";

        }

    }
    public void Black9()
    {
        a = 9;
        b = 11;
        c = 18;
        d = 19;
        e = 63;
        f = 64;
        g = 65;
        h = 66;
        i = 67;
        j = 68;
        k = 69;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "まっさる";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "まっさる";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "まっさる";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "まっさる";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "まっさる";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "まっさる";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "まっさる";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "まっさる";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "まっさる";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "まっさる";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "まっさる";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "まっさる";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "まっさる";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "まっさる";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "まっさる";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "まっさる";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "まっさる";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "まっさる";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "まっさる";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "まっさる";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "まっさる";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "まっさる";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "まっさる";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "まっさる";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "まっさる";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "まっさる";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "まっさる";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "まっさる";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "まっさる";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "まっさる";

        }
    }
    public void Red9()
    {
        a = 9;
        b = 11;
        c = 18;
        d = 19;
        e = 63;
        f = 64;
        g = 65;
        h = 66;
        i = 67;
        j = 68;
        k = 69;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "まっさる";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "まっさる";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "まっさる";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "まっさる";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "まっさる";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "まっさる";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "まっさる";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "まっさる";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "まっさる";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "まっさる";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "まっさる";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "まっさる";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "まっさる";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "まっさる";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "まっさる";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "まっさる";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "まっさる";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "まっさる";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "まっさる";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "まっさる";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "まっさる";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "まっさる";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "まっさる";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "まっさる";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "まっさる";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "まっさる";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "まっさる";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "まっさる";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "まっさる";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "まっさる";

        }
    }
    public void White9()
    {
        a = 9;
        b = 11;
        c = 18;
        d = 19;
        e = 63;
        f = 64;
        g = 65;
        h = 66;
        i = 67;
        j = 68;
        k = 69;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "まっさる";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "まっさる";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "まっさる";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "まっさる";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "まっさる";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "まっさる";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "まっさる";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "まっさる";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "まっさる";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "まっさる";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "まっさる";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "まっさる";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "まっさる";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "まっさる";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "まっさる";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "まっさる";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "まっさる";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "まっさる";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "まっさる";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "まっさる";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "まっさる";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "まっさる";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "まっさる";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "まっさる";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "まっさる";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "まっさる";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "まっさる";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "まっさる";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "まっさる";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "まっさる";

        }
    }

    public void High9()
    {
        a = 9;
        b = 11;
        c = 18;
        d = 19;
        e = 63;
        f = 64;
        g = 65;
        h = 66;
        i = 67;
        j = 68;
        k = 69;
        L = 174;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "まっさる";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "まっさる";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "まっさる";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "まっさる";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "まっさる";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "まっさる";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "まっさる";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "まっさる";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "まっさる";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "まっさる";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "まっさる";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "まっさる";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "まっさる";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "まっさる";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "まっさる";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "まっさる";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "まっさる";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "まっさる";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "まっさる";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "まっさる";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "まっさる";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "まっさる";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "まっさる";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "まっさる";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "まっさる";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "まっさる";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "まっさる";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "まっさる";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "まっさる";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "まっさる";

        }
    }
    public void Low9()
    {
        a = 9;
        b = 11;
        c = 18;
        d = 19;
        e = 63;
        f = 64;
        g = 65;
        h = 66;
        i = 67;
        j = 68;
        k = 69;
        L = 174;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "まっさる";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "まっさる";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "まっさる";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "まっさる";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "まっさる";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "まっさる";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "まっさる";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "まっさる";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "まっさる";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "まっさる";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "まっさる";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "まっさる";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "まっさる";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "まっさる";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "まっさる";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "まっさる";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "まっさる";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "まっさる";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "まっさる";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "まっさる";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "まっさる";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "まっさる";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "まっさる";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "まっさる";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "まっさる";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "まっさる";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "まっさる";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "まっさる";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "まっさる";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "まっさる";

        }
    }
    public void Hevy9()
    {
        a = 9;
        b = 11;
        c = 18;
        d = 19;
        e = 63;
        f = 64;
        g = 65;
        h = 66;
        i = 67;
        j = 68;
        k = 69;
        N = 78;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "まっさる";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "まっさる";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "まっさる";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "まっさる";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "まっさる";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "まっさる";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "まっさる";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "まっさる";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "まっさる";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "まっさる";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "まっさる";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "まっさる";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "まっさる";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "まっさる";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "まっさる";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "まっさる";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "まっさる";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "まっさる";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "まっさる";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "まっさる";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "まっさる";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "まっさる";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "まっさる";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "まっさる";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "まっさる";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "まっさる";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "まっさる";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "まっさる";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "まっさる";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "まっさる";

        }
    }
    public void karui9()
    {
        a = 9;
        b = 11;
        c = 18;
        d = 19;
        e = 63;
        f = 64;
        g = 65;
        h = 66;
        i = 67;
        j = 68;
        k = 69;
        N = 78;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "まっさる";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "まっさる";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "まっさる";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "まっさる";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "まっさる";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "まっさる";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "まっさる";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "まっさる";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "まっさる";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "まっさる";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "まっさる";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "まっさる";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "まっさる";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "まっさる";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "まっさる";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "まっさる";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "まっさる";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "まっさる";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "まっさる";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "まっさる";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "まっさる";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "まっさる";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "まっさる";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "まっさる";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "まっさる";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "まっさる";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "まっさる";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "まっさる";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "まっさる";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "まっさる";

        }
    }
    public void Black10()
    {
        a = 10;
        b = 12;
        c = 20;
        d = 21;
        e = 70;
        f = 71;
        g = 72;
        h = 73;
        i = 74;
        j = 75;
        k = 76;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "薄井";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "薄井";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "薄井";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "薄井";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "薄井";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "薄井";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "薄井";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "薄井";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "薄井";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "薄井";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "薄井";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "薄井";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "薄井";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "薄井";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "薄井";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "薄井";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "薄井";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "薄井";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "薄井";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "薄井";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "薄井";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "薄井";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "薄井";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "薄井";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "薄井";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "薄井";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "薄井";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "薄井";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "薄井";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "薄井";

        }
    }
    public void Red10()
    {
        a = 10;
        b = 12;
        c = 20;
        d = 21;
        e = 70;
        f = 71;
        g = 72;
        h = 73;
        i = 74;
        j = 75;
        k = 76;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "薄井";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "薄井";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "薄井";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "薄井";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "薄井";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "薄井";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "薄井";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "薄井";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "薄井";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "薄井";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "薄井";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "薄井";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "薄井";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "薄井";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "薄井";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "薄井";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "薄井";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "薄井";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "薄井";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "薄井";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "薄井";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "薄井";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "薄井";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "薄井";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "薄井";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "薄井";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "薄井";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "薄井";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "薄井";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "薄井";

        }
    }
    public void White10()
    {
        a = 10;
        b = 12;
        c = 20;
        d = 21;
        e = 70;
        f = 71;
        g = 72;
        h = 73;
        i = 74;
        j = 75;
        k = 76;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "薄井";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "薄井";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "薄井";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "薄井";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "薄井";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "薄井";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "薄井";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "薄井";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "薄井";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "薄井";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "薄井";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "薄井";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "薄井";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "薄井";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "薄井";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "薄井";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "薄井";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "薄井";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "薄井";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "薄井";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "薄井";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "薄井";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "薄井";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "薄井";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "薄井";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "薄井";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "薄井";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "薄井";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "薄井";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "薄井";

        }
    }

    public void High10()
    {
        a = 10;
        b = 12;
        c = 20;
        d = 21;
        e = 70;
        f = 71;
        g = 72;
        h = 73;
        i = 74;
        j = 75;
        k = 76;
        L = 180;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "薄井";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "薄井";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "薄井";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "薄井";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "薄井";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "薄井";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "薄井";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "薄井";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "薄井";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "薄井";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "薄井";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "薄井";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "薄井";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "薄井";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "薄井";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "薄井";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "薄井";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "薄井";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "薄井";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "薄井";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "薄井";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "薄井";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "薄井";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "薄井";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "薄井";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "薄井";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "薄井";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "薄井";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "薄井";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "薄井";

        }
    }
    public void Low10()
    {
        a = 10;
        b = 12;
        c = 20;
        d = 21;
        e = 70;
        f = 71;
        g = 72;
        h = 73;
        i = 74;
        j = 75;
        k = 76;
        L = 180;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "薄井";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "薄井";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "薄井";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "薄井";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "薄井";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "薄井";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "薄井";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "薄井";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "薄井";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "薄井";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "薄井";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "薄井";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "薄井";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "薄井";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "薄井";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "薄井";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "薄井";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "薄井";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "薄井";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "薄井";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "薄井";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "薄井";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "薄井";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "薄井";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "薄井";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "薄井";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "薄井";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "薄井";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "薄井";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "薄井";

        }
    }
    public void Hevy10()
    {
        a = 10;
        b = 12;
        c = 20;
        d = 21;
        e = 70;
        f = 71;
        g = 72;
        h = 73;
        i = 74;
        j = 75;
        k = 76;
        N = 77;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "薄井";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "薄井";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "薄井";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "薄井";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "薄井";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "薄井";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "薄井";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "薄井";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "薄井";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "薄井";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "薄井";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "薄井";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "薄井";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "薄井";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "薄井";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "薄井";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "薄井";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "薄井";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "薄井";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "薄井";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "薄井";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "薄井";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "薄井";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "薄井";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "薄井";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "薄井";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "薄井";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "薄井";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "薄井";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "薄井";

        }
    }
    public void karui10()
    {
        a = 10;
        b = 12;
        c = 20;
        d = 21;
        e = 70;
        f = 71;
        g = 72;
        h = 73;
        i = 74;
        j = 75;
        k = 76;
        N = 65;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "薄井";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "薄井";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "薄井";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "薄井";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "薄井";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "薄井";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "薄井";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "薄井";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "薄井";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "薄井";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "薄井";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "薄井";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "薄井";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "薄井";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "薄井";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "薄井";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "薄井";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "薄井";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "薄井";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "薄井";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "薄井";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "薄井";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "薄井";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "薄井";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "薄井";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "薄井";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "薄井";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "薄井";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "薄井";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "薄井";

        }
    }
    public void Black11()
    {
        a = 11;
        b = 13;
        c = 22;
        d = 23;
        e = 77;
        f = 78;
        g = 79;
        h = 80;
        i = 81;
        j = 82;
        k = 83;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "那須川";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "那須川";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "那須川";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "那須川";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "那須川";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "那須川";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "那須川";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "那須川";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "那須川";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "那須川";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "那須川";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "那須川";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "那須川";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "那須川";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "那須川";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "那須川";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "那須川";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "那須川";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "那須川";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "那須川";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "那須川";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "那須川";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "那須川";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "那須川";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "那須川";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "那須川";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "那須川";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "那須川";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "那須川";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "那須川";

        }
    }
    public void Red11()
    {
        a = 11;
        b = 13;
        c = 22;
        d = 23;
        e = 77;
        f = 78;
        g = 79;
        h = 80;
        i = 81;
        j = 82;
        k = 83;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "那須川";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "那須川";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "那須川";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "那須川";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "那須川";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "那須川";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "那須川";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "那須川";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "那須川";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "那須川";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "那須川";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "那須川";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "那須川";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "那須川";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "那須川";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "那須川";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "那須川";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "那須川";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "那須川";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "那須川";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "那須川";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "那須川";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "那須川";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "那須川";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "那須川";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "那須川";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "那須川";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "那須川";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "那須川";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "那須川";

        }
    }
    public void White11()
    {
        a = 11;
        b = 13;
        c = 22;
        d = 23;
        e = 77;
        f = 78;
        g = 79;
        h = 80;
        i = 81;
        j = 82;
        k = 83;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "那須川";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "那須川";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "那須川";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "那須川";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "那須川";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "那須川";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "那須川";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "那須川";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "那須川";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "那須川";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "那須川";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "那須川";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "那須川";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "那須川";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "那須川";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "那須川";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "那須川";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "那須川";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "那須川";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "那須川";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "那須川";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "那須川";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "那須川";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "那須川";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "那須川";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "那須川";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "那須川";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "那須川";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "那須川";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "那須川";

        }
    }

    public void High11()
    {
        a = 11;
        b = 13;
        c = 22;
        d = 23;
        e = 77;
        f = 78;
        g = 79;
        h = 80;
        i = 81;
        j = 82;
        k = 83;
        L = 187;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "那須川";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "那須川";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "那須川";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "那須川";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "那須川";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "那須川";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "那須川";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "那須川";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "那須川";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "那須川";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "那須川";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "那須川";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "那須川";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "那須川";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "那須川";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "那須川";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "那須川";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "那須川";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "那須川";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "那須川";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "那須川";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "那須川";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "那須川";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "那須川";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "那須川";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "那須川";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "那須川";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "那須川";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "那須川";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "那須川";

        }
    }
    public void Low11()
    {
        a = 11;
        b = 13;
        c = 22;
        d = 23;
        e = 77;
        f = 78;
        g = 79;
        h = 80;
        i = 81;
        j = 82;
        k = 83;
        L = 187;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "那須川";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "那須川";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "那須川";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "那須川";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "那須川";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "那須川";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "那須川";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "那須川";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "那須川";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "那須川";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "那須川";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "那須川";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "那須川";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "那須川";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "那須川";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "那須川";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "那須川";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "那須川";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "那須川";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "那須川";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "那須川";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "那須川";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "那須川";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "那須川";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "那須川";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "那須川";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "那須川";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "那須川";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "那須川";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "那須川";

        }
    }
    public void Hevy11()
    {
        a = 11;
        b = 13;
        c = 22;
        d = 23;
        e = 77;
        f = 78;
        g = 79;
        h = 80;
        i = 81;
        j = 82;
        k = 83;
        N = 71;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "那須川";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "那須川";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "那須川";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "那須川";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "那須川";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "那須川";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "那須川";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "那須川";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "那須川";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "那須川";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "那須川";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "那須川";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "那須川";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "那須川";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "那須川";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "那須川";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "那須川";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "那須川";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "那須川";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "那須川";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "那須川";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "那須川";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "那須川";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "那須川";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "那須川";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "那須川";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "那須川";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "那須川";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "那須川";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "那須川";

        }
    }
    public void karui11()
    {
        a = 11;
        b = 13;
        c = 22;
        d = 23;
        e = 77;
        f = 78;
        g = 79;
        h = 80;
        i = 81;
        j = 82;
        k = 83;
        N = 71;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "那須川";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "那須川";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "那須川";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "那須川";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "那須川";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "那須川";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "那須川";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "那須川";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "那須川";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "那須川";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "那須川";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "那須川";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "那須川";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "那須川";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "那須川";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "那須川";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "那須川";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "那須川";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "那須川";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "那須川";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "那須川";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "那須川";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "那須川";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "那須川";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "那須川";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "那須川";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "那須川";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "那須川";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "那須川";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "那須川";

        }
    }
    public void Black12()
    {
        a = 12;
        b = 14;
        c = 24;
        d = 25;
        e = 84;
        f = 85;
        g = 86;
        h = 87;
        i = 88;
        j = 89;
        k = 90;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "K";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "K";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "K";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "K";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "K";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "K";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "K";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "K";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "K";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "K";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "K";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "K";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "K";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "K";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "K";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "K";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "K";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "K";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "K";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "K";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "K";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "K";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "K";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "K";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "K";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "K";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "K";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "K";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "K";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "K";

        }
    }
    public void Red12()
    {
        a = 12;
        b = 14;
        c = 24;
        d = 25;
        e = 84;
        f = 85;
        g = 86;
        h = 87;
        i = 88;
        j = 89;
        k = 90;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "K";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "K";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "K";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "K";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "K";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "K";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "K";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "K";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "K";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "K";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "K";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "K";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "K";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "K";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "K";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "K";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "K";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "K";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "K";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "K";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "K";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "K";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "K";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "K";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "K";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "K";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "K";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "K";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "K";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "K";

        }
    }
    public void White12()
    {
        a = 12;
        b = 14;
        c = 24;
        d = 25;
        e = 84;
        f = 85;
        g = 86;
        h = 87;
        i = 88;
        j = 89;
        k = 90;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "K";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "K";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "K";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "K";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "K";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "K";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "K";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "K";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "K";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "K";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "K";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "K";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "K";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "K";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "K";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "K";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "K";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "K";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "K";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "K";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "K";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "K";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "K";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "K";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "K";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "K";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "K";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "K";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "K";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "K";

        }
    }

    public void High12()
    {
        a = 12;
        b = 14;
        c = 24;
        d = 25;
        e = 84;
        f = 85;
        g = 86;
        h = 87;
        i = 88;
        j = 89;
        k = 90;
        L = 168;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "K";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "K";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "K";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "K";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "K";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "K";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "K";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "K";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "K";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "K";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "K";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "K";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "K";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "K";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "K";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "K";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "K";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "K";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "K";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "K";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "K";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "K";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "K";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "K";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "K";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "K";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "K";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "K";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "K";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "K";

        }
    }
    public void Low12()
    {
        a = 12;
        b = 14;
        c = 24;
        d = 25;
        e = 84;
        f = 85;
        g = 86;
        h = 87;
        i = 88;
        j = 89;
        k = 90;
        L = 168;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "K";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "K";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "K";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "K";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "K";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "K";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "K";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "K";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "K";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "K";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "K";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "K";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "K";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "K";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "K";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "K";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "K";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "K";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "K";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "K";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "K";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "K";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "K";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "K";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "K";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "K";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "K";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "K";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "K";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "K";

        }
    }
    public void Hevy12()
    {
        a = 12;
        b = 14;
        c = 24;
        d = 25;
        e = 84;
        f = 85;
        g = 86;
        h = 87;
        i = 88;
        j = 89;
        k = 90;
        N = 64;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "K";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "K";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "K";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "K";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "K";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "K";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "K";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "K";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "K";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "K";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "K";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "K";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "K";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "K";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "K";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "K";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "K";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "K";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "K";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "K";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "K";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "K";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "K";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "K";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "K";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "K";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "K";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "K";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "K";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "K";

        }
    }
    public void karui12()
    {

        a = 12;
        b = 14;
        c = 24;
        d = 25;
        e = 84;
        f = 85;
        g = 86;
        h = 87;
        i = 88;
        j = 89;
        k = 90;
        N = 64;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "K";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "K";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "K";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "K";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "K";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "K";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "K";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "K";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "K";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "K";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "K";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "K";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "K";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "K";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "K";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "K";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "K";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "K";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "K";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "K";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "K";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "K";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "K";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "K";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "K";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "K";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "K";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "K";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "K";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "K";

        }
    }
    public void Black13()
    {
        a = 13;
        b = 15;
        c = 26;
        d = 27;
        e = 91;
        f = 92;
        g = 93;
        h = 94;
        i = 95;
        j = 96;
        k = 97;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "りん";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "りん";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "りん";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "りん";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "りん";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "りん";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "りん";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "りん";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "りん";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "りん";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "りん";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "りん";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "りん";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "りん";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "りん";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "りん";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "りん";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "りん";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "りん";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "りん";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "りん";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "りん";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "りん";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "りん";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "りん";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "りん";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "りん";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "りん";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "りん";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "りん";

        }
    }
    public void Red13()
    {
        a = 13;
        b = 15;
        c = 26;
        d = 27;
        e = 91;
        f = 92;
        g = 93;
        h = 94;
        i = 95;
        j = 96;
        k = 97;


        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "りん";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "りん";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "りん";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "りん";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "りん";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "りん";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "りん";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "りん";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "りん";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "りん";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "りん";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "りん";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "りん";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "りん";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "りん";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "りん";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "りん";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "りん";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "りん";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "りん";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "りん";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "りん";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "りん";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "りん";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "りん";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "りん";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "りん";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "りん";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "りん";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "りん";

        }
    }
    public void White13()
    {
        a = 13;
        b = 15;
        c = 26;
        d = 27;
        e = 91;
        f = 92;
        g = 93;
        h = 94;
        i = 95;
        j = 96;
        k = 97;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "りん";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "りん";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "りん";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "りん";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "りん";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "りん";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "りん";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "りん";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "りん";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "りん";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "りん";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "りん";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "りん";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "りん";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "りん";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "りん";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "りん";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "りん";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "りん";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "りん";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "りん";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "りん";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "りん";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "りん";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "りん";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "りん";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "りん";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "りん";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "りん";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "りん";

        }
    }

    public void High13()
    {

        a = 13;
        b = 15;
        c = 26;
        d = 27;
        e = 91;
        f = 92;
        g = 93;
        h = 94;
        i = 95;
        j = 96;
        k = 97;
        L = 110;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "りん";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "りん";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "りん";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "りん";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "りん";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "りん";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "りん";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "りん";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "りん";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "りん";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "りん";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "りん";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "りん";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "りん";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "りん";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "りん";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "りん";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "りん";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "りん";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "りん";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "りん";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "りん";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "りん";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "りん";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "りん";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "りん";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "りん";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "りん";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "りん";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "りん";

        }
    }
    public void Low13()
    {
        a = 13;
        b = 15;
        c = 26;
        d = 27;
        e = 91;
        f = 92;
        g = 93;
        h = 94;
        i = 95;
        j = 96;
        k = 97;
        L = 110;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "りん";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "りん";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "りん";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "りん";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "りん";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "りん";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "りん";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "りん";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "りん";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "りん";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "りん";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "りん";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "りん";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "りん";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "りん";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "りん";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "りん";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "りん";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "りん";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "りん";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "りん";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "りん";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "りん";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "りん";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "りん";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "りん";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "りん";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "りん";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "りん";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "りん";

        }
    }
    public void Hevy13()
    {
        a = 13;
        b = 15;
        c = 26;
        d = 27;
        e = 91;
        f = 92;
        g = 93;
        h = 94;
        i = 95;
        j = 96;
        k = 97;
        N = 25;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "りん";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "りん";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "りん";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "りん";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "りん";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "りん";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "りん";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "りん";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "りん";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "りん";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "りん";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "りん";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "りん";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "りん";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "りん";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "りん";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "りん";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "りん";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "りん";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "りん";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "りん";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "りん";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "りん";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "りん";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "りん";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "りん";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "りん";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "りん";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "りん";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "りん";

        }
    }
    public void karui13()
    {

        a = 13;
        b = 15;
        c = 26;
        d = 27;
        e = 91;
        f = 92;
        g = 93;
        h = 94;
        i = 95;
        j = 96;
        k = 97;
        N = 25;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "りん";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "りん";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "りん";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "りん";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "りん";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "りん";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "りん";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "りん";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "りん";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "りん";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "りん";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "りん";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "りん";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "りん";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "りん";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "りん";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "りん";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "りん";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "りん";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "りん";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "りん";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "りん";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "りん";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "りん";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "りん";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "りん";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "りん";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "りん";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "りん";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "りん";

        }
    }
    public void Black14()
    {
        a = 14;
        b = 16;
        c = 28;
        d = 29;
        e = 98;
        f = 99;
        g = 100;
        h = 101;
        i = 102;
        j = 103;
        k = 104;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "まる子";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "まる子";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "まる子";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "まる子";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "まる子";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "まる子";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "まる子";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "まる子";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "まる子";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "まる子";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "まる子";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "まる子";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "まる子";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "まる子";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "まる子";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "まる子";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "まる子";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "まる子";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "まる子";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "まる子";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "まる子";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "まる子";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "まる子";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "まる子";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "まる子";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "まる子";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "まる子";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "まる子";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "まる子";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "まる子";

        }
    }
    public void Red14()
    {
        a = 14;
        b = 16;
        c = 28;
        d = 29;
        e = 98;
        f = 99;
        g = 100;
        h = 101;
        i = 102;
        j = 103;
        k = 104;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "まる子";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "まる子";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "まる子";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "まる子";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "まる子";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "まる子";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "まる子";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "まる子";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "まる子";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "まる子";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "まる子";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "まる子";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "まる子";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "まる子";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "まる子";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "まる子";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "まる子";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "まる子";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "まる子";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "まる子";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "まる子";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "まる子";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "まる子";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "まる子";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "まる子";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "まる子";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "まる子";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "まる子";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "まる子";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "まる子";

        }
    }
    public void White14()
    {
        a = 14;
        b = 16;
        c = 28;
        d = 29;
        e = 98;
        f = 99;
        g = 100;
        h = 101;
        i = 102;
        j = 103;
        k = 104;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "まる子";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "まる子";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "まる子";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "まる子";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "まる子";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "まる子";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "まる子";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "まる子";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "まる子";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "まる子";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "まる子";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "まる子";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "まる子";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "まる子";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "まる子";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "まる子";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "まる子";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "まる子";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "まる子";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "まる子";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "まる子";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "まる子";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "まる子";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "まる子";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "まる子";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "まる子";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "まる子";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "まる子";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "まる子";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "まる子";

        }
    }

    public void High14()
    {
        a = 14;
        b = 16;
        c = 28;
        d = 29;
        e = 98;
        f = 99;
        g = 100;
        h = 101;
        i = 102;
        j = 103;
        k = 104;
        L = 150;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "まる子";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "まる子";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "まる子";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "まる子";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "まる子";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "まる子";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "まる子";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "まる子";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "まる子";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "まる子";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "まる子";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "まる子";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "まる子";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "まる子";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "まる子";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "まる子";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "まる子";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "まる子";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "まる子";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "まる子";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "まる子";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "まる子";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "まる子";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "まる子";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "まる子";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "まる子";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "まる子";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "まる子";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "まる子";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "まる子";

        }
    }
    public void Low14()
    {
        a = 14;
        b = 16;
        c = 28;
        d = 29;
        e = 98;
        f = 99;
        g = 100;
        h = 101;
        i = 102;
        j = 103;
        k = 104;
        L = 150;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "まる子";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "まる子";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "まる子";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "まる子";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "まる子";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "まる子";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "まる子";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "まる子";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "まる子";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "まる子";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "まる子";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "まる子";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "まる子";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "まる子";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "まる子";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "まる子";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "まる子";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "まる子";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "まる子";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "まる子";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "まる子";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "まる子";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "まる子";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "まる子";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "まる子";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "まる子";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "まる子";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "まる子";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "まる子";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "まる子";

        }
    }
    public void Hevy14()
    {
        a = 14;
        b = 16;
        c = 28;
        d = 29;
        e = 98;
        f = 99;
        g = 100;
        h = 101;
        i = 102;
        j = 103;
        k = 104;
        N = 52;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "まる子";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "まる子";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "まる子";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "まる子";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "まる子";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "まる子";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "まる子";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "まる子";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "まる子";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "まる子";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "まる子";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "まる子";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "まる子";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "まる子";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "まる子";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "まる子";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "まる子";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "まる子";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "まる子";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "まる子";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "まる子";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "まる子";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "まる子";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "まる子";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "まる子";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "まる子";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "まる子";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "まる子";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "まる子";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "まる子";

        }
    }
    public void karui14()
    {
        a = 14;
        b = 16;
        c = 28;
        d = 29;
        e = 98;
        f = 99;
        g = 100;
        h = 101;
        i = 102;
        j = 103;
        k = 104;
        N = 52;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "まる子";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "まる子";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "まる子";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "まる子";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "まる子";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "まる子";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "まる子";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "まる子";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "まる子";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "まる子";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "まる子";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "まる子";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "まる子";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "まる子";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "まる子";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "まる子";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "まる子";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "まる子";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "まる子";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "まる子";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "まる子";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "まる子";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "まる子";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "まる子";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "まる子";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "まる子";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "まる子";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "まる子";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "まる子";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "まる子";

        }
    }
    public void Black15()
    {
        a = 15;
        b = 17;
        c = 30;
        d = 31;
        e = 105;
        f = 106;
        g = 107;
        h = 108;
        i = 109;
        j = 110;
        k = 111;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "正美";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "正美";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "正美";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "正美";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "正美";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "正美";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "正美";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "正美";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "正美";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "正美";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "正美";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "正美";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "正美";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "正美";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "正美";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "正美";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "正美";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "正美";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "正美";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "正美";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "正美";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "正美";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "正美";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "正美";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "正美";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "正美";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "正美";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "正美";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "正美";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "正美";

        }
    }
    public void Red15()
    {
        a = 15;
        b = 17;
        c = 30;
        d = 31;
        e = 105;
        f = 106;
        g = 107;
        h = 108;
        i = 109;
        j = 110;
        k = 111;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "正美";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "正美";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "正美";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "正美";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "正美";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "正美";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "正美";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "正美";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "正美";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "正美";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "正美";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "正美";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "正美";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "正美";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "正美";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "正美";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "正美";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "正美";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "正美";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "正美";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "正美";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "正美";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "正美";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "正美";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "正美";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "正美";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "正美";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "正美";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "正美";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "正美";

        }
    }
    public void White15()
    {
        a = 15;
        b = 17;
        c = 30;
        d = 31;
        e = 105;
        f = 106;
        g = 107;
        h = 108;
        i = 109;
        j = 110;
        k = 111;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "正美";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "正美";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "正美";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "正美";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "正美";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "正美";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "正美";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "正美";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "正美";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "正美";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "正美";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "正美";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "正美";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "正美";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "正美";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "正美";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "正美";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "正美";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "正美";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "正美";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "正美";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "正美";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "正美";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "正美";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "正美";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "正美";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "正美";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "正美";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "正美";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "正美";

        }
    }

    public void High15()
    {
        a = 15;
        b = 17;
        c = 30;
        d = 31;
        e = 105;
        f = 106;
        g = 107;
        h = 108;
        i = 109;
        j = 110;
        k = 111;
        L = 155;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "正美";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "正美";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "正美";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "正美";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "正美";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "正美";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "正美";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "正美";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "正美";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "正美";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "正美";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "正美";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "正美";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "正美";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "正美";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "正美";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "正美";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "正美";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "正美";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "正美";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "正美";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "正美";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "正美";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "正美";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "正美";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "正美";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "正美";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "正美";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "正美";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "正美";

        }
    }
    public void Low15()
    {

        a = 15;
        b = 17;
        c = 30;
        d = 31;
        e = 105;
        f = 106;
        g = 107;
        h = 108;
        i = 109;
        j = 110;
        k = 111;
        L = 155;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "正美";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "正美";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "正美";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "正美";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "正美";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "正美";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "正美";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "正美";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "正美";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "正美";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "正美";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "正美";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "正美";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "正美";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "正美";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "正美";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "正美";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "正美";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "正美";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "正美";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "正美";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "正美";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "正美";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "正美";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "正美";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "正美";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "正美";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "正美";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "正美";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "正美";

        }
    }
    public void Hevy15()
    {
        a = 15;
        b = 17;
        c = 30;
        d = 31;
        e = 105;
        f = 106;
        g = 107;
        h = 108;
        i = 109;
        j = 110;
        k = 111;
        N = 43;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "正美";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "正美";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "正美";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "正美";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "正美";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "正美";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "正美";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "正美";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "正美";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "正美";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "正美";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "正美";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "正美";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "正美";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "正美";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "正美";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "正美";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "正美";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "正美";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "正美";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "正美";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "正美";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "正美";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "正美";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "正美";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "正美";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "正美";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "正美";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "正美";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "正美";

        }
    }
    public void karui15()
    {
        a = 15;
        b = 17;
        c = 30;
        d = 31;
        e = 105;
        f = 106;
        g = 107;
        h = 108;
        i = 109;
        j = 110;
        k = 111;
        N = 43;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "正美";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "正美";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "正美";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "正美";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "正美";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "正美";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "正美";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "正美";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "正美";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "正美";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "正美";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "正美";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "正美";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "正美";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "正美";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "正美";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "正美";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "正美";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "正美";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "正美";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "正美";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "正美";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "正美";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "正美";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "正美";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "正美";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "正美";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "正美";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "正美";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "正美";

        }
    }
    public void Black16()
    {
        a = 16;
        b = 18;
        c = 32;
        d = 33;
        e = 112;
        f = 113;
        g = 114;
        h = 115;
        i = 116;
        j = 117;
        k = 118;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "レオ";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "レオ";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "レオ";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "レオ";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "レオ";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "レオ";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "レオ";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "レオ";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "レオ";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "レオ";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "レオ";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "レオ";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "レオ";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "レオ";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "レオ";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "レオ";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "レオ";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "レオ";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "レオ";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "レオ";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "レオ";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "レオ";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "レオ";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "レオ";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "レオ";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "レオ";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "レオ";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "レオ";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "レオ";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "レオ";

        }
    }
    public void Red16()
    {

        a = 16;
        b = 18;
        c = 32;
        d = 33;
        e = 112;
        f = 113;
        g = 114;
        h = 115;
        i = 116;
        j = 117;
        k = 118;
        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "レオ";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "レオ";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "レオ";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "レオ";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "レオ";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "レオ";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "レオ";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "レオ";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "レオ";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "レオ";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "レオ";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "レオ";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "レオ";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "レオ";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "レオ";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "レオ";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "レオ";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "レオ";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "レオ";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "レオ";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "レオ";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "レオ";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "レオ";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "レオ";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "レオ";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "レオ";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "レオ";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "レオ";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "レオ";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "レオ";

        }
    }
    public void White16()
    {
        a = 16;
        b = 18;
        c = 32;
        d = 33;
        e = 112;
        f = 113;
        g = 114;
        h = 115;
        i = 116;
        j = 117;
        k = 118;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "レオ";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "レオ";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "レオ";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "レオ";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "レオ";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "レオ";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "レオ";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "レオ";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "レオ";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "レオ";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "レオ";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "レオ";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "レオ";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "レオ";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "レオ";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "レオ";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "レオ";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "レオ";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "レオ";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "レオ";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "レオ";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "レオ";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "レオ";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "レオ";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "レオ";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "レオ";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "レオ";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "レオ";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "レオ";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "レオ";

        }
    }

    public void High16()
    {
        a = 16;
        b = 18;
        c = 32;
        d = 33;
        e = 112;
        f = 113;
        g = 114;
        h = 115;
        i = 116;
        j = 117;
        k = 118;
        L = 131;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "レオ";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "レオ";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "レオ";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "レオ";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "レオ";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "レオ";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "レオ";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "レオ";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "レオ";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "レオ";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "レオ";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "レオ";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "レオ";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "レオ";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "レオ";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "レオ";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "レオ";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "レオ";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "レオ";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "レオ";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "レオ";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "レオ";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "レオ";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "レオ";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "レオ";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "レオ";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "レオ";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "レオ";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "レオ";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "レオ";

        }
    }
    public void Low16()
    {
        a = 16;
        b = 18;
        c = 32;
        d = 33;
        e = 112;
        f = 113;
        g = 114;
        h = 115;
        i = 116;
        j = 117;
        k = 118;
        L = 131;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "レオ";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "レオ";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "レオ";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "レオ";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "レオ";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "レオ";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "レオ";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "レオ";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "レオ";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "レオ";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "レオ";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "レオ";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "レオ";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "レオ";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "レオ";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "レオ";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "レオ";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "レオ";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "レオ";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "レオ";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "レオ";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "レオ";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "レオ";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "レオ";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "レオ";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "レオ";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "レオ";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "レオ";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "レオ";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "レオ";

        }
    }
    public void Hevy16()
    {
        a = 16;
        b = 18;
        c = 32;
        d = 33;
        e = 112;
        f = 113;
        g = 114;
        h = 115;
        i = 116;
        j = 117;
        k = 118;
        N = 38;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "レオ";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "レオ";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "レオ";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "レオ";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "レオ";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "レオ";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "レオ";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "レオ";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "レオ";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "レオ";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "レオ";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "レオ";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "レオ";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "レオ";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "レオ";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "レオ";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "レオ";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "レオ";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "レオ";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "レオ";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "レオ";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "レオ";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "レオ";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "レオ";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "レオ";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "レオ";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "レオ";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "レオ";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "レオ";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "レオ";

        }
    }
    public void karui16()
    {
        a = 16;
        b = 18;
        c = 32;
        d = 33;
        e = 112;
        f = 113;
        g = 114;
        h = 115;
        i = 116;
        j = 117;
        k = 118;
        N = 38;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "レオ";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "レオ";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "レオ";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "レオ";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "レオ";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "レオ";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "レオ";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "レオ";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "レオ";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "レオ";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "レオ";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "レオ";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "レオ";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "レオ";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "レオ";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "レオ";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "レオ";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "レオ";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "レオ";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "レオ";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "レオ";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "レオ";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "レオ";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "レオ";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "レオ";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "レオ";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "レオ";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "レオ";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "レオ";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "レオ";

        }
    }
    public void Black17()
    {
        a = 17;
        b = 19;
        c = 34;
        d = 35;
        e = 119;
        f = 120;
        g = 121;
        h = 122;
        i = 123;
        j = 124;
        k = 125;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "ター坊";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "ター坊";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "ター坊";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "ター坊";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "ター坊";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "ター坊";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "ター坊";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "ター坊";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "ター坊";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "ター坊";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "ター坊";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "ター坊";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "ター坊";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "ター坊";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "ター坊";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "ター坊";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "ター坊";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "ター坊";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "ター坊";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "ター坊";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "ター坊";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "ター坊";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "ター坊";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "ター坊";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "ター坊";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "ター坊";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "ター坊";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "ター坊";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "ター坊";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "ター坊";

        }
    }
    public void Red17()
    {
        a = 17;
        b = 19;
        c = 34;
        d = 35;
        e = 119;
        f = 120;
        g = 121;
        h = 122;
        i = 123;
        j = 124;
        k = 125;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "ター坊";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "ター坊";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "ター坊";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "ター坊";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "ター坊";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "ター坊";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "ター坊";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "ター坊";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "ター坊";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "ター坊";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "ター坊";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "ター坊";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "ター坊";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "ター坊";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "ター坊";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "ター坊";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "ター坊";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "ター坊";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "ター坊";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "ター坊";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "ター坊";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "ター坊";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "ター坊";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "ター坊";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "ター坊";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "ター坊";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "ター坊";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "ター坊";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "ター坊";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "ター坊";

        }
    }
    public void White17()
    {
        a = 17;
        b = 19;
        c = 34;
        d = 35;
        e = 119;
        f = 120;
        g = 121;
        h = 122;
        i = 123;
        j = 124;
        k = 125;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "ター坊";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "ター坊";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "ター坊";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "ター坊";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "ター坊";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "ター坊";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "ター坊";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "ター坊";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "ター坊";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "ター坊";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "ター坊";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "ター坊";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "ター坊";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "ター坊";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "ター坊";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "ター坊";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "ター坊";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "ター坊";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "ター坊";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "ター坊";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "ター坊";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "ター坊";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "ター坊";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "ター坊";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "ター坊";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "ター坊";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "ター坊";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "ター坊";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "ター坊";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "ター坊";

        }
    }

    public void High17()
    {
        a = 17;
        b = 19;
        c = 34;
        d = 35;
        e = 119;
        f = 120;
        g = 121;
        h = 122;
        i = 123;
        j = 124;
        k = 125;
        L = 136;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "ター坊";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "ター坊";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "ター坊";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "ター坊";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "ター坊";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "ター坊";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "ター坊";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "ター坊";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "ター坊";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "ター坊";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "ター坊";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "ター坊";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "ター坊";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "ター坊";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "ター坊";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "ター坊";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "ター坊";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "ター坊";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "ター坊";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "ター坊";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "ター坊";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "ター坊";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "ター坊";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "ター坊";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "ター坊";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "ター坊";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "ター坊";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "ター坊";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "ター坊";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "ター坊";

        }
    }
    public void Low17()
    {
        a = 17;
        b = 19;
        c = 34;
        d = 35;
        e = 119;
        f = 120;
        g = 121;
        h = 122;
        i = 123;
        j = 124;
        k = 125;
        L = 136;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "ター坊";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "ター坊";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "ター坊";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "ター坊";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "ター坊";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "ター坊";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "ター坊";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "ター坊";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "ター坊";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "ター坊";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "ター坊";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "ター坊";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "ター坊";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "ター坊";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "ター坊";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "ター坊";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "ター坊";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "ター坊";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "ター坊";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "ター坊";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "ター坊";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "ター坊";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "ター坊";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "ター坊";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "ター坊";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "ター坊";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "ター坊";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "ター坊";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "ター坊";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "ター坊";

        }
    }
    public void Hevy17()
    {
        a = 17;
        b = 19;
        c = 34;
        d = 35;
        e = 119;
        f = 120;
        g = 121;
        h = 122;
        i = 123;
        j = 124;
        k = 125;
        N = 33;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "ター坊";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "ター坊";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "ター坊";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "ター坊";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "ター坊";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "ター坊";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "ター坊";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "ター坊";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "ター坊";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "ター坊";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "ター坊";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "ター坊";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "ター坊";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "ター坊";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "ター坊";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "ター坊";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "ター坊";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "ター坊";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "ター坊";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "ター坊";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "ター坊";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "ター坊";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "ター坊";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "ター坊";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "ター坊";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "ター坊";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "ター坊";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "ター坊";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "ター坊";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "ター坊";

        }
    }
    public void karui17()
    {
        a = 17;
        b = 19;
        c = 34;
        d = 35;
        e = 119;
        f = 120;
        g = 121;
        h = 122;
        i = 123;
        j = 124;
        k = 125;
        N = 33;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "ター坊";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "ター坊";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "ター坊";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "ター坊";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "ター坊";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "ター坊";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "ター坊";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "ター坊";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "ター坊";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "ター坊";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "ター坊";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "ター坊";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "ター坊";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "ター坊";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "ター坊";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "ター坊";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "ター坊";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "ター坊";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "ター坊";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "ター坊";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "ター坊";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "ター坊";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "ター坊";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "ター坊";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "ター坊";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "ター坊";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "ター坊";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "ター坊";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "ター坊";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "ター坊";

        }
    }
    public void Black18()
    {
        a = 18;
        b = 20;
        c = 36;
        d = 37;
        e = 126;
        f = 127;
        g = 128;
        h = 129;
        i = 130;
        j = 131;
        k = 132;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "みことちゃん";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "みことちゃん";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "みことちゃん";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "みことちゃん";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "みことちゃん";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "みことちゃん";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "みことちゃん";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "みことちゃん";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "みことちゃん";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "みことちゃん";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "みことちゃん";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "みことちゃん";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "みことちゃん";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "みことちゃん";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "みことちゃん";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "みことちゃん";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "みことちゃん";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "みことちゃん";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "みことちゃん";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "みことちゃん";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "みことちゃん";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "みことちゃん";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "みことちゃん";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "みことちゃん";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "みことちゃん";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "みことちゃん";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "みことちゃん";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "みことちゃん";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "みことちゃん";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "みことちゃん";

        }
    }
    public void Red18()
    {
        a = 18;
        b = 20;
        c = 36;
        d = 37;
        e = 126;
        f = 127;
        g = 128;
        h = 129;
        i = 130;
        j = 131;
        k = 132;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "みことちゃん";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "みことちゃん";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "みことちゃん";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "みことちゃん";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "みことちゃん";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "みことちゃん";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "みことちゃん";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "みことちゃん";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "みことちゃん";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "みことちゃん";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "みことちゃん";
        }
        else if (M == 11)
        {
            memory.a12 = 2;
            memory.na12 = "みことちゃん";

        }
        else if (M == 12)
        {
            memory.a11 = 2;
            memory.na11 = "みことちゃん";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "みことちゃん";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "みことちゃん";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "みことちゃん";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "みことちゃん";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "みことちゃん";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "みことちゃん";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "みことちゃん";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "みことちゃん";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "みことちゃん";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "みことちゃん";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "みことちゃん";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "みことちゃん";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "みことちゃん";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "みことちゃん";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "みことちゃん";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "みことちゃん";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "みことちゃん";

        }
    }
    public void White18()
    {

        a = 18;
        b = 20;
        c = 36;
        d = 37;
        e = 126;
        f = 127;
        g = 128;
        h = 129;
        i = 130;
        j = 131;
        k = 132;
        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "みことちゃん";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "みことちゃん";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "みことちゃん";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "みことちゃん";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "みことちゃん";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "みことちゃん";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "みことちゃん";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "みことちゃん";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "みことちゃん";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "みことちゃん";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "みことちゃん";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "みことちゃん";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "みことちゃん";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "みことちゃん";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "みことちゃん";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "みことちゃん";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "みことちゃん";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "みことちゃん";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "みことちゃん";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "みことちゃん";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "みことちゃん";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "みことちゃん";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "みことちゃん";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "みことちゃん";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "みことちゃん";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "みことちゃん";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "みことちゃん";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "みことちゃん";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "みことちゃん";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "みことちゃん";

        }
    }

    public void High18()
    {
        a = 18;
        b = 20;
        c = 36;
        d = 37;
        e = 126;
        f = 127;
        g = 128;
        h = 129;
        i = 130;
        j = 131;
        k = 132;
        L = 149;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "みことちゃん";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "みことちゃん";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "みことちゃん";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "みことちゃん";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "みことちゃん";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "みことちゃん";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "みことちゃん";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "みことちゃん";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "みことちゃん";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "みことちゃん";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "みことちゃん";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "みことちゃん";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "みことちゃん";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "みことちゃん";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "みことちゃん";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "みことちゃん";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "みことちゃん";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "みことちゃん";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "みことちゃん";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "みことちゃん";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "みことちゃん";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "みことちゃん";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "みことちゃん";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "みことちゃん";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "みことちゃん";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "みことちゃん";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "みことちゃん";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "みことちゃん";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "みことちゃん";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "みことちゃん";

        }
    }
    public void Low18()
    {
        a = 18;
        b = 20;
        c = 36;
        d = 37;
        e = 126;
        f = 127;
        g = 128;
        h = 129;
        i = 130;
        j = 131;
        k = 132;
        L = 149;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "みことちゃん";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "みことちゃん";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "みことちゃん";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "みことちゃん";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "みことちゃん";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "みことちゃん";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "みことちゃん";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "みことちゃん";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "みことちゃん";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "みことちゃん";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "みことちゃん";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "みことちゃん";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "みことちゃん";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "みことちゃん";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "みことちゃん";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "みことちゃん";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "みことちゃん";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "みことちゃん";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "みことちゃん";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "みことちゃん";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "みことちゃん";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "みことちゃん";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "みことちゃん";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "みことちゃん";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "みことちゃん";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "みことちゃん";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "みことちゃん";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "みことちゃん";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "みことちゃん";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "みことちゃん";

        }
    }
    public void Hevy18()
    {
        a = 18;
        b = 20;
        c = 36;
        d = 37;
        e = 126;
        f = 127;
        g = 128;
        h = 129;
        i = 130;
        j = 131;
        k = 132;
        N = 38;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "みことちゃん";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "みことちゃん";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "みことちゃん";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "みことちゃん";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "みことちゃん";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "みことちゃん";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "みことちゃん";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "みことちゃん";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "みことちゃん";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "みことちゃん";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "みことちゃん";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "みことちゃん";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "みことちゃん";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "みことちゃん";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "みことちゃん";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "みことちゃん";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "みことちゃん";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "みことちゃん";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "みことちゃん";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "みことちゃん";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "みことちゃん";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "みことちゃん";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "みことちゃん";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "みことちゃん";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "みことちゃん";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "みことちゃん";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "みことちゃん";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "みことちゃん";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "みことちゃん";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "みことちゃん";

        }
    }
    public void karui18()
    {
        a = 18;
        b = 20;
        c = 36;
        d = 37;
        e = 126;
        f = 127;
        g = 128;
        h = 129;
        i = 130;
        j = 131;
        k = 132;
        N = 38;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "みことちゃん";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "みことちゃん";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "みことちゃん";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "みことちゃん";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "みことちゃん";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "みことちゃん";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "みことちゃん";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "みことちゃん";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "みことちゃん";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "みことちゃん";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "みことちゃん";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "みことちゃん";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "みことちゃん";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "みことちゃん";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "みことちゃん";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "みことちゃん";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "みことちゃん";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "みことちゃん";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "みことちゃん";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "みことちゃん";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "みことちゃん";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "みことちゃん";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "みことちゃん";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "みことちゃん";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "みことちゃん";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "みことちゃん";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "みことちゃん";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "みことちゃん";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "みことちゃん";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "みことちゃん";

        }
    }
    public void Black19()
    {
        a = 19;
        b = 21;
        c = 38;
        d = 39;
        e = 133;
        f = 134;
        g = 135;
        h = 136;
        i = 137;
        j = 138;
        k = 139;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "幽香";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "幽香";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "幽香";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "幽香";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "幽香";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "幽香";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "幽香";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "幽香";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "幽香";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "幽香";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "幽香";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "幽香";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "幽香";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "幽香";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "幽香";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "幽香";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "幽香";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "幽香";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "幽香";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "幽香";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "幽香";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "幽香";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "幽香";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "幽香";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "幽香";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "幽香";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "幽香";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "幽香";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "幽香";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "幽香";

        }
    }
    public void Red19()
    {
        a = 19;
        b = 21;
        c = 38;
        d = 39;
        e = 133;
        f = 134;
        g = 135;
        h = 136;
        i = 137;
        j = 138;
        k = 139;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "幽香";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "幽香";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "幽香";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "幽香";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "幽香";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "幽香";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "幽香";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "幽香";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "幽香";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "幽香";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "幽香";
        }
        else if (M == 11)
        {
            memory.a12 = 2;
            memory.na12 = "幽香";

        }
        else if (M == 12)
        {
            memory.a11 = 2;
            memory.na11 = "幽香";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "幽香";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "幽香";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "幽香";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "幽香";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "幽香";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "幽香";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "幽香";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "幽香";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "幽香";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "幽香";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "幽香";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "幽香";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "幽香";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "幽香";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "幽香";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "幽香";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "幽香";

        }
    }
    public void White19()
    {

                a = 19;
        b = 21;
        c = 38;
        d = 39;
        e = 133;
        f = 134;
        g = 135;
        h = 136;
        i = 137;
        j = 138;
        k = 139;
        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "幽香";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "幽香";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "幽香";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "幽香";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "幽香";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "幽香";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "幽香";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "幽香";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "幽香";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "幽香";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "幽香";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "幽香";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "幽香";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "幽香";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "幽香";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "幽香";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "幽香";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "幽香";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "幽香";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "幽香";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "幽香";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "幽香";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "幽香";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "幽香";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "幽香";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "幽香";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "幽香";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "幽香";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "幽香";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "幽香";

        }
    }

    public void High19()
    {
        a = 19;
        b = 21;
        c = 38;
        d = 39;
        e = 133;
        f = 134;
        g = 135;
        h = 136;
        i = 137;
        j = 138;
        k = 139;
        L = 142;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "幽香";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "幽香";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "幽香";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "幽香";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "幽香";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "幽香";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "幽香";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "幽香";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "幽香";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "幽香";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "幽香";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "幽香";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "幽香";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "幽香";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "幽香";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "幽香";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "幽香";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "幽香";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "幽香";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "幽香";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "幽香";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "幽香";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "幽香";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "幽香";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "幽香";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "幽香";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "幽香";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "幽香";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "幽香";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "幽香";

        }
    }
    public void Low19()
    {
        a = 19;
        b = 21;
        c = 38;
        d = 39;
        e = 133;
        f = 134;
        g = 135;
        h = 136;
        i = 137;
        j = 138;
        k = 139;
        L = 142;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "幽香";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "幽香";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "幽香";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "幽香";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "幽香";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "幽香";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "幽香";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "幽香";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "幽香";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "幽香";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "幽香";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "幽香";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "幽香";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "幽香";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "幽香";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "幽香";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "幽香";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "幽香";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "幽香";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "幽香";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "幽香";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "幽香";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "幽香";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "幽香";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "幽香";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "幽香";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "幽香";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "幽香";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "幽香";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "幽香";

        }
    }
    public void Hevy19()
    {
        a = 19;
        b = 21;
        c = 38;
        d = 39;
        e = 133;
        f = 134;
        g = 135;
        h = 136;
        i = 137;
        j = 138;
        k = 139;
        N = 30;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "幽香";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "幽香";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "幽香";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "幽香";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "幽香";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "幽香";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "幽香";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "幽香";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "幽香";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "幽香";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "幽香";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "幽香";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "幽香";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "幽香";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "幽香";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "幽香";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "幽香";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "幽香";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "幽香";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "幽香";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "幽香";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "幽香";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "幽香";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "幽香";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "幽香";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "幽香";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "幽香";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "幽香";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "幽香";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "幽香";

        }
    }
    public void karui19()
    {
        a = 19;
        b = 21;
        c = 38;
        d = 39;
        e = 133;
        f = 134;
        g = 135;
        h = 136;
        i = 137;
        j = 138;
        k = 139;
        N = 30;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "幽香";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "幽香";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "幽香";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "幽香";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "幽香";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "幽香";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "幽香";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "幽香";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "幽香";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "幽香";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "幽香";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "幽香";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "幽香";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "幽香";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "幽香";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "幽香";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "幽香";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "幽香";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "幽香";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "幽香";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "幽香";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "幽香";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "幽香";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "幽香";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "幽香";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "幽香";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "幽香";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "幽香";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "幽香";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "幽香";

        }
    }
    public void Black20()
    {
        a = 20;
        b = 22;
        c = 40;
        d = 41;
        e = 140;
        f = 141;
        g = 142;
        h = 143;
        i = 144;
        j = 145;
        k = 146;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "ボス";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "ボス";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "ボス";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "ボス";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "ボス";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "ボス";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "ボス";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "ボス";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "ボス";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "ボス";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "ボス";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "ボス";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "ボス";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "ボス";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "ボス";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "ボス";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "ボス";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "ボス";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "ボス";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "ボス";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "ボス";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "ボス";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "ボス";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "ボス";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "ボス";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "ボス";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "ボス";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "ボス";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "ボス";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "ボス";

        }
    }
    public void Red20()
    {
        a = 20;
        b = 22;
        c = 40;
        d = 41;
        e = 140;
        f = 141;
        g = 142;
        h = 143;
        i = 144;
        j = 145;
        k = 146;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "ボス";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "ボス";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "ボス";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "ボス";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "ボス";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "ボス";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "ボス";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "ボス";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "ボス";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "ボス";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "ボス";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "ボス";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "ボス";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "ボス";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "ボス";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "ボス";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "ボス";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "ボス";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "ボス";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "ボス";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "ボス";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "ボス";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "ボス";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "ボス";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "ボス";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "ボス";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "ボス";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "ボス";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "ボス";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "ボス";

        }
    }
    public void White20()
    {
        a = 20;
        b = 22;
        c = 40;
        d = 41;
        e = 140;
        f = 141;
        g = 142;
        h = 143;
        i = 144;
        j = 145;
        k = 146;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "ボス";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "ボス";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "ボス";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "ボス";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "ボス";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "ボス";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "ボス";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "ボス";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "ボス";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "ボス";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "ボス";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "ボス";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "ボス";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "ボス";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "ボス";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "ボス";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "ボス";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "ボス";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "ボス";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "ボス";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "ボス";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "ボス";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "ボス";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "ボス";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "ボス";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "ボス";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "ボス";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "ボス";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "ボス";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "ボス";

        }
    }

    public void High20()
    {
        a = 20;
        b = 22;
        c = 40;
        d = 41;
        e = 140;
        f = 141;
        g = 142;
        h = 143;
        i = 144;
        j = 145;
        k = 146;
        L = 170;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "ボス";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "ボス";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "ボス";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "ボス";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "ボス";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "ボス";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "ボス";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "ボス";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "ボス";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "ボス";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "ボス";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "ボス";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "ボス";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "ボス";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "ボス";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "ボス";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "ボス";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "ボス";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "ボス";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "ボス";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "ボス";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "ボス";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "ボス";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "ボス";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "ボス";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "ボス";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "ボス";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "ボス";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "ボス";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "ボス";

        }
    }
    public void Low20()
    {
        a = 20;
        b = 22;
        c = 40;
        d = 41;
        e = 140;
        f = 141;
        g = 142;
        h = 143;
        i = 144;
        j = 145;
        k = 146;
        L = 170;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "ボス";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "ボス";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "ボス";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "ボス";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "ボス";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "ボス";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "ボス";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "ボス";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "ボス";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "ボス";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "ボス";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "ボス";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "ボス";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "ボス";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "ボス";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "ボス";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "ボス";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "ボス";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "ボス";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "ボス";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "ボス";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "ボス";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "ボス";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "ボス";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "ボス";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "ボス";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "ボス";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "ボス";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "ボス";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "ボス";

        }
    }
    public void Hevy20()
    {
        a = 20;
        b = 22;
        c = 40;
        d = 41;
        e = 140;
        f = 141;
        g = 142;
        h = 143;
        i = 144;
        j = 145;
        k = 146;
        N = 85;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "ボス";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "ボス";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "ボス";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "ボス";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "ボス";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "ボス";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "ボス";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "ボス";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "ボス";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "ボス";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "ボス";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "ボス";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "ボス";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "ボス";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "ボス";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "ボス";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "ボス";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "ボス";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "ボス";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "ボス";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "ボス";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "ボス";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "ボス";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "ボス";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "ボス";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "ボス";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "ボス";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "ボス";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "ボス";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "ボス";

        }
    }
    public void karui20()
    {
        a = 20;
        b = 22;
        c = 40;
        d = 41;
        e = 140;
        f = 141;
        g = 142;
        h = 143;
        i = 144;
        j = 145;
        k = 146;
        N = 85;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "ボス";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "ボス";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "ボス";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "ボス";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "ボス";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "ボス";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "ボス";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "ボス";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "ボス";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "ボス";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "ボス";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "ボス";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "ボス";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "ボス";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "ボス";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "ボス";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "ボス";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "ボス";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "ボス";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "ボス";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "ボス";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "ボス";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "ボス";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "ボス";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "ボス";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "ボス";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "ボス";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "ボス";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "ボス";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "ボス";

        }
    }
    public void Black21()
    {
        a = 21;
        b = 23;
        c = 42;
        d = 43;
        e = 147;
        f = 148;
        g = 149;
        h = 150;
        i = 151;
        j = 152;
        k = 153;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "シスター";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "シスター";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "シスター";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "シスター";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "シスター";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "シスター";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "シスター";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "シスター";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "シスター";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "シスター";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "シスター";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "シスター";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "シスター";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "シスター";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "シスター";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "シスター";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "シスター";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "シスター";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "シスター";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "シスター";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "シスター";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "シスター";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "シスター";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "シスター";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "シスター";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "シスター";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "シスター";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "シスター";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "シスター";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "シスター";

        }
    }
    public void Red21()
    {
        a = 21;
        b = 23;
        c = 42;
        d = 43;
        e = 147;
        f = 148;
        g = 149;
        h = 150;
        i = 151;
        j = 152;
        k = 153;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "シスター";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "シスター";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "シスター";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "シスター";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "シスター";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "シスター";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "シスター";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "シスター";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "シスター";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "シスター";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "シスター";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "シスター";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "シスター";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "シスター";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "シスター";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "シスター";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "シスター";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "シスター";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "シスター";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "シスター";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "シスター";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "シスター";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "シスター";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "シスター";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "シスター";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "シスター";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "シスター";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "シスター";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "シスター";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "シスター";

        }
    }
    public void White21()
    {
        a = 21;
        b = 23;
        c = 42;
        d = 43;
        e = 147;
        f = 148;
        g = 149;
        h = 150;
        i = 151;
        j = 152;
        k = 153;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "シスター";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "シスター";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "シスター";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "シスター";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "シスター";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "シスター";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "シスター";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "シスター";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "シスター";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "シスター";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "シスター";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "シスター";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "シスター";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "シスター";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "シスター";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "シスター";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "シスター";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "シスター";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "シスター";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "シスター";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "シスター";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "シスター";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "シスター";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "シスター";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "シスター";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "シスター";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "シスター";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "シスター";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "シスター";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "シスター";

        }
    }

    public void High21()
    {
        a = 21;
        b = 23;
        c = 42;
        d = 43;
        e = 147;
        f = 148;
        g = 149;
        h = 150;
        i = 151;
        j = 152;
        k = 153;
        L = 154;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "シスター";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "シスター";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "シスター";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "シスター";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "シスター";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "シスター";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "シスター";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "シスター";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "シスター";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "シスター";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "シスター";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "シスター";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "シスター";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "シスター";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "シスター";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "シスター";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "シスター";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "シスター";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "シスター";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "シスター";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "シスター";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "シスター";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "シスター";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "シスター";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "シスター";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "シスター";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "シスター";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "シスター";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "シスター";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "シスター";

        }
    }
    public void Low21()
    {
        a = 21;
        b = 23;
        c = 42;
        d = 43;
        e = 147;
        f = 148;
        g = 149;
        h = 150;
        i = 151;
        j = 152;
        k = 153;
        L = 154;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "シスター";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "シスター";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "シスター";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "シスター";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "シスター";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "シスター";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "シスター";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "シスター";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "シスター";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "シスター";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "シスター";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "シスター";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "シスター";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "シスター";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "シスター";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "シスター";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "シスター";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "シスター";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "シスター";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "シスター";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "シスター";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "シスター";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "シスター";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "シスター";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "シスター";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "シスター";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "シスター";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "シスター";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "シスター";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "シスター";

        }
    }
    public void Hevy21()
    {
        a = 21;
        b = 23;
        c = 42;
        d = 43;
        e = 147;
        f = 148;
        g = 149;
        h = 150;
        i = 151;
        j = 152;
        k = 153;
        N = 49;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "シスター";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "シスター";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "シスター";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "シスター";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "シスター";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "シスター";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "シスター";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "シスター";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "シスター";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "シスター";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "シスター";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "シスター";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "シスター";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "シスター";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "シスター";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "シスター";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "シスター";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "シスター";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "シスター";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "シスター";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "シスター";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "シスター";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "シスター";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "シスター";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "シスター";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "シスター";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "シスター";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "シスター";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "シスター";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "シスター";

        }
    }
    public void karui21()
    {
        a = 21;
        b = 23;
        c = 42;
        d = 43;
        e = 147;
        f = 148;
        g = 149;
        h = 150;
        i = 151;
        j = 152;
        k = 153;
        N = 49;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "シスター";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "シスター";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "シスター";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "シスター";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "シスター";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "シスター";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "シスター";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "シスター";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "シスター";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "シスター";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "シスター";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "シスター";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "シスター";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "シスター";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "シスター";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "シスター";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "シスター";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "シスター";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "シスター";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "シスター";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "シスター";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "シスター";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "シスター";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "シスター";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "シスター";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "シスター";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "シスター";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "シスター";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "シスター";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "シスター";

        }
    }
    public void Black22()
    {
        a = 22;
        b = 24;
        c = 44;
        d = 45;
        e = 154;
        f = 155;
        g = 156;
        h = 157;
        i = 158;
        j = 159;
        k = 160;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "毒島";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "毒島";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "毒島";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "毒島";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "毒島";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "毒島";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "毒島";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "毒島";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "毒島";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "毒島";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "毒島";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "毒島";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "毒島";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "毒島";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "毒島";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "毒島";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "毒島";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "毒島";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "毒島";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "毒島";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "毒島";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "毒島";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "毒島";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "毒島";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "毒島";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "毒島";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "毒島";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "毒島";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "毒島";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "毒島";

        }
    }
    public void Red22()
    {

        a = 22;
        b = 24;
        c = 44;
        d = 45;
        e = 154;
        f = 155;
        g = 156;
        h = 157;
        i = 158;
        j = 159;
        k = 160;
        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "毒島";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "毒島";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "毒島";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "毒島";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "毒島";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "毒島";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "毒島";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "毒島";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "毒島";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "毒島";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "毒島";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "毒島";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "毒島";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "毒島";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "毒島";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "毒島";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "毒島";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "毒島";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "毒島";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "毒島";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "毒島";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "毒島";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "毒島";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "毒島";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "毒島";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "毒島";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "毒島";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "毒島";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "毒島";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "毒島";

        }
    }
    public void White22()
    {
        a = 22;
        b = 24;
        c = 44;
        d = 45;
        e = 154;
        f = 155;
        g = 156;
        h = 157;
        i = 158;
        j = 159;
        k = 160;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "毒島";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "毒島";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "毒島";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "毒島";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "毒島";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "毒島";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "毒島";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "毒島";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "毒島";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "毒島";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "毒島";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "毒島";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "毒島";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "毒島";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "毒島";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "毒島";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "毒島";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "毒島";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "毒島";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "毒島";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "毒島";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "毒島";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "毒島";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "毒島";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "毒島";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "毒島";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "毒島";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "毒島";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "毒島";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "毒島";

        }
    }

    public void High22()
    {
        a = 22;
        b = 24;
        c = 44;
        d = 45;
        e = 154;
        f = 155;
        g = 156;
        h = 157;
        i = 158;
        j = 159;
        k = 160;
        L = 158;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "毒島";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "毒島";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "毒島";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "毒島";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "毒島";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "毒島";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "毒島";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "毒島";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "毒島";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "毒島";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "毒島";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "毒島";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "毒島";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "毒島";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "毒島";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "毒島";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "毒島";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "毒島";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "毒島";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "毒島";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "毒島";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "毒島";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "毒島";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "毒島";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "毒島";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "毒島";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "毒島";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "毒島";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "毒島";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "毒島";

        }
    }
    public void Low22()
    {
        a = 22;
        b = 24;
        c = 44;
        d = 45;
        e = 154;
        f = 155;
        g = 156;
        h = 157;
        i = 158;
        j = 159;
        k = 160;
        L = 158;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "毒島";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "毒島";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "毒島";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "毒島";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "毒島";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "毒島";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "毒島";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "毒島";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "毒島";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "毒島";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "毒島";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "毒島";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "毒島";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "毒島";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "毒島";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "毒島";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "毒島";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "毒島";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "毒島";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "毒島";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "毒島";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "毒島";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "毒島";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "毒島";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "毒島";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "毒島";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "毒島";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "毒島";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "毒島";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "毒島";

        }
    }
    public void Hevy22()
    {
        a = 22;
        b = 24;
        c = 44;
        d = 45;
        e = 154;
        f = 155;
        g = 156;
        h = 157;
        i = 158;
        j = 159;
        k = 160;
        N = 56;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "毒島";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "毒島";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "毒島";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "毒島";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "毒島";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "毒島";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "毒島";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "毒島";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "毒島";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "毒島";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "毒島";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "毒島";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "毒島";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "毒島";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "毒島";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "毒島";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "毒島";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "毒島";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "毒島";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "毒島";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "毒島";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "毒島";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "毒島";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "毒島";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "毒島";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "毒島";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "毒島";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "毒島";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "毒島";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "毒島";

        }
    }
    public void karui22()
    {

        a = 22;
        b = 24;
        c = 44;
        d = 45;
        e = 154;
        f = 155;
        g = 156;
        h = 157;
        i = 158;
        j = 159;
        k = 160;
        N = 56;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "毒島";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "毒島";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "毒島";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "毒島";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "毒島";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "毒島";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "毒島";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "毒島";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "毒島";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "毒島";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "毒島";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "毒島";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "毒島";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "毒島";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "毒島";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "毒島";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "毒島";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "毒島";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "毒島";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "毒島";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "毒島";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "毒島";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "毒島";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "毒島";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "毒島";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "毒島";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "毒島";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "毒島";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "毒島";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "毒島";

        }
    }
    public void Black23()
    {
        a = 23;
        b = 25;
        c = 46;
        d = 47;
        e = 161;
        f = 162;
        g = 163;
        h = 164;
        i = 165;
        j = 166;
        k = 167;
        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "比呂";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "比呂";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "比呂";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "比呂";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "比呂";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "比呂";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "比呂";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "比呂";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "比呂";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "比呂";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "比呂";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "比呂";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "比呂";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "比呂";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "比呂";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "比呂";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "比呂";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "比呂";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "比呂";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "比呂";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "比呂";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "比呂";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "比呂";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "比呂";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "比呂";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "比呂";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "比呂";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "比呂";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "比呂";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "比呂";

        }
    }
    public void Red23()
    {
        a = 23;
        b = 25;
        c = 46;
        d = 47;
        e = 161;
        f = 162;
        g = 163;
        h = 164;
        i = 165;
        j = 166;
        k = 167;


        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "比呂";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "比呂";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "比呂";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "比呂";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "比呂";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "比呂";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "比呂";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "比呂";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "比呂";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "比呂";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "比呂";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "比呂";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "比呂";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "比呂";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "比呂";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "比呂";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "比呂";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "比呂";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "比呂";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "比呂";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "比呂";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "比呂";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "比呂";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "比呂";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "比呂";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "比呂";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "比呂";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "比呂";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "比呂";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "比呂";

        }
    }
    public void White23()
    {
        a = 23;
        b = 25;
        c = 46;
        d = 47;
        e = 161;
        f = 162;
        g = 163;
        h = 164;
        i = 165;
        j = 166;
        k = 167;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "比呂";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "比呂";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "比呂";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "比呂";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "比呂";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "比呂";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "比呂";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "比呂";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "比呂";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "比呂";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "比呂";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "比呂";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "比呂";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "比呂";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "比呂";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "比呂";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "比呂";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "比呂";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "比呂";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "比呂";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "比呂";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "比呂";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "比呂";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "比呂";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "比呂";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "比呂";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "比呂";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "比呂";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "比呂";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "比呂";

        }
    }

    public void High23()
    {

        a = 23;
        b = 25;
        c = 46;
        d = 47;
        e = 161;
        f = 162;
        g = 163;
        h = 164;
        i = 165;
        j = 166;
        k = 167;
        L = 183;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "比呂";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "比呂";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "比呂";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "比呂";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "比呂";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "比呂";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "比呂";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "比呂";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "比呂";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "比呂";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "比呂";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "比呂";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "比呂";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "比呂";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "比呂";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "比呂";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "比呂";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "比呂";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "比呂";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "比呂";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "比呂";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "比呂";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "比呂";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "比呂";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "比呂";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "比呂";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "比呂";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "比呂";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "比呂";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "比呂";

        }
    }
    public void Low23()
    {
        a = 23;
        b = 25;
        c = 46;
        d = 47;
        e = 161;
        f = 162;
        g = 163;
        h = 164;
        i = 165;
        j = 166;
        k = 167;
        L = 183;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "比呂";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "比呂";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "比呂";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "比呂";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "比呂";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "比呂";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "比呂";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "比呂";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "比呂";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "比呂";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "比呂";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "比呂";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "比呂";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "比呂";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "比呂";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "比呂";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "比呂";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "比呂";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "比呂";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "比呂";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "比呂";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "比呂";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "比呂";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "比呂";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "比呂";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "比呂";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "比呂";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "比呂";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "比呂";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "比呂";

        }
    }
    public void Hevy23()
    {
        a = 23;
        b = 25;
        c = 46;
        d = 47;
        e = 161;
        f = 162;
        g = 163;
        h = 164;
        i = 165;
        j = 166;
        k = 167;
        N = 81;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "比呂";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "比呂";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "比呂";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "比呂";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "比呂";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "比呂";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "比呂";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "比呂";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "比呂";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "比呂";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "比呂";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "比呂";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "比呂";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "比呂";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "比呂";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "比呂";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "比呂";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "比呂";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "比呂";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "比呂";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "比呂";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "比呂";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "比呂";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "比呂";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "比呂";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "比呂";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "比呂";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "比呂";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "比呂";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "比呂";

        }
    }
    public void karui23()
    {

        a = 23;
        b = 25;
        c = 46;
        d = 47;
        e = 161;
        f = 162;
        g = 163;
        h = 164;
        i = 165;
        j = 166;
        k = 167;
        N = 81;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "比呂";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "比呂";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "比呂";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "比呂";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "比呂";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "比呂";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "比呂";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "比呂";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "比呂";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "比呂";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "比呂";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "比呂";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "比呂";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "比呂";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "比呂";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "比呂";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "比呂";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "比呂";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "比呂";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "比呂";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "比呂";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "比呂";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "比呂";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "比呂";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "比呂";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "比呂";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "比呂";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "比呂";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "比呂";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "比呂";

        }
    }
    public void Black24()
    {
        a = 24;
        b = 26;
        c = 48;
        d = 49;
        e = 168;
        f = 169;
        g = 170;
        h = 171;
        i = 172;
        j = 173;
        k = 174;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "マッキー";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "マッキー";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "マッキー";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "マッキー";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "マッキー";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "マッキー";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "マッキー";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "マッキー";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "マッキー";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "マッキー";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "マッキー";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "マッキー";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "マッキー";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "マッキー";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "マッキー";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "マッキー";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "マッキー";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "マッキー";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "マッキー";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "マッキー";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "マッキー";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "マッキー";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "マッキー";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "マッキー";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "マッキー";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "マッキー";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "マッキー";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "マッキー";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "マッキー";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "マッキー";

        }
    }
    public void Red24()
    {
        a = 24;
        b = 26;
        c = 48;
        d = 49;
        e = 168;
        f = 169;
        g = 170;
        h = 171;
        i = 172;
        j = 173;
        k = 174;

        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "マッキー";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "マッキー";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "マッキー";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "マッキー";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "マッキー";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "マッキー";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "マッキー";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "マッキー";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "マッキー";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "マッキー";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "マッキー";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "マッキー";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "マッキー";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "マッキー";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "マッキー";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "マッキー";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "マッキー";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "マッキー";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "マッキー";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "マッキー";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "マッキー";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "マッキー";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "マッキー";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "マッキー";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "マッキー";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "マッキー";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "マッキー";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "マッキー";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "マッキー";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "マッキー";

        }
    }
    public void White24()
    {

        a = 24;
        b = 26;
        c = 48;
        d = 49;
        e = 168;
        f = 169;
        g = 170;
        h = 171;
        i = 172;
        j = 173;
        k = 174;
        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "マッキー";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "マッキー";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "マッキー";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "マッキー";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "マッキー";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "マッキー";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "マッキー";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "マッキー";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "マッキー";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "マッキー";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "マッキー";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "マッキー";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "マッキー";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "マッキー";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "マッキー";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "マッキー";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "マッキー";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "マッキー";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "マッキー";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "マッキー";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "マッキー";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "マッキー";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "マッキー";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "マッキー";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "マッキー";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "マッキー";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "マッキー";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "マッキー";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "マッキー";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "マッキー";

        }
    }

    public void High24()
    {
        a = 24;
        b = 26;
        c = 48;
        d = 49;
        e = 168;
        f = 169;
        g = 170;
        h = 171;
        i = 172;
        j = 173;
        k = 174;
        L = 166;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "マッキー";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "マッキー";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "マッキー";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "マッキー";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "マッキー";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "マッキー";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "マッキー";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "マッキー";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "マッキー";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "マッキー";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "マッキー";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "マッキー";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "マッキー";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "マッキー";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "マッキー";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "マッキー";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "マッキー";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "マッキー";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "マッキー";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "マッキー";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "マッキー";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "マッキー";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "マッキー";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "マッキー";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "マッキー";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "マッキー";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "マッキー";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "マッキー";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "マッキー";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "マッキー";

        }
    }
    public void Low24()
    {
        a = 24;
        b = 26;
        c = 48;
        d = 49;
        e = 168;
        f = 169;
        g = 170;
        h = 171;
        i = 172;
        j = 173;
        k = 174;
        L = 166;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "マッキー";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "マッキー";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "マッキー";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "マッキー";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "マッキー";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "マッキー";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "マッキー";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "マッキー";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "マッキー";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "マッキー";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "マッキー";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "マッキー";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "マッキー";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "マッキー";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "マッキー";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "マッキー";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "マッキー";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "マッキー";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "マッキー";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "マッキー";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "マッキー";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "マッキー";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "マッキー";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "マッキー";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "マッキー";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "マッキー";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "マッキー";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "マッキー";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "マッキー";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "マッキー";

        }
    }
    public void Hevy24()
    {
        a = 24;
        b = 26;
        c = 48;
        d = 49;
        e = 168;
        f = 169;
        g = 170;
        h = 171;
        i = 172;
        j = 173;
        k = 174;
        N = 73;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "マッキー";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "マッキー";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "マッキー";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "マッキー";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "マッキー";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "マッキー";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "マッキー";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "マッキー";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "マッキー";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "マッキー";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "マッキー";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "マッキー";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "マッキー";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "マッキー";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "マッキー";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "マッキー";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "マッキー";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "マッキー";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "マッキー";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "マッキー";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "マッキー";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "マッキー";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "マッキー";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "マッキー";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "マッキー";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "マッキー";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "マッキー";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "マッキー";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "マッキー";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "マッキー";

        }
    }
    public void karui24()
    {
        a = 24;
        b = 26;
        c = 48;
        d = 49;
        e = 168;
        f = 169;
        g = 170;
        h = 171;
        i = 172;
        j = 173;
        k = 174;
        N = 73;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "マッキー";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "マッキー";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "マッキー";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "マッキー";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "マッキー";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "マッキー";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "マッキー";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "マッキー";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "マッキー";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "マッキー";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "マッキー";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "マッキー";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "マッキー";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "マッキー";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "マッキー";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "マッキー";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "マッキー";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "マッキー";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "マッキー";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "マッキー";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "マッキー";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "マッキー";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "マッキー";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "マッキー";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "マッキー";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "マッキー";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "マッキー";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "マッキー";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "マッキー";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "マッキー";

        }
    }
    public void Black25()
    {
        a = 25;
        b = 27;
        c = 50;
        d = 51;
        e = 175;
        f = 176;
        g = 177;
        h = 178;
        i = 179;
        j = 180;
        k = 181;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "マリー";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "マリー";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "マリー";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "マリー";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "マリー";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "マリー";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "マリー";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "マリー";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "マリー";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "マリー";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "マリー";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "マリー";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "マリー";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "マリー";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "マリー";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "マリー";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "マリー";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "マリー";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "マリー";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "マリー";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "マリー";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "マリー";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "マリー";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "マリー";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "マリー";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "マリー";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "マリー";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "マリー";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "マリー";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "マリー";

        }
    }
    public void Red25()
    {

        a = 25;
        b = 27;
        c = 50;
        d = 51;
        e = 175;
        f = 176;
        g = 177;
        h = 178;
        i = 179;
        j = 180;
        k = 181;
        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "マリー";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "マリー";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "マリー";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "マリー";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "マリー";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "マリー";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "マリー";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "マリー";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "マリー";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "マリー";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "マリー";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "マリー";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "マリー";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "マリー";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "マリー";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "マリー";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "マリー";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "マリー";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "マリー";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "マリー";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "マリー";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "マリー";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "マリー";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "マリー";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "マリー";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "マリー";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "マリー";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "マリー";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "マリー";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "マリー";

        }
    }
    public void White25()
    {
        a = 25;
        b = 27;
        c = 50;
        d = 51;
        e = 175;
        f = 176;
        g = 177;
        h = 178;
        i = 179;
        j = 180;
        k = 181;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "マリー";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "マリー";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "マリー";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "マリー";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "マリー";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "マリー";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "マリー";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "マリー";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "マリー";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "マリー";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "マリー";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "マリー";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "マリー";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "マリー";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "マリー";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "マリー";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "マリー";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "マリー";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "マリー";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "マリー";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "マリー";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "マリー";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "マリー";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "マリー";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "マリー";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "マリー";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "マリー";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "マリー";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "マリー";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "マリー";

        }
    }

    public void High25()
    {
        a = 25;
        b = 27;
        c = 50;
        d = 51;
        e = 175;
        f = 176;
        g = 177;
        h = 178;
        i = 179;
        j = 180;
        k = 181;
        L = 160;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "マリー";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "マリー";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "マリー";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "マリー";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "マリー";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "マリー";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "マリー";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "マリー";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "マリー";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "マリー";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "マリー";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "マリー";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "マリー";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "マリー";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "マリー";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "マリー";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "マリー";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "マリー";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "マリー";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "マリー";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "マリー";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "マリー";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "マリー";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "マリー";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "マリー";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "マリー";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "マリー";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "マリー";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "マリー";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "マリー";

        }
    }
    public void Low25()
    {

        a = 25;
        b = 27;
        c = 50;
        d = 51;
        e = 175;
        f = 176;
        g = 177;
        h = 178;
        i = 179;
        j = 180;
        k = 181;
        L = 160;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "マリー";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "マリー";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "マリー";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "マリー";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "マリー";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "マリー";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "マリー";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "マリー";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "マリー";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "マリー";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "マリー";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "マリー";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "マリー";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "マリー";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "マリー";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "マリー";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "マリー";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "マリー";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "マリー";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "マリー";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "マリー";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "マリー";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "マリー";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "マリー";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "マリー";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "マリー";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "マリー";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "マリー";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "マリー";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "マリー";

        }
    }
    public void Hevy25()
    {
        a = 25;
        b = 27;
        c = 50;
        d = 51;
        e = 175;
        f = 176;
        g = 177;
        h = 178;
        i = 179;
        j = 180;
        k = 181;
        N = 51;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "マリー";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "マリー";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "マリー";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "マリー";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "マリー";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "マリー";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "マリー";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "マリー";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "マリー";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "マリー";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "マリー";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "マリー";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "マリー";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "マリー";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "マリー";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "マリー";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "マリー";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "マリー";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "マリー";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "マリー";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "マリー";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "マリー";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "マリー";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "マリー";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "マリー";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "マリー";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "マリー";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "マリー";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "マリー";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "マリー";

        }
    }
    public void karui25()
    {
        a = 25;
        b = 27;
        c = 50;
        d = 51;
        e = 175;
        f = 176;
        g = 177;
        h = 178;
        i = 179;
        j = 180;
        k = 181;
        N = 51;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "マリー";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "マリー";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "マリー";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "マリー";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "マリー";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "マリー";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "マリー";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "マリー";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "マリー";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "マリー";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "マリー";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "マリー";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "マリー";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "マリー";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "マリー";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "マリー";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "マリー";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "マリー";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "マリー";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "マリー";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "マリー";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "マリー";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "マリー";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "マリー";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "マリー";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "マリー";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "マリー";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "マリー";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "マリー";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "マリー";

        }
    }
    public void Black26()
    {
        a = 26;
        b = 28;
        c = 52;
        d = 53;
        e = 182;
        f = 183;
        g = 184;
        h = 185;
        i = 186;
        j = 187;
        k = 188;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "ジョー";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "ジョー";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "ジョー";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "ジョー";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "ジョー";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "ジョー";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "ジョー";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "ジョー";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "ジョー";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "ジョー";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "ジョー";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "ジョー";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "ジョー";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "ジョー";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "ジョー";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "ジョー";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "ジョー";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "ジョー";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "ジョー";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "ジョー";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "ジョー";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "ジョー";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "ジョー";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "ジョー";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "ジョー";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "ジョー";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "ジョー";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "ジョー";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "ジョー";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "ジョー";

        }
    }
    public void Red26()
    {

        a = 26;
        b = 28;
        c = 52;
        d = 53;
        e = 182;
        f = 183;
        g = 184;
        h = 185;
        i = 186;
        j = 187;
        k = 188;
        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "ジョー";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "ジョー";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "ジョー";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "ジョー";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "ジョー";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "ジョー";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "ジョー";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "ジョー";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "ジョー";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "ジョー";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "ジョー";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "ジョー";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "ジョー";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "ジョー";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "ジョー";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "ジョー";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "ジョー";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "ジョー";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "ジョー";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "ジョー";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "ジョー";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "ジョー";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "ジョー";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "ジョー";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "ジョー";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "ジョー";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "ジョー";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "ジョー";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "ジョー";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "ジョー";

        }
    }
    public void White26()
    {

        a = 26;
        b = 28;
        c = 52;
        d = 53;
        e = 182;
        f = 183;
        g = 184;
        h = 185;
        i = 186;
        j = 187;
        k = 188;
        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "ジョー";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "ジョー";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "ジョー";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "ジョー";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "ジョー";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "ジョー";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "ジョー";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "ジョー";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "ジョー";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "ジョー";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "ジョー";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "ジョー";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "ジョー";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "ジョー";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "ジョー";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "ジョー";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "ジョー";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "ジョー";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "ジョー";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "ジョー";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "ジョー";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "ジョー";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "ジョー";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "ジョー";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "ジョー";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "ジョー";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "ジョー";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "ジョー";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "ジョー";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "ジョー";

        }
    }

    public void High26()
    {
        a = 26;
        b = 28;
        c = 52;
        d = 53;
        e = 182;
        f = 183;
        g = 184;
        h = 185;
        i = 186;
        j = 187;
        k = 188;
        L = 165;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "ジョー";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "ジョー";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "ジョー";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "ジョー";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "ジョー";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "ジョー";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "ジョー";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "ジョー";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "ジョー";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "ジョー";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "ジョー";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "ジョー";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "ジョー";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "ジョー";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "ジョー";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "ジョー";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "ジョー";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "ジョー";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "ジョー";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "ジョー";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "ジョー";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "ジョー";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "ジョー";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "ジョー";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "ジョー";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "ジョー";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "ジョー";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "ジョー";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "ジョー";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "ジョー";

        }
    }
    public void Low26()
    {
        a = 26;
        b = 28;
        c = 52;
        d = 53;
        e = 182;
        f = 183;
        g = 184;
        h = 185;
        i = 186;
        j = 187;
        k = 188;
        L = 165;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "ジョー";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "ジョー";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "ジョー";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "ジョー";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "ジョー";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "ジョー";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "ジョー";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "ジョー";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "ジョー";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "ジョー";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "ジョー";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "ジョー";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "ジョー";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "ジョー";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "ジョー";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "ジョー";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "ジョー";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "ジョー";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "ジョー";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "ジョー";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "ジョー";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "ジョー";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "ジョー";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "ジョー";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "ジョー";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "ジョー";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "ジョー";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "ジョー";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "ジョー";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "ジョー";

        }
    }
    public void Hevy26()
    {
        a = 26;
        b = 28;
        c = 52;
        d = 53;
        e = 182;
        f = 183;
        g = 184;
        h = 185;
        i = 186;
        j = 187;
        k = 188;
        N = 54;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "ジョー";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "ジョー";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "ジョー";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "ジョー";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "ジョー";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "ジョー";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "ジョー";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "ジョー";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "ジョー";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "ジョー";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "ジョー";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "ジョー";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "ジョー";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "ジョー";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "ジョー";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "ジョー";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "ジョー";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "ジョー";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "ジョー";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "ジョー";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "ジョー";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "ジョー";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "ジョー";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "ジョー";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "ジョー";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "ジョー";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "ジョー";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "ジョー";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "ジョー";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "ジョー";

        }
    }
    public void karui26()
    {
        a = 26;
        b = 28;
        c = 52;
        d = 53;
        e = 182;
        f = 183;
        g = 184;
        h = 185;
        i = 186;
        j = 187;
        k = 188;
        N = 54;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "ジョー";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "ジョー";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "ジョー";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "ジョー";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "ジョー";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "ジョー";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "ジョー";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "ジョー";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "ジョー";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "ジョー";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "ジョー";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "ジョー";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "ジョー";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "ジョー";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "ジョー";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "ジョー";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "ジョー";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "ジョー";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "ジョー";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "ジョー";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "ジョー";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "ジョー";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "ジョー";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "ジョー";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "ジョー";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "ジョー";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "ジョー";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "ジョー";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "ジョー";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "ジョー";

        }
    }
    public void Black27()
    {
        a = 27;
        b = 29;
        c = 54;
        d = 55;
        e = 189;
        f = 190;
        g = 191;
        h = 192;
        i = 193;
        j = 194;
        k = 195;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "英雄";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "英雄";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "英雄";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "英雄";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "英雄";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "英雄";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "英雄";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "英雄";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "英雄";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "英雄";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "英雄";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "英雄";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "英雄";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "英雄";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "英雄";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "英雄";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "英雄";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "英雄";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "英雄";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "英雄";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "英雄";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "英雄";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "英雄";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "英雄";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "英雄";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "英雄";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "英雄";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "英雄";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "英雄";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "英雄";

        }
    }
    public void Red27()
    {

        a = 27;
        b = 29;
        c = 54;
        d = 55;
        e = 189;
        f = 190;
        g = 191;
        h = 192;
        i = 193;
        j = 194;
        k = 195;
        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "英雄";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "英雄";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "英雄";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "英雄";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "英雄";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "英雄";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "英雄";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "英雄";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "英雄";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "英雄";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "英雄";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "英雄";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "英雄";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "英雄";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "英雄";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "英雄";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "英雄";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "英雄";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "英雄";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "英雄";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "英雄";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "英雄";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "英雄";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "英雄";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "英雄";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "英雄";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "英雄";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "英雄";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "英雄";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "英雄";

        }
    }
    public void White27()
    {
        a = 27;
        b = 29;
        c = 54;
        d = 55;
        e = 189;
        f = 190;
        g = 191;
        h = 192;
        i = 193;
        j = 194;
        k = 195;

        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "英雄";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "英雄";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "英雄";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "英雄";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "英雄";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "英雄";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "英雄";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "英雄";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "英雄";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "英雄";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "英雄";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "英雄";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "英雄";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "英雄";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "英雄";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "英雄";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "英雄";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "英雄";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "英雄";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "英雄";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "英雄";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "英雄";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "英雄";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "英雄";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "英雄";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "英雄";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "英雄";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "英雄";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "英雄";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "英雄";

        }
    }

    public void High27()
    {
        a = 27;
        b = 29;
        c = 54;
        d = 55;
        e = 189;
        f = 190;
        g = 191;
        h = 192;
        i = 193;
        j = 194;
        k = 195;
        L = 175;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "英雄";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "英雄";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "英雄";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "英雄";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "英雄";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "英雄";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "英雄";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "英雄";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "英雄";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "英雄";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "英雄";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "英雄";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "英雄";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "英雄";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "英雄";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "英雄";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "英雄";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "英雄";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "英雄";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "英雄";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "英雄";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "英雄";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "英雄";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "英雄";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "英雄";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "英雄";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "英雄";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "英雄";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "英雄";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "英雄";

        }
    }
    public void Low27()
    {
        a = 27;
        b = 29;
        c = 54;
        d = 55;
        e = 189;
        f = 190;
        g = 191;
        h = 192;
        i = 193;
        j = 194;
        k = 195;
        L = 175;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "英雄";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "英雄";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "英雄";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "英雄";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "英雄";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "英雄";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "英雄";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "英雄";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "英雄";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "英雄";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "英雄";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "英雄";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "英雄";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "英雄";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "英雄";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "英雄";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "英雄";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "英雄";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "英雄";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "英雄";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "英雄";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "英雄";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "英雄";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "英雄";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "英雄";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "英雄";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "英雄";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "英雄";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "英雄";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "英雄";

        }
    }
    public void Hevy27()
    {
        a = 27;
        b = 29;
        c = 54;
        d = 55;
        e = 189;
        f = 190;
        g = 191;
        h = 192;
        i = 193;
        j = 194;
        k = 195;
        N = 79;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "英雄";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "英雄";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "英雄";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "英雄";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "英雄";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "英雄";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "英雄";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "英雄";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "英雄";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "英雄";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "英雄";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "英雄";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "英雄";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "英雄";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "英雄";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "英雄";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "英雄";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "英雄";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "英雄";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "英雄";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "英雄";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "英雄";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "英雄";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "英雄";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "英雄";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "英雄";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "英雄";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "英雄";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "英雄";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "英雄";

        }
    }
    public void karui27()
    {
        a = 27;
        b = 29;
        c = 54;
        d = 55;
        e = 189;
        f = 190;
        g = 191;
        h = 192;
        i = 193;
        j = 194;
        k = 195;
        N = 79;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "英雄";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "英雄";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "英雄";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "英雄";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "英雄";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "英雄";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "英雄";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "英雄";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "英雄";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "英雄";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "英雄";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "英雄";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "英雄";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "英雄";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "英雄";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "英雄";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "英雄";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "英雄";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "英雄";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "英雄";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "英雄";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "英雄";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "英雄";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "英雄";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "英雄";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "英雄";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "英雄";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "英雄";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "英雄";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "英雄";

        }
    }
    public void Black28()
    {
        a = 28;
        b = 30;
        c = 56;
        d = 57;
        e = 196;
        f = 197;
        g = 198;
        h = 199;
        i = 200;
        j = 201;
        k = 202;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "冬美";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "冬美";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "冬美";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "冬美";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "冬美";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "冬美";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "冬美";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "冬美";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "冬美";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "冬美";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "冬美";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "冬美";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "冬美";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "冬美";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "冬美";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "冬美";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "冬美";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "冬美";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "冬美";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "冬美";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "冬美";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "冬美";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "冬美";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "冬美";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "冬美";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "冬美";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "冬美";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "冬美";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "冬美";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "冬美";

        }
    }
    public void Red28()
    {

        a = 28;
        b = 30;
        c = 56;
        d = 57;
        e = 196;
        f = 197;
        g = 198;
        h = 199;
        i = 200;
        j = 201;
        k = 202;
        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "冬美";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "冬美";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "冬美";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "冬美";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "冬美";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "冬美";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "冬美";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "冬美";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "冬美";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "冬美";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "冬美";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "冬美";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "冬美";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "冬美";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "冬美";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "冬美";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "冬美";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "冬美";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "冬美";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "冬美";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "冬美";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "冬美";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "冬美";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "冬美";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "冬美";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "冬美";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "冬美";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "冬美";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "冬美";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "冬美";

        }
    }
    public void White28()
    {

        a = 28;
        b = 30;
        c = 56;
        d = 57;
        e = 196;
        f = 197;
        g = 198;
        h = 199;
        i = 200;
        j = 201;
        k = 202;
        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "冬美";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "冬美";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "冬美";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "冬美";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "冬美";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "冬美";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "冬美";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "冬美";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "冬美";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "冬美";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "冬美";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "冬美";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "冬美";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "冬美";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "冬美";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "冬美";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "冬美";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "冬美";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "冬美";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "冬美";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "冬美";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "冬美";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "冬美";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "冬美";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "冬美";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "冬美";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "冬美";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "冬美";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "冬美";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "冬美";

        }
    }

    public void High28()
    {
        a = 28;
        b = 30;
        c = 56;
        d = 57;
        e = 196;
        f = 197;
        g = 198;
        h = 199;
        i = 200;
        j = 201;
        k = 202;
        L = 167;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "冬美";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "冬美";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "冬美";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "冬美";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "冬美";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "冬美";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "冬美";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "冬美";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "冬美";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "冬美";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "冬美";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "冬美";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "冬美";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "冬美";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "冬美";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "冬美";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "冬美";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "冬美";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "冬美";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "冬美";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "冬美";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "冬美";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "冬美";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "冬美";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "冬美";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "冬美";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "冬美";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "冬美";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "冬美";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "冬美";

        }
    }
    public void Low28()
    {
        a = 28;
        b = 30;
        c = 56;
        d = 57;
        e = 196;
        f = 197;
        g = 198;
        h = 199;
        i = 200;
        j = 201;
        k = 202;
        L = 167;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "冬美";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "冬美";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "冬美";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "冬美";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "冬美";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "冬美";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "冬美";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "冬美";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "冬美";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "冬美";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "冬美";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "冬美";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "冬美";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "冬美";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "冬美";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "冬美";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "冬美";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "冬美";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "冬美";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "冬美";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "冬美";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "冬美";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "冬美";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "冬美";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "冬美";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "冬美";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "冬美";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "冬美";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "冬美";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "冬美";

        }
    }
    public void Hevy28()
    {
        a = 28;
        b = 30;
        c = 56;
        d = 57;
        e = 196;
        f = 197;
        g = 198;
        h = 199;
        i = 200;
        j = 201;
        k = 202;
        N = 60;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "冬美";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "冬美";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "冬美";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "冬美";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "冬美";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "冬美";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "冬美";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "冬美";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "冬美";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "冬美";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "冬美";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "冬美";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "冬美";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "冬美";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "冬美";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "冬美";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "冬美";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "冬美";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "冬美";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "冬美";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "冬美";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "冬美";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "冬美";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "冬美";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "冬美";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "冬美";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "冬美";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "冬美";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "冬美";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "冬美";

        }
    }
    public void karui28()
    {
        a = 28;
        b = 30;
        c = 56;
        d = 57;
        e = 196;
        f = 197;
        g = 198;
        h = 199;
        i = 200;
        j = 201;
        k = 202;
        N = 60;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "冬美";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "冬美";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "冬美";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "冬美";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "冬美";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "冬美";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "冬美";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "冬美";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "冬美";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "冬美";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "冬美";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "冬美";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "冬美";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "冬美";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "冬美";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "冬美";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "冬美";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "冬美";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "冬美";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "冬美";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "冬美";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "冬美";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "冬美";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "冬美";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "冬美";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "冬美";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "冬美";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "冬美";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "冬美";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "冬美";

        }
    }
    public void Black29()
    {
        a = 29;
        b = 31;
        c = 58;
        d = 59;
        e = 203;
        f = 204;
        g = 205;
        h = 206;
        i = 207;
        j = 208;
        k = 209;

        Black();
        if (M == 0)
        {
            memory.a = 1;
            memory.na = "小梅";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "小梅";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "小梅";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "小梅";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "小梅";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "小梅";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "小梅";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "小梅";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "小梅";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "小梅";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "小梅";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "小梅";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "小梅";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "小梅";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "小梅";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "小梅";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "小梅";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "小梅";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "小梅";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "小梅";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "小梅";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "小梅";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "小梅";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "小梅";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "小梅";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "小梅";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "小梅";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "小梅";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "小梅";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "小梅";

        }
    }
    public void Red29()
    {
        a = 29;
        b = 31;
        c = 58;
        d = 59;
        e = 203;
        f = 204;
        g = 205;
        h = 206;
        i = 207;
        j = 208;
        k = 209;


        Red();
        if (M == 0)
        {
            memory.a = 2;
            memory.na = "小梅";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "小梅";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "小梅";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "小梅";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "小梅";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "小梅";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "小梅";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "小梅";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "小梅";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "小梅";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "小梅";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "小梅";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "小梅";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "小梅";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "小梅";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "小梅";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "小梅";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "小梅";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "小梅";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "小梅";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "小梅";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "小梅";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "小梅";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "小梅";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "小梅";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "小梅";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "小梅";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "小梅";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "小梅";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "小梅";

        }
    }
    public void White29()
    {
        a = 29;
        b = 31;
        c = 58;
        d = 59;
        e = 203;
        f = 204;
        g = 205;
        h = 206;
        i = 207;
        j = 208;
        k = 209;


        White();
        if (M == 0)
        {
            memory.a = 3;
            memory.na = "小梅";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "小梅";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "小梅";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "小梅";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "小梅";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "小梅";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "小梅";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "小梅";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "小梅";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "小梅";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "小梅";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "小梅";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "小梅";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "小梅";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "小梅";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "小梅";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "小梅";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "小梅";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "小梅";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "小梅";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "小梅";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "小梅";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "小梅";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "小梅";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "小梅";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "小梅";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "小梅";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "小梅";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "小梅";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "小梅";

        }
    }

    public void High29()
    {
        a = 29;
        b = 31;
        c = 58;
        d = 59;
        e = 203;
        f = 204;
        g = 205;
        h = 206;
        i = 207;
        j = 208;
        k = 209;
        L = 128;
        High();
        if (M == 0)
        {
            memory.a = 4;
            memory.na = "小梅";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "小梅";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "小梅";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "小梅";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "小梅";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "小梅";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "小梅";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "小梅";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "小梅";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "小梅";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "小梅";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "小梅";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "小梅";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "小梅";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "小梅";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "小梅";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "小梅";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "小梅";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "小梅";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "小梅";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "小梅";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "小梅";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "小梅";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "小梅";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "小梅";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "小梅";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "小梅";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "小梅";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "小梅";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "小梅";

        }
    }
    public void Low29()
    {
        a = 29;
        b = 31;
        c = 58;
        d = 59;
        e = 203;
        f = 204;
        g = 205;
        h = 206;
        i = 207;
        j = 208;
        k = 209;
        L = 128;
        Low();
        if (M == 0)
        {
            memory.a = 5;
            memory.na = "小梅";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "小梅";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "小梅";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "小梅";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "小梅";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "小梅";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "小梅";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "小梅";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "小梅";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "小梅";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "小梅";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "小梅";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "小梅";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "小梅";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "小梅";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "小梅";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "小梅";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "小梅";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "小梅";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "小梅";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "小梅";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "小梅";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "小梅";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "小梅";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "小梅";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "小梅";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "小梅";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "小梅";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "小梅";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "小梅";

        }
    }
    public void Hevy29()
    {
        a = 29;
        b = 31;
        c = 58;
        d = 59;
        e = 203;
        f = 204;
        g = 205;
        h = 206;
        i = 207;
        j = 208;
        k = 209;
        N = 29;
        Hevy();
        if (M == 0)
        {
            memory.a = 6;
            memory.na = "小梅";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "小梅";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "小梅";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "小梅";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "小梅";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "小梅";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "小梅";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "小梅";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "小梅";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "小梅";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "小梅";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "小梅";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "小梅";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "小梅";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "小梅";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "小梅";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "小梅";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "小梅";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "小梅";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "小梅";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "小梅";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "小梅";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "小梅";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "小梅";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "小梅";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "小梅";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "小梅";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "小梅";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "小梅";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "小梅";

        }
    }
    public void karui29()
    {
        a = 29;
        b = 31;
        c = 58;
        d = 59;
        e = 203;
        f = 204;
        g = 205;
        h = 206;
        i = 207;
        j = 208;
        k = 209;
        N = 29;
        karui();
        if (M == 0)
        {
            memory.a = 7;
            memory.na = "小梅";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "小梅";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "小梅";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "小梅";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "小梅";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "小梅";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "小梅";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "小梅";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "小梅";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "小梅";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "小梅";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "小梅";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "小梅";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "小梅";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "小梅";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "小梅";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "小梅";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "小梅";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "小梅";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "小梅";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "小梅";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "小梅";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "小梅";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "小梅";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "小梅";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "小梅";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "小梅";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "小梅";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "小梅";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "小梅";

        }
    }
    public void Check()
    {
        BlackPanel.SetActive(true);


        if (characters[0].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[0].SetActive(false);
            iyas[0].SetActive(false);
            kao[0].SetActive(false);
            kakunin.SetActive(false);

            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;

            }
            count.num = 3;
            count.Plas();
            menu();


        }

    }
    public void Check2()
    {
        BlackPanel.SetActive(true);


        if (characters[1].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[1].SetActive(false);
            iyas[1].SetActive(false);
            kao[1].SetActive(false);
            kakunin.SetActive(false);

            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;

            }
            count.num = 3;
            count.Plas();
            menu();

        }

    }
    public void Check3()
    {
        BlackPanel.SetActive(true);


        if (characters[26].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[2].SetActive(false);
            iyas[2].SetActive(false);
            kao[2].SetActive(false);
            kakunin.SetActive(false);

            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;

            }
            count.num = 3;
            count.Plas();
            menu();
 

        }

    }
    public void Check4()
    {
        BlackPanel.SetActive(true);


        if (characters[2].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[3].SetActive(false);
            iyas[3].SetActive(false);
            kao[3].SetActive(false);
            kakunin.SetActive(false);

            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;

            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check5()
    {
        BlackPanel.SetActive(true);


        if (characters[3].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[4].SetActive(false);
            iyas[4].SetActive(false);
            kao[4].SetActive(false);
            kakunin.SetActive(false);
  
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;

            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check6()
    {
        BlackPanel.SetActive(true);


        if (characters[22].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
  
            Clear.SetActive(true);


        }
        else
        {
            uns[5].SetActive(false);
            iyas[5].SetActive(false);
            kao[5].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check7()
    {
        BlackPanel.SetActive(true);


        if (characters[21].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
            Clear.SetActive(true);


        }
        else
        {
            uns[6].SetActive(false);
            iyas[6].SetActive(false);
            kao[6].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check8()
    {
        BlackPanel.SetActive(true);


        if (characters[14].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
  
            Clear.SetActive(true);


        }
        else
        {
            uns[7].SetActive(false);
            iyas[7].SetActive(false);
            kao[7].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check9()
    {
        BlackPanel.SetActive(true);


        if (characters[18].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[8].SetActive(false);
            iyas[8].SetActive(false);
            kao[8].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check10()
    {
        BlackPanel.SetActive(true);


        if (characters[10].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[9].SetActive(false);
            iyas[9].SetActive(false);
            kao[9].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check11()
    {
        BlackPanel.SetActive(true);


        if (characters[23].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[10].SetActive(false);
            iyas[10].SetActive(false);
            kao[10].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check12()
    {
        BlackPanel.SetActive(true);


        if (characters[27].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);

        }
        else
        {
            uns[11].SetActive(false);
            iyas[11].SetActive(false);
            kao[11].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check13()
    {
        BlackPanel.SetActive(true);


        if (characters[8].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
            Clear.SetActive(true);


        }
        else
        {
            uns[12].SetActive(false);
            iyas[12].SetActive(false);
            kao[12].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check14()
    {
        BlackPanel.SetActive(true);


        if (characters[16].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
    
            Clear.SetActive(true);


        }
        else
        {
            uns[13].SetActive(false);
            iyas[13].SetActive(false);
            kao[13].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check15()
    {
        BlackPanel.SetActive(true);


        if (characters[15].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
 
            Clear.SetActive(true);


        }
        else
        {
            uns[14].SetActive(false);
            iyas[14].SetActive(false);
            kao[14].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check16()
    {
        BlackPanel.SetActive(true);


        if (characters[7].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[15].SetActive(false);
            iyas[15].SetActive(false);
            kao[15].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check17()
    {
        BlackPanel.SetActive(true);


        if (characters[6].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[16].SetActive(false);
            iyas[16].SetActive(false);
            kao[16].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check18()
    {
        BlackPanel.SetActive(true);


        if (characters[29].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[17].SetActive(false);
            iyas[17].SetActive(false);
            kao[17].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check19()
    {
        BlackPanel.SetActive(true);


        if (characters[25].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
            Clear.SetActive(true);


        }
        else
        {
            uns[18].SetActive(false);
            iyas[18].SetActive(false);
            kao[18].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check20()
    {
        BlackPanel.SetActive(true);


        if (characters[11].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[19].SetActive(false);
            iyas[19].SetActive(false);
            kao[19].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check21()
    {
        BlackPanel.SetActive(true);


        if (characters[9].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[20].SetActive(false);
            iyas[20].SetActive(false);
            kao[20].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check22()
    {
        BlackPanel.SetActive(true);


        if (characters[20].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);

        }
        else
        {
            uns[21].SetActive(false);
            iyas[21].SetActive(false);
            kao[21].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check23()
    {
        BlackPanel.SetActive(true);


        if (characters[12].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
            Clear.SetActive(true);


        }
        else
        {
            uns[22].SetActive(false);
            iyas[22].SetActive(false);
            kao[22].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check24()
    {
        BlackPanel.SetActive(true);


        if (characters[24].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[23].SetActive(false);
            iyas[23].SetActive(false);
            kao[23].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check25()
    {
        BlackPanel.SetActive(true);


        if (characters[17].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[24].SetActive(false);
            iyas[24].SetActive(false);
            kao[24].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check26()
    {
        BlackPanel.SetActive(true);


        if (characters[28].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[25].SetActive(false);
            iyas[25].SetActive(false);
            kao[25].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {

                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check27()
    {
        BlackPanel.SetActive(true);


        if (characters[4].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[26].SetActive(false);
            iyas[26].SetActive(false);
            kao[26].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check28()
    {
        BlackPanel.SetActive(true);


        if (characters[5].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[27].SetActive(false);
            iyas[27].SetActive(false);
            kao[27].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check29()
    {
        BlackPanel.SetActive(true);


        if (characters[19].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
            Clear.SetActive(true);


        }
        else
        {
            uns[28].SetActive(false);
            iyas[28].SetActive(false);
            kao[28].SetActive(false);
            kakunin.SetActive(false);
            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void Check30()
    {
        BlackPanel.SetActive(true);


        if (characters[13].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            uns[29].SetActive(false);
            iyas[29].SetActive(false);
            kao[29].SetActive(false);
            kakunin.SetActive(false);

            count.DaysPoint -= 3;
            count.ZannsuPoint -= 3;
            if (count.DaysPoint < 4)
            {
                soundManager.PlayBgm(gclip);
                soundManager.PlaySe(iclip);
                BlackPanel.SetActive(true);
                Over.SetActive(true);
                return;
            }
            count.num = 3;
            count.Plas();
            menu();
        }

    }
    public void menu()
    {
        a = 0;
        b = 2;
        c = 0;
        d = 1;
        e = 0;
        f = 1;
        g = 2;
        h = 3;
        i = 4;
        j = 5;
        k = 6;
        L = 173;
        N = 70;
        M++;

            if (count.DaysPoint < 4)
            {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            BlackPanel.SetActive(true);
                Over.SetActive(true);

            }

       
        soundManager.PlaySe(bclip);
        Invoke("blaky2", 1.0f);
        Invoke("Fadeout2", 2.0f);
        Invoke("fade2", 3.0f);

        panelfade.SetActive(true);
        soundManager.PlayBgm(gclip);
    }
        public void Fadeout()
    {
        rooms[b].SetActive(false);
        rooms[32].SetActive(false);
        Day.SetActive(false);

        panelfade.SetActive(false);
        rooms[33].SetActive(true);



    }
    public void Fadeout2()
    {
        rooms[33].SetActive(false);

        count.Move();
        panelfade.SetActive(false);
        rooms[32].SetActive(true);
        soundManager.PlaySe(fclip);
        BlackPanel.SetActive(false);


    }

    public void god()
    {
        rooms[32].SetActive(false);

        Qestions[c].SetActive(false);
        Qestions[d].SetActive(false);
        Qestions2[e].SetActive(false);
        Qestions2[f].SetActive(false);
        Qestions2[g].SetActive(false);
        Qestions2[h].SetActive(false);
        Qestions2[i].SetActive(false);
        Qestions2[j].SetActive(false);
        Qestions2[k].SetActive(false);

        Nos[a].SetActive(false);
        Yess[a].SetActive(false);
        Questions[a].SetActive(true);
        Day.SetActive(true);

        rooms[0].SetActive(true);


        panelfade.SetActive(false);
        soundManager.PlayBgm(hclip);


    }
    public void god2()
    {
        rooms[32].SetActive(false);

        Qestions[c].SetActive(false);
        Qestions[d].SetActive(false);
        Qestions2[e].SetActive(false);
        Qestions2[f].SetActive(false);
        Qestions2[g].SetActive(false);
        Qestions2[h].SetActive(false);
        Qestions2[i].SetActive(false);
        Qestions2[j].SetActive(false);
        Qestions2[k].SetActive(false);

        Nos[a].SetActive(false);
        Yess[a].SetActive(false);
        Questions[a].SetActive(true);
        Day.SetActive(true);

        rooms[0].SetActive(true);


        panelfade.SetActive(false);
        soundManager.PlayBgm(cclip);


    }

    public void fade()
    {

        Qestions[c].SetActive(false);
        Qestions[d].SetActive(false);
        Qestions2[e].SetActive(false);
        Qestions2[f].SetActive(false);
        Qestions2[g].SetActive(false);
        Qestions2[h].SetActive(false);
        Qestions2[i].SetActive(false);
        Qestions2[j].SetActive(false);
        Qestions2[k].SetActive(false);

        Nos[a].SetActive(false);
        Yess[a].SetActive(false);
        Questions[a].SetActive(true);




    }
    public void fade2()
    {

        Invoke("blaky2", 1.0f);
        Invoke("god2", 2.0f);
        panelfade.SetActive(true);

    }
    public void blaky()
    {
        black.fadeout = true;
        soundManager.PlayBgm(hclip);

        black.Update();

    }
    public void blaky2()
    {
        black.fadeout = true;
        soundManager.PlayBgm(gclip);

        black.Update();
        Day.SetActive(false);

    }

}





