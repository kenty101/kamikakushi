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
            memory.na = "���Y";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "���Y";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "���Y";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "���Y";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "���Y";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "���Y";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "���Y";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "���Y";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "���Y";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "���Y";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "���Y";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "���Y";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "���Y";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "���Y";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "���Y";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "���Y";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "���Y";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "���Y";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "���Y";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "���Y";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "���Y";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "���Y";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "���Y";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "���Y";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "���Y";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "���Y";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "���Y";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "���Y";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "���Y";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "���Y";

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
            memory.na = "���Y";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "���Y";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "���Y";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "���Y";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "���Y";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "���Y";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "���Y";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "���Y";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "���Y";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "���Y";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "���Y";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "���Y";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "���Y";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "���Y";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "���Y";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "���Y";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "���Y";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "���Y";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "���Y";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "���Y";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "���Y";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "���Y";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "���Y";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "���Y";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "���Y";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "���Y";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "���Y";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "���Y";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "���Y";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "���Y";

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
            memory.na = "���Y";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "���Y";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "���Y";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "���Y";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "���Y";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "���Y";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "���Y";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "���Y";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "���Y";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "���Y";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "���Y";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "���Y";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "���Y";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "���Y";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "���Y";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "���Y";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "���Y";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "���Y";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "���Y";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "���Y";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "���Y";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "���Y";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "���Y";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "���Y";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "���Y";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "���Y";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "���Y";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "���Y";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "���Y";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "���Y";

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
            memory.na = "���Y";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "���Y";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "���Y";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "���Y";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "���Y";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "���Y";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "���Y";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "���Y";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "���Y";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "���Y";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "���Y";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "���Y";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "���Y";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "���Y";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "���Y";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "���Y";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "���Y";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "���Y";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "���Y";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "���Y";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "���Y";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "���Y";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "���Y";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "���Y";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "���Y";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "���Y";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "���Y";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "���Y";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "���Y";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "���Y";

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
            memory.na = "���Y";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "���Y";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "���Y";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "���Y";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "���Y";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "���Y";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "���Y";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "���Y";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "���Y";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "���Y";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "���Y";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "���Y";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "���Y";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "���Y";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "���Y";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "���Y";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "���Y";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "���Y";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "���Y";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "���Y";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "���Y";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "���Y";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "���Y";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "���Y";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "���Y";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "���Y";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "���Y";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "���Y";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "���Y";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "���Y";

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
            memory.na = "���Y";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "���Y";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "���Y";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "���Y";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "���Y";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "���Y";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "���Y";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "���Y";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "���Y";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "���Y";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "���Y";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "���Y";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "���Y";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "���Y";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "���Y";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "���Y";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "���Y";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "���Y";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "���Y";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "���Y";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "���Y";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "���Y";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "���Y";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "���Y";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "���Y";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "���Y";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "���Y";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "���Y";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "���Y";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "���Y";

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
            memory.na = "���Y";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "���Y";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "���Y";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "���Y";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "���Y";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "���Y";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "���Y";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "���Y";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "���Y";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "���Y";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "���Y";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "���Y";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "���Y";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "���Y";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "���Y";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "���Y";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "���Y";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "���Y";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "���Y";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "���Y";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "���Y";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "���Y";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "���Y";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "���Y";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "���Y";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "���Y";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "���Y";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "���Y";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "���Y";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "���Y";

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
            memory.na = "��";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "��";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "��";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "��";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "��";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "��";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "��";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "��";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "��";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "��";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "��";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "��";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "��";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "��";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "��";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "��";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "��";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "��";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "��";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "��";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "��";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "��";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "��";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "��";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "��";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "��";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "��";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "��";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "��";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "��";

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
            memory.na = "��";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "��";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "��";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "��";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "��";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "��";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "��";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "��";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "��";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "��";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "��";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "��";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "��";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "��";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "��";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "��";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "��";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "��";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "��";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "��";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "��";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "��";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "��";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "��";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "��";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "��";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "��";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "��";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "��";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "��";

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
            memory.na = "��";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "��";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "��";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "��";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "��";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "��";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "��";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "��";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "��";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "��";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "��";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "��";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "��";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "��";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "��";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "��";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "��";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "��";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "��";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "��";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "��";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "��";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "��";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "��";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "��";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "��";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "��";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "��";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "��";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "��";

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
            memory.na = "��";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "��";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "��";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "��";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "��";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "��";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "��";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "��";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "��";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "��";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "��";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "��";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "��";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "��";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "��";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "��";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "��";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "��";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "��";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "��";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "��";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "��";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "��";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "��";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "��";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "��";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "��";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "��";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "��";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "��";

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
            memory.na = "��";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "��";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "��";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "��";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "��";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "��";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "��";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "��";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "��";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "��";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "��";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "��";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "��";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "��";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "��";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "��";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "��";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "��";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "��";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "��";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "��";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "��";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "��";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "��";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "��";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "��";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "��";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "��";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "��";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "��";

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
            memory.na = "��";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "��";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "��";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "��";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "��";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "��";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "��";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "��";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "��";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "��";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "��";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "��";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "��";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "��";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "��";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "��";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "��";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "��";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "��";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "��";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "��";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "��";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "��";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "��";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "��";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "��";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "��";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "��";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "��";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "��";

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
            memory.na = "��";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "��";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "��";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "��";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "��";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "��";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "��";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "��";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "��";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "��";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "��";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "��";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "��";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "��";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "��";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "��";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "��";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "��";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "��";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "��";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "��";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "��";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "��";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "��";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "��";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "��";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "��";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "��";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "��";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "��";

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
            memory.na = "B��";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "B��";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "B��";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "B��";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "B��";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "B��";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "B��";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "B��";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "B��";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "B��";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "B��";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "B��";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "B��";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "B��";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "B��";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "B��";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "B��";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "B��";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "B��";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "B��";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "B��";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "B��";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "B��";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "B��";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "B��";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "B��";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "B��";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "B��";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "B��";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "B��";

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
            memory.na = "B��";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "B��";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "B��";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "B��";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "B��";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "B��";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "B��";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "B��";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "B��";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "B��";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "B��";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "B��";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "B��";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "B��";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "B��";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "B��";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "B��";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "B��";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "B��";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "B��";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "B��";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "B��";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "B��";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "B��";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "B��";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "B��";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "B��";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "B��";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "B��";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "B��";

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
            memory.na = "B��";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "B��";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "B��";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "B��";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "B��";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "B��";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "B��";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "B��";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "B��";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "B��";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "B��";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "B��";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "B��";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "B��";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "B��";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "B��";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "B��";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "B��";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "B��";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "B��";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "B��";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "B��";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "B��";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "B��";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "B��";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "B��";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "B��";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "B��";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "B��";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "B��";

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
            memory.na = "B��";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "B��";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "B��";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "B��";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "B��";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "B��";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "B��";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "B��";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "B��";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "B��";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "B��";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "B��";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "B��";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "B��";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "B��";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "B��";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "B��";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "B��";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "B��";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "B��";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "B��";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "B��";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "B��";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "B��";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "B��";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "B��";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "B��";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "B��";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "B��";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "B��";

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
            memory.na = "B��";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "B��";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "B��";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "B��";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "B��";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "B��";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "B��";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "B��";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "B��";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "B��";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "B��";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "B��";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "B��";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "B��";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "B��";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "B��";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "B��";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "B��";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "B��";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "B��";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "B��";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "B��";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "B��";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "B��";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "B��";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "B��";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "B��";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "B��";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "B��";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "B��";

        }
    }
    public void Hevy2()
    �@�@{
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
            memory.na = "B��";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "B��";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "B��";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "B��";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "B��";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "B��";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "B��";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "B��";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "B��";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "B��";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "B��";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "B��";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "B��";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "B��";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "B��";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "B��";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "B��";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "B��";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "B��";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "B��";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "B��";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "B��";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "B��";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "B��";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "B��";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "B��";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "B��";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "B��";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "B��";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "B��";

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
            memory.na = "B��";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "B��";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "B��";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "B��";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "B��";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "B��";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "B��";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "B��";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "B��";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "B��";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "B��";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "B��";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "B��";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "B��";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "B��";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "B��";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "B��";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "B��";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "B��";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "B��";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "B��";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "B��";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "B��";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "B��";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "B��";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "B��";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "B��";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "B��";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "B��";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "B��";

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
            memory.na = "���C�R";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "���C�R";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "���C�R";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "���C�R";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "���C�R";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "���C�R";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "���C�R";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "���C�R";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "���C�R";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "���C�R";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "���C�R";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "���C�R";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "���C�R";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "���C�R";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "���C�R";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "���C�R";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "���C�R";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "���C�R";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "���C�R";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "���C�R";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "���C�R";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "���C�R";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "���C�R";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "���C�R";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "���C�R";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "���C�R";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "���C�R";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "���C�R";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "���C�R";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "���C�R";

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
            memory.na = "���C�R";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "���C�R";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "���C�R";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "���C�R";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "���C�R";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "���C�R";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "���C�R";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "���C�R";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "���C�R";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "���C�R";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "���C�R";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "���C�R";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "���C�R";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "���C�R";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "���C�R";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "���C�R";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "���C�R";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "���C�R";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "���C�R";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "���C�R";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "���C�R";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "���C�R";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "���C�R";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "���C�R";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "���C�R";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "���C�R";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "���C�R";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "���C�R";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "���C�R";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "���C�R";

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
            memory.na = "���C�R";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "���C�R";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "���C�R";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "���C�R";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "���C�R";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "���C�R";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "���C�R";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "���C�R";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "���C�R";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "���C�R";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "���C�R";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "���C�R";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "���C�R";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "���C�R";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "���C�R";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "���C�R";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "���C�R";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "���C�R";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "���C�R";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "���C�R";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "���C�R";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "���C�R";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "���C�R";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "���C�R";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "���C�R";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "���C�R";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "���C�R";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "���C�R";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "���C�R";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "���C�R";

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
            memory.na = "���C�R";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "���C�R";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "���C�R";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "���C�R";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "���C�R";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "���C�R";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "���C�R";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "���C�R";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "���C�R";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "���C�R";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "���C�R";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "���C�R";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "���C�R";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "���C�R";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "���C�R";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "���C�R";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "���C�R";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "���C�R";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "���C�R";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "���C�R";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "���C�R";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "���C�R";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "���C�R";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "���C�R";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "���C�R";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "���C�R";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "���C�R";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "���C�R";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "���C�R";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "���C�R";

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
            memory.na = "���C�R";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "���C�R";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "���C�R";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "���C�R";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "���C�R";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "���C�R";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "���C�R";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "���C�R";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "���C�R";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "���C�R";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "���C�R";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "���C�R";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "���C�R";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "���C�R";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "���C�R";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "���C�R";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "���C�R";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "���C�R";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "���C�R";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "���C�R";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "���C�R";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "���C�R";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "���C�R";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "���C�R";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "���C�R";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "���C�R";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "���C�R";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "���C�R";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "���C�R";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "���C�R";

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
            memory.na = "���C�R";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "���C�R";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "���C�R";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "���C�R";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "���C�R";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "���C�R";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "���C�R";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "���C�R";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "���C�R";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "���C�R";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "���C�R";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "���C�R";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "���C�R";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "���C�R";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "���C�R";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "���C�R";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "���C�R";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "���C�R";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "���C�R";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "���C�R";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "���C�R";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "���C�R";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "���C�R";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "���C�R";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "���C�R";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "���C�R";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "���C�R";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "���C�R";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "���C�R";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "���C�R";

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
            memory.na = "���C�R";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "���C�R";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "���C�R";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "���C�R";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "���C�R";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "���C�R";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "���C�R";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "���C�R";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "���C�R";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "���C�R";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "���C�R";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "���C�R";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "���C�R";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "���C�R";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "���C�R";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "���C�R";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "���C�R";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "���C�R";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "���C�R";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "���C�R";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "���C�R";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "���C�R";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "���C�R";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "���C�R";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "���C�R";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "���C�R";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "���C�R";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "���C�R";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "���C�R";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "���C�R";

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
            memory.na = "�Ďq";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�Ďq";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�Ďq";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�Ďq";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�Ďq";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�Ďq";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�Ďq";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�Ďq";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�Ďq";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�Ďq";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�Ďq";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�Ďq";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�Ďq";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�Ďq";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�Ďq";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�Ďq";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�Ďq";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�Ďq";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�Ďq";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�Ďq";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�Ďq";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�Ďq";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�Ďq";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�Ďq";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�Ďq";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�Ďq";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�Ďq";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�Ďq";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�Ďq";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�Ďq";

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
            memory.na = "�Ďq";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�Ďq";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�Ďq";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�Ďq";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�Ďq";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�Ďq";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�Ďq";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�Ďq";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�Ďq";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�Ďq";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�Ďq";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�Ďq";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�Ďq";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�Ďq";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�Ďq";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�Ďq";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�Ďq";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�Ďq";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�Ďq";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�Ďq";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�Ďq";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�Ďq";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�Ďq";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�Ďq";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�Ďq";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�Ďq";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�Ďq";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�Ďq";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�Ďq";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�Ďq";

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
            memory.na = "�Ďq";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�Ďq";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�Ďq";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�Ďq";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�Ďq";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�Ďq";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�Ďq";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�Ďq";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�Ďq";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�Ďq";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�Ďq";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�Ďq";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�Ďq";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�Ďq";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�Ďq";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�Ďq";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�Ďq";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�Ďq";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�Ďq";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�Ďq";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�Ďq";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�Ďq";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�Ďq";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�Ďq";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�Ďq";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�Ďq";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�Ďq";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�Ďq";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�Ďq";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�Ďq";

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
            memory.na = "�Ďq";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�Ďq";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�Ďq";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�Ďq";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�Ďq";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�Ďq";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�Ďq";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�Ďq";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�Ďq";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�Ďq";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�Ďq";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�Ďq";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�Ďq";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�Ďq";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�Ďq";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�Ďq";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�Ďq";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�Ďq";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�Ďq";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�Ďq";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�Ďq";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�Ďq";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�Ďq";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�Ďq";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�Ďq";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�Ďq";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�Ďq";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�Ďq";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�Ďq";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�Ďq";

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
            memory.na = "�Ďq";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�Ďq";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�Ďq";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�Ďq";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�Ďq";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�Ďq";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�Ďq";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�Ďq";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�Ďq";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�Ďq";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�Ďq";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�Ďq";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�Ďq";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�Ďq";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�Ďq";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�Ďq";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�Ďq";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�Ďq";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�Ďq";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�Ďq";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�Ďq";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�Ďq";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�Ďq";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�Ďq";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�Ďq";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�Ďq";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�Ďq";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�Ďq";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�Ďq";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�Ďq";

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
            memory.na = "�Ďq";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�Ďq";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�Ďq";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�Ďq";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�Ďq";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�Ďq";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�Ďq";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�Ďq";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�Ďq";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�Ďq";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�Ďq";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�Ďq";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�Ďq";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�Ďq";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�Ďq";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�Ďq";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�Ďq";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�Ďq";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�Ďq";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�Ďq";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�Ďq";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�Ďq";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�Ďq";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�Ďq";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�Ďq";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�Ďq";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�Ďq";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�Ďq";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�Ďq";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�Ďq";

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
            memory.na = "�Ďq";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�Ďq";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�Ďq";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�Ďq";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�Ďq";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�Ďq";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�Ďq";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�Ďq";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�Ďq";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�Ďq";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�Ďq";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�Ďq";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�Ďq";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�Ďq";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�Ďq";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�Ďq";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�Ďq";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�Ďq";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�Ďq";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�Ďq";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�Ďq";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�Ďq";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�Ďq";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�Ďq";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�Ďq";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�Ďq";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�Ďq";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�Ďq";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�Ďq";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�Ďq";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "����";

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
            memory.na = "���b�J";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "���b�J";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "���b�J";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "���b�J";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "���b�J";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "���b�J";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "���b�J";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "���b�J";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "���b�J";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "���b�J";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "���b�J";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "���b�J";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "���b�J";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "���b�J";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "���b�J";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "���b�J";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "���b�J";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "���b�J";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "���b�J";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "���b�J";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "���b�J";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "���b�J";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "���b�J";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "���b�J";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "���b�J";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "���b�J";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "���b�J";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "���b�J";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "���b�J";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "���b�J";

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
            memory.na = "���b�J";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "���b�J";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "���b�J";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "���b�J";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "���b�J";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "���b�J";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "���b�J";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "���b�J";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "���b�J";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "���b�J";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "���b�J";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "���b�J";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "���b�J";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "���b�J";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "���b�J";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "���b�J";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "���b�J";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "���b�J";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "���b�J";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "���b�J";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "���b�J";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "���b�J";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "���b�J";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "���b�J";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "���b�J";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "���b�J";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "���b�J";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "���b�J";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "���b�J";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "���b�J";

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
            memory.na = "���b�J";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "���b�J";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "���b�J";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "���b�J";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "���b�J";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "���b�J";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "���b�J";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "���b�J";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "���b�J";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "���b�J";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "���b�J";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "���b�J";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "���b�J";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "���b�J";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "���b�J";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "���b�J";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "���b�J";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "���b�J";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "���b�J";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "���b�J";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "���b�J";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "���b�J";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "���b�J";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "���b�J";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "���b�J";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "���b�J";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "���b�J";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "���b�J";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "���b�J";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "���b�J";

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
            memory.na = "���b�J";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "���b�J";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "���b�J";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "���b�J";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "���b�J";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "���b�J";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "���b�J";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "���b�J";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "���b�J";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "���b�J";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "���b�J";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "���b�J";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "���b�J";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "���b�J";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "���b�J";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "���b�J";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "���b�J";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "���b�J";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "���b�J";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "���b�J";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "���b�J";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "���b�J";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "���b�J";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "���b�J";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "���b�J";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "���b�J";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "���b�J";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "���b�J";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "���b�J";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "���b�J";

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
            memory.na = "���b�J";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "���b�J";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "���b�J";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "���b�J";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "���b�J";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "���b�J";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "���b�J";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "���b�J";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "���b�J";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "���b�J";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "���b�J";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "���b�J";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "���b�J";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "���b�J";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "���b�J";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "���b�J";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "���b�J";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "���b�J";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "���b�J";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "���b�J";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "���b�J";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "���b�J";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "���b�J";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "���b�J";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "���b�J";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "���b�J";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "���b�J";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "���b�J";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "���b�J";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "���b�J";

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
            memory.na = "���b�J";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "���b�J";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "���b�J";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "���b�J";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "���b�J";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "���b�J";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "���b�J";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "���b�J";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "���b�J";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "���b�J";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "���b�J";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "���b�J";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "���b�J";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "���b�J";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "���b�J";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "���b�J";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "���b�J";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "���b�J";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "���b�J";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "���b�J";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "���b�J";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "���b�J";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "���b�J";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "���b�J";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "���b�J";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "���b�J";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "���b�J";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "���b�J";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "���b�J";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "���b�J";

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
            memory.na = "���b�J";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "���b�J";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "���b�J";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "���b�J";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "���b�J";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "���b�J";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "���b�J";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "���b�J";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "���b�J";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "���b�J";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "���b�J";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "���b�J";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "���b�J";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "���b�J";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "���b�J";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "���b�J";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "���b�J";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "���b�J";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "���b�J";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "���b�J";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "���b�J";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "���b�J";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "���b�J";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "���b�J";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "���b�J";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "���b�J";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "���b�J";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "���b�J";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "���b�J";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "���b�J";

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
            memory.na = "�l��";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�l��";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�l��";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�l��";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�l��";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�l��";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�l��";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�l��";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�l��";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�l��";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�l��";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�l��";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�l��";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�l��";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�l��";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�l��";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�l��";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�l��";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�l��";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�l��";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�l��";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�l��";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�l��";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�l��";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�l��";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�l��";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�l��";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�l��";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�l��";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�l��";

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
            memory.na = "�l��";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�l��";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�l��";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�l��";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�l��";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�l��";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�l��";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�l��";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�l��";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�l��";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�l��";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�l��";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�l��";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�l��";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�l��";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�l��";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�l��";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�l��";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�l��";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�l��";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�l��";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�l��";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�l��";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�l��";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�l��";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�l��";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�l��";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�l��";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�l��";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�l��";

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
            memory.na = "�l��";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�l��";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�l��";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�l��";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�l��";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�l��";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�l��";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�l��";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�l��";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�l��";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�l��";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�l��";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�l��";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�l��";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�l��";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�l��";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�l��";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�l��";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�l��";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�l��";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�l��";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�l��";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�l��";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�l��";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�l��";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�l��";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�l��";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�l��";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�l��";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�l��";

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
            memory.na = "�l��";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�l��";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�l��";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�l��";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�l��";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�l��";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�l��";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�l��";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�l��";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�l��";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�l��";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�l��";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�l��";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�l��";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�l��";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�l��";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�l��";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�l��";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�l��";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�l��";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�l��";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�l��";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�l��";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�l��";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�l��";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�l��";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�l��";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�l��";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�l��";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�l��";

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
            memory.na = "�l��";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�l��";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�l��";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�l��";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�l��";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�l��";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�l��";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�l��";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�l��";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�l��";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�l��";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�l��";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�l��";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�l��";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�l��";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�l��";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�l��";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�l��";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�l��";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�l��";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�l��";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�l��";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�l��";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�l��";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�l��";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�l��";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�l��";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�l��";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�l��";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�l��";

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
            memory.na = "�l��";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�l��";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�l��";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�l��";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�l��";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�l��";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�l��";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�l��";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�l��";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�l��";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�l��";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�l��";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�l��";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�l��";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�l��";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�l��";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�l��";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�l��";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�l��";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�l��";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�l��";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�l��";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�l��";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�l��";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�l��";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�l��";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�l��";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�l��";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�l��";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�l��";

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
            memory.na = "�l��";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�l��";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�l��";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�l��";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�l��";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�l��";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�l��";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�l��";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�l��";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�l��";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�l��";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�l��";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�l��";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�l��";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�l��";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�l��";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�l��";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�l��";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�l��";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�l��";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�l��";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�l��";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�l��";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�l��";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�l��";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�l��";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�l��";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�l��";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�l��";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�l��";

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
            memory.na = "�鑠";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�鑠";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�鑠";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�鑠";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�鑠";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�鑠";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�鑠";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�鑠";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�鑠";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�鑠";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�鑠";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�鑠";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�鑠";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�鑠";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�鑠";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�鑠";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�鑠";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�鑠";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�鑠";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�鑠";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�鑠";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�鑠";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�鑠";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�鑠";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�鑠";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�鑠";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�鑠";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�鑠";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�鑠";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�鑠";

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
            memory.na = "�鑠";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�鑠";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�鑠";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�鑠";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�鑠";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�鑠";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�鑠";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�鑠";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�鑠";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�鑠";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�鑠";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�鑠";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�鑠";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�鑠";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�鑠";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�鑠";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�鑠";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�鑠";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�鑠";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�鑠";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�鑠";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�鑠";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�鑠";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�鑠";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�鑠";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�鑠";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�鑠";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�鑠";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�鑠";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�鑠";

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
            memory.na = "�鑠";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�鑠";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�鑠";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�鑠";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�鑠";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�鑠";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�鑠";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�鑠";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�鑠";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�鑠";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�鑠";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�鑠";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�鑠";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�鑠";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�鑠";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�鑠";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�鑠";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�鑠";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�鑠";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�鑠";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�鑠";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�鑠";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�鑠";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�鑠";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�鑠";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�鑠";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�鑠";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�鑠";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�鑠";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�鑠";

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
            memory.na = "�鑠";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�鑠";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�鑠";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�鑠";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�鑠";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�鑠";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�鑠";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�鑠";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�鑠";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�鑠";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�鑠";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�鑠";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�鑠";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�鑠";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�鑠";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�鑠";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�鑠";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�鑠";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�鑠";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�鑠";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�鑠";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�鑠";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�鑠";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�鑠";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�鑠";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�鑠";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�鑠";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�鑠";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�鑠";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�鑠";

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
            memory.na = "�鑠";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�鑠";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�鑠";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�鑠";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�鑠";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�鑠";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�鑠";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�鑠";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�鑠";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�鑠";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�鑠";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�鑠";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�鑠";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�鑠";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�鑠";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�鑠";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�鑠";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�鑠";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�鑠";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�鑠";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�鑠";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�鑠";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�鑠";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�鑠";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�鑠";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�鑠";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�鑠";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�鑠";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�鑠";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�鑠";

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
            memory.na = "�鑠";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�鑠";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�鑠";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�鑠";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�鑠";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�鑠";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�鑠";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�鑠";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�鑠";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�鑠";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�鑠";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�鑠";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�鑠";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�鑠";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�鑠";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�鑠";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�鑠";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�鑠";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�鑠";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�鑠";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�鑠";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�鑠";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�鑠";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�鑠";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�鑠";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�鑠";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�鑠";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�鑠";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�鑠";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�鑠";

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
            memory.na = "�鑠";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�鑠";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�鑠";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�鑠";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�鑠";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�鑠";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�鑠";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�鑠";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�鑠";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�鑠";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�鑠";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�鑠";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�鑠";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�鑠";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�鑠";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�鑠";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�鑠";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�鑠";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�鑠";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�鑠";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�鑠";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�鑠";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�鑠";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�鑠";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�鑠";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�鑠";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�鑠";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�鑠";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�鑠";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�鑠";

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
            memory.na = "�܂�����";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�܂�����";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�܂�����";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�܂�����";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�܂�����";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�܂�����";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�܂�����";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�܂�����";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�܂�����";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�܂�����";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�܂�����";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�܂�����";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�܂�����";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�܂�����";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�܂�����";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�܂�����";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�܂�����";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�܂�����";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�܂�����";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�܂�����";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�܂�����";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�܂�����";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�܂�����";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�܂�����";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�܂�����";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�܂�����";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�܂�����";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�܂�����";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�܂�����";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�܂�����";

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
            memory.na = "�܂�����";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�܂�����";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�܂�����";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�܂�����";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�܂�����";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�܂�����";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�܂�����";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�܂�����";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�܂�����";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�܂�����";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�܂�����";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�܂�����";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�܂�����";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�܂�����";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�܂�����";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�܂�����";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�܂�����";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�܂�����";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�܂�����";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�܂�����";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�܂�����";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�܂�����";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�܂�����";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�܂�����";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�܂�����";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�܂�����";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�܂�����";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�܂�����";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�܂�����";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�܂�����";

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
            memory.na = "�܂�����";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�܂�����";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�܂�����";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�܂�����";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�܂�����";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�܂�����";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�܂�����";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�܂�����";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�܂�����";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�܂�����";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�܂�����";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�܂�����";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�܂�����";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�܂�����";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�܂�����";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�܂�����";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�܂�����";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�܂�����";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�܂�����";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�܂�����";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�܂�����";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�܂�����";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�܂�����";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�܂�����";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�܂�����";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�܂�����";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�܂�����";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�܂�����";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�܂�����";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�܂�����";

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
            memory.na = "�܂�����";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�܂�����";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�܂�����";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�܂�����";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�܂�����";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�܂�����";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�܂�����";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�܂�����";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�܂�����";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�܂�����";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�܂�����";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�܂�����";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�܂�����";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�܂�����";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�܂�����";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�܂�����";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�܂�����";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�܂�����";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�܂�����";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�܂�����";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�܂�����";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�܂�����";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�܂�����";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�܂�����";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�܂�����";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�܂�����";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�܂�����";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�܂�����";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�܂�����";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�܂�����";

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
            memory.na = "�܂�����";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�܂�����";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�܂�����";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�܂�����";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�܂�����";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�܂�����";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�܂�����";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�܂�����";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�܂�����";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�܂�����";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�܂�����";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�܂�����";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�܂�����";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�܂�����";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�܂�����";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�܂�����";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�܂�����";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�܂�����";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�܂�����";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�܂�����";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�܂�����";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�܂�����";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�܂�����";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�܂�����";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�܂�����";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�܂�����";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�܂�����";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�܂�����";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�܂�����";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�܂�����";

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
            memory.na = "�܂�����";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�܂�����";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�܂�����";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�܂�����";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�܂�����";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�܂�����";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�܂�����";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�܂�����";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�܂�����";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�܂�����";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�܂�����";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�܂�����";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�܂�����";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�܂�����";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�܂�����";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�܂�����";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�܂�����";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�܂�����";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�܂�����";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�܂�����";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�܂�����";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�܂�����";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�܂�����";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�܂�����";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�܂�����";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�܂�����";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�܂�����";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�܂�����";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�܂�����";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�܂�����";

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
            memory.na = "�܂�����";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�܂�����";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�܂�����";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�܂�����";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�܂�����";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�܂�����";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�܂�����";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�܂�����";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�܂�����";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�܂�����";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�܂�����";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�܂�����";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�܂�����";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�܂�����";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�܂�����";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�܂�����";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�܂�����";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�܂�����";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�܂�����";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�܂�����";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�܂�����";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�܂�����";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�܂�����";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�܂�����";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�܂�����";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�܂�����";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�܂�����";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�܂�����";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�܂�����";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�܂�����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "����";

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
            memory.na = "�ߐ{��";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�ߐ{��";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�ߐ{��";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�ߐ{��";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�ߐ{��";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�ߐ{��";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�ߐ{��";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�ߐ{��";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�ߐ{��";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�ߐ{��";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�ߐ{��";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�ߐ{��";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�ߐ{��";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�ߐ{��";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�ߐ{��";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�ߐ{��";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�ߐ{��";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�ߐ{��";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�ߐ{��";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�ߐ{��";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�ߐ{��";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�ߐ{��";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�ߐ{��";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�ߐ{��";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�ߐ{��";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�ߐ{��";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�ߐ{��";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�ߐ{��";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�ߐ{��";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�ߐ{��";

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
            memory.na = "�ߐ{��";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�ߐ{��";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�ߐ{��";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�ߐ{��";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�ߐ{��";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�ߐ{��";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�ߐ{��";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�ߐ{��";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�ߐ{��";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�ߐ{��";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�ߐ{��";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�ߐ{��";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�ߐ{��";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�ߐ{��";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�ߐ{��";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�ߐ{��";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�ߐ{��";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�ߐ{��";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�ߐ{��";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�ߐ{��";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�ߐ{��";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�ߐ{��";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�ߐ{��";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�ߐ{��";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�ߐ{��";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�ߐ{��";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�ߐ{��";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�ߐ{��";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�ߐ{��";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�ߐ{��";

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
            memory.na = "�ߐ{��";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�ߐ{��";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�ߐ{��";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�ߐ{��";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�ߐ{��";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�ߐ{��";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�ߐ{��";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�ߐ{��";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�ߐ{��";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�ߐ{��";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�ߐ{��";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�ߐ{��";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�ߐ{��";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�ߐ{��";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�ߐ{��";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�ߐ{��";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�ߐ{��";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�ߐ{��";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�ߐ{��";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�ߐ{��";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�ߐ{��";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�ߐ{��";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�ߐ{��";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�ߐ{��";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�ߐ{��";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�ߐ{��";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�ߐ{��";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�ߐ{��";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�ߐ{��";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�ߐ{��";

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
            memory.na = "�ߐ{��";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�ߐ{��";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�ߐ{��";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�ߐ{��";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�ߐ{��";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�ߐ{��";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�ߐ{��";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�ߐ{��";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�ߐ{��";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�ߐ{��";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�ߐ{��";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�ߐ{��";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�ߐ{��";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�ߐ{��";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�ߐ{��";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�ߐ{��";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�ߐ{��";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�ߐ{��";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�ߐ{��";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�ߐ{��";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�ߐ{��";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�ߐ{��";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�ߐ{��";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�ߐ{��";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�ߐ{��";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�ߐ{��";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�ߐ{��";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�ߐ{��";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�ߐ{��";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�ߐ{��";

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
            memory.na = "�ߐ{��";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�ߐ{��";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�ߐ{��";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�ߐ{��";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�ߐ{��";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�ߐ{��";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�ߐ{��";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�ߐ{��";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�ߐ{��";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�ߐ{��";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�ߐ{��";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�ߐ{��";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�ߐ{��";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�ߐ{��";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�ߐ{��";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�ߐ{��";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�ߐ{��";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�ߐ{��";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�ߐ{��";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�ߐ{��";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�ߐ{��";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�ߐ{��";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�ߐ{��";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�ߐ{��";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�ߐ{��";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�ߐ{��";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�ߐ{��";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�ߐ{��";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�ߐ{��";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�ߐ{��";

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
            memory.na = "�ߐ{��";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�ߐ{��";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�ߐ{��";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�ߐ{��";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�ߐ{��";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�ߐ{��";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�ߐ{��";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�ߐ{��";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�ߐ{��";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�ߐ{��";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�ߐ{��";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�ߐ{��";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�ߐ{��";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�ߐ{��";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�ߐ{��";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�ߐ{��";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�ߐ{��";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�ߐ{��";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�ߐ{��";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�ߐ{��";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�ߐ{��";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�ߐ{��";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�ߐ{��";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�ߐ{��";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�ߐ{��";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�ߐ{��";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�ߐ{��";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�ߐ{��";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�ߐ{��";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�ߐ{��";

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
            memory.na = "�ߐ{��";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�ߐ{��";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�ߐ{��";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�ߐ{��";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�ߐ{��";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�ߐ{��";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�ߐ{��";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�ߐ{��";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�ߐ{��";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�ߐ{��";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�ߐ{��";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�ߐ{��";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�ߐ{��";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�ߐ{��";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�ߐ{��";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�ߐ{��";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�ߐ{��";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�ߐ{��";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�ߐ{��";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�ߐ{��";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�ߐ{��";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�ߐ{��";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�ߐ{��";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�ߐ{��";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�ߐ{��";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�ߐ{��";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�ߐ{��";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�ߐ{��";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�ߐ{��";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�ߐ{��";

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
            memory.na = "���";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "���";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "���";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "���";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "���";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "���";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "���";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "���";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "���";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "���";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "���";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "���";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "���";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "���";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "���";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "���";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "���";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "���";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "���";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "���";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "���";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "���";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "���";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "���";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "���";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "���";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "���";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "���";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "���";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "���";

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
            memory.na = "���";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "���";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "���";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "���";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "���";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "���";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "���";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "���";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "���";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "���";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "���";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "���";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "���";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "���";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "���";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "���";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "���";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "���";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "���";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "���";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "���";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "���";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "���";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "���";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "���";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "���";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "���";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "���";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "���";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "���";

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
            memory.na = "���";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "���";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "���";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "���";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "���";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "���";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "���";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "���";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "���";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "���";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "���";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "���";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "���";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "���";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "���";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "���";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "���";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "���";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "���";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "���";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "���";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "���";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "���";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "���";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "���";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "���";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "���";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "���";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "���";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "���";

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
            memory.na = "���";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "���";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "���";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "���";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "���";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "���";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "���";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "���";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "���";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "���";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "���";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "���";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "���";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "���";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "���";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "���";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "���";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "���";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "���";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "���";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "���";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "���";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "���";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "���";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "���";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "���";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "���";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "���";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "���";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "���";

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
            memory.na = "���";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "���";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "���";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "���";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "���";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "���";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "���";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "���";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "���";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "���";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "���";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "���";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "���";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "���";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "���";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "���";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "���";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "���";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "���";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "���";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "���";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "���";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "���";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "���";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "���";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "���";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "���";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "���";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "���";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "���";

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
            memory.na = "���";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "���";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "���";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "���";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "���";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "���";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "���";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "���";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "���";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "���";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "���";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "���";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "���";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "���";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "���";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "���";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "���";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "���";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "���";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "���";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "���";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "���";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "���";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "���";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "���";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "���";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "���";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "���";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "���";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "���";

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
            memory.na = "���";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "���";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "���";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "���";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "���";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "���";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "���";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "���";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "���";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "���";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "���";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "���";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "���";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "���";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "���";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "���";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "���";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "���";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "���";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "���";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "���";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "���";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "���";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "���";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "���";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "���";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "���";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "���";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "���";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "���";

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
            memory.na = "�܂�q";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�܂�q";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�܂�q";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�܂�q";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�܂�q";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�܂�q";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�܂�q";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�܂�q";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�܂�q";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�܂�q";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�܂�q";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�܂�q";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�܂�q";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�܂�q";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�܂�q";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�܂�q";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�܂�q";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�܂�q";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�܂�q";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�܂�q";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�܂�q";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�܂�q";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�܂�q";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�܂�q";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�܂�q";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�܂�q";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�܂�q";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�܂�q";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�܂�q";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�܂�q";

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
            memory.na = "�܂�q";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�܂�q";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�܂�q";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�܂�q";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�܂�q";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�܂�q";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�܂�q";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�܂�q";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�܂�q";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�܂�q";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�܂�q";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�܂�q";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�܂�q";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�܂�q";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�܂�q";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�܂�q";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�܂�q";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�܂�q";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�܂�q";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�܂�q";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�܂�q";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�܂�q";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�܂�q";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�܂�q";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�܂�q";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�܂�q";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�܂�q";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�܂�q";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�܂�q";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�܂�q";

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
            memory.na = "�܂�q";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�܂�q";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�܂�q";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�܂�q";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�܂�q";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�܂�q";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�܂�q";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�܂�q";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�܂�q";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�܂�q";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�܂�q";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�܂�q";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�܂�q";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�܂�q";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�܂�q";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�܂�q";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�܂�q";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�܂�q";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�܂�q";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�܂�q";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�܂�q";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�܂�q";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�܂�q";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�܂�q";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�܂�q";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�܂�q";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�܂�q";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�܂�q";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�܂�q";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�܂�q";

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
            memory.na = "�܂�q";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�܂�q";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�܂�q";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�܂�q";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�܂�q";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�܂�q";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�܂�q";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�܂�q";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�܂�q";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�܂�q";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�܂�q";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�܂�q";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�܂�q";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�܂�q";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�܂�q";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�܂�q";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�܂�q";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�܂�q";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�܂�q";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�܂�q";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�܂�q";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�܂�q";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�܂�q";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�܂�q";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�܂�q";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�܂�q";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�܂�q";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�܂�q";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�܂�q";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�܂�q";

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
            memory.na = "�܂�q";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�܂�q";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�܂�q";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�܂�q";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�܂�q";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�܂�q";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�܂�q";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�܂�q";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�܂�q";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�܂�q";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�܂�q";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�܂�q";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�܂�q";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�܂�q";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�܂�q";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�܂�q";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�܂�q";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�܂�q";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�܂�q";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�܂�q";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�܂�q";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�܂�q";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�܂�q";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�܂�q";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�܂�q";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�܂�q";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�܂�q";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�܂�q";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�܂�q";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�܂�q";

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
            memory.na = "�܂�q";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�܂�q";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�܂�q";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�܂�q";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�܂�q";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�܂�q";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�܂�q";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�܂�q";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�܂�q";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�܂�q";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�܂�q";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�܂�q";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�܂�q";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�܂�q";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�܂�q";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�܂�q";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�܂�q";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�܂�q";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�܂�q";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�܂�q";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�܂�q";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�܂�q";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�܂�q";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�܂�q";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�܂�q";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�܂�q";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�܂�q";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�܂�q";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�܂�q";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�܂�q";

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
            memory.na = "�܂�q";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�܂�q";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�܂�q";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�܂�q";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�܂�q";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�܂�q";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�܂�q";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�܂�q";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�܂�q";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�܂�q";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�܂�q";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�܂�q";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�܂�q";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�܂�q";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�܂�q";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�܂�q";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�܂�q";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�܂�q";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�܂�q";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�܂�q";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�܂�q";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�܂�q";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�܂�q";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�܂�q";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�܂�q";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�܂�q";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�܂�q";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�܂�q";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�܂�q";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�܂�q";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "����";

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
            memory.na = "����";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "����";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "����";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "����";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "����";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "����";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "����";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "����";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "����";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "����";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "����";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "����";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "����";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "����";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "����";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "����";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "����";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "����";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "����";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "����";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "����";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "����";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "����";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "����";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "����";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "����";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "����";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "����";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "����";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "����";

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
            memory.na = "���I";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "���I";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "���I";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "���I";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "���I";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "���I";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "���I";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "���I";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "���I";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "���I";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "���I";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "���I";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "���I";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "���I";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "���I";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "���I";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "���I";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "���I";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "���I";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "���I";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "���I";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "���I";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "���I";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "���I";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "���I";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "���I";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "���I";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "���I";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "���I";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "���I";

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
            memory.na = "���I";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "���I";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "���I";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "���I";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "���I";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "���I";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "���I";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "���I";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "���I";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "���I";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "���I";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "���I";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "���I";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "���I";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "���I";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "���I";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "���I";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "���I";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "���I";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "���I";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "���I";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "���I";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "���I";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "���I";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "���I";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "���I";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "���I";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "���I";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "���I";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "���I";

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
            memory.na = "���I";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "���I";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "���I";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "���I";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "���I";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "���I";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "���I";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "���I";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "���I";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "���I";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "���I";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "���I";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "���I";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "���I";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "���I";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "���I";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "���I";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "���I";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "���I";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "���I";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "���I";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "���I";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "���I";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "���I";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "���I";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "���I";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "���I";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "���I";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "���I";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "���I";

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
            memory.na = "���I";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "���I";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "���I";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "���I";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "���I";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "���I";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "���I";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "���I";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "���I";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "���I";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "���I";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "���I";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "���I";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "���I";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "���I";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "���I";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "���I";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "���I";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "���I";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "���I";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "���I";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "���I";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "���I";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "���I";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "���I";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "���I";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "���I";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "���I";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "���I";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "���I";

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
            memory.na = "���I";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "���I";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "���I";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "���I";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "���I";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "���I";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "���I";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "���I";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "���I";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "���I";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "���I";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "���I";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "���I";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "���I";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "���I";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "���I";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "���I";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "���I";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "���I";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "���I";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "���I";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "���I";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "���I";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "���I";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "���I";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "���I";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "���I";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "���I";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "���I";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "���I";

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
            memory.na = "���I";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "���I";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "���I";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "���I";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "���I";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "���I";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "���I";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "���I";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "���I";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "���I";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "���I";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "���I";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "���I";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "���I";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "���I";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "���I";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "���I";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "���I";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "���I";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "���I";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "���I";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "���I";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "���I";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "���I";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "���I";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "���I";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "���I";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "���I";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "���I";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "���I";

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
            memory.na = "���I";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "���I";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "���I";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "���I";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "���I";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "���I";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "���I";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "���I";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "���I";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "���I";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "���I";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "���I";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "���I";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "���I";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "���I";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "���I";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "���I";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "���I";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "���I";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "���I";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "���I";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "���I";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "���I";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "���I";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "���I";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "���I";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "���I";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "���I";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "���I";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "���I";

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
            memory.na = "�^�[�V";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�^�[�V";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�^�[�V";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�^�[�V";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�^�[�V";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�^�[�V";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�^�[�V";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�^�[�V";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�^�[�V";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�^�[�V";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�^�[�V";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�^�[�V";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�^�[�V";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�^�[�V";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�^�[�V";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�^�[�V";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�^�[�V";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�^�[�V";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�^�[�V";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�^�[�V";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�^�[�V";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�^�[�V";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�^�[�V";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�^�[�V";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�^�[�V";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�^�[�V";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�^�[�V";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�^�[�V";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�^�[�V";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�^�[�V";

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
            memory.na = "�^�[�V";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�^�[�V";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�^�[�V";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�^�[�V";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�^�[�V";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�^�[�V";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�^�[�V";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�^�[�V";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�^�[�V";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�^�[�V";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�^�[�V";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�^�[�V";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�^�[�V";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�^�[�V";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�^�[�V";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�^�[�V";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�^�[�V";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�^�[�V";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�^�[�V";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�^�[�V";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�^�[�V";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�^�[�V";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�^�[�V";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�^�[�V";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�^�[�V";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�^�[�V";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�^�[�V";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�^�[�V";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�^�[�V";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�^�[�V";

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
            memory.na = "�^�[�V";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�^�[�V";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�^�[�V";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�^�[�V";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�^�[�V";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�^�[�V";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�^�[�V";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�^�[�V";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�^�[�V";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�^�[�V";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�^�[�V";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�^�[�V";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�^�[�V";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�^�[�V";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�^�[�V";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�^�[�V";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�^�[�V";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�^�[�V";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�^�[�V";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�^�[�V";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�^�[�V";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�^�[�V";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�^�[�V";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�^�[�V";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�^�[�V";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�^�[�V";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�^�[�V";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�^�[�V";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�^�[�V";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�^�[�V";

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
            memory.na = "�^�[�V";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�^�[�V";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�^�[�V";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�^�[�V";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�^�[�V";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�^�[�V";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�^�[�V";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�^�[�V";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�^�[�V";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�^�[�V";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�^�[�V";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�^�[�V";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�^�[�V";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�^�[�V";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�^�[�V";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�^�[�V";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�^�[�V";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�^�[�V";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�^�[�V";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�^�[�V";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�^�[�V";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�^�[�V";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�^�[�V";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�^�[�V";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�^�[�V";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�^�[�V";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�^�[�V";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�^�[�V";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�^�[�V";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�^�[�V";

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
            memory.na = "�^�[�V";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�^�[�V";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�^�[�V";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�^�[�V";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�^�[�V";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�^�[�V";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�^�[�V";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�^�[�V";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�^�[�V";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�^�[�V";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�^�[�V";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�^�[�V";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�^�[�V";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�^�[�V";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�^�[�V";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�^�[�V";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�^�[�V";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�^�[�V";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�^�[�V";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�^�[�V";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�^�[�V";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�^�[�V";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�^�[�V";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�^�[�V";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�^�[�V";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�^�[�V";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�^�[�V";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�^�[�V";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�^�[�V";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�^�[�V";

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
            memory.na = "�^�[�V";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�^�[�V";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�^�[�V";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�^�[�V";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�^�[�V";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�^�[�V";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�^�[�V";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�^�[�V";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�^�[�V";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�^�[�V";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�^�[�V";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�^�[�V";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�^�[�V";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�^�[�V";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�^�[�V";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�^�[�V";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�^�[�V";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�^�[�V";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�^�[�V";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�^�[�V";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�^�[�V";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�^�[�V";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�^�[�V";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�^�[�V";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�^�[�V";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�^�[�V";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�^�[�V";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�^�[�V";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�^�[�V";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�^�[�V";

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
            memory.na = "�^�[�V";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�^�[�V";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�^�[�V";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�^�[�V";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�^�[�V";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�^�[�V";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�^�[�V";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�^�[�V";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�^�[�V";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�^�[�V";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�^�[�V";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�^�[�V";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�^�[�V";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�^�[�V";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�^�[�V";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�^�[�V";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�^�[�V";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�^�[�V";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�^�[�V";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�^�[�V";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�^�[�V";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�^�[�V";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�^�[�V";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�^�[�V";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�^�[�V";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�^�[�V";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�^�[�V";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�^�[�V";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�^�[�V";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�^�[�V";

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
            memory.na = "�݂��Ƃ����";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�݂��Ƃ����";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�݂��Ƃ����";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�݂��Ƃ����";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�݂��Ƃ����";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�݂��Ƃ����";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�݂��Ƃ����";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�݂��Ƃ����";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�݂��Ƃ����";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�݂��Ƃ����";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�݂��Ƃ����";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�݂��Ƃ����";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�݂��Ƃ����";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�݂��Ƃ����";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�݂��Ƃ����";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�݂��Ƃ����";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�݂��Ƃ����";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�݂��Ƃ����";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�݂��Ƃ����";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�݂��Ƃ����";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�݂��Ƃ����";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�݂��Ƃ����";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�݂��Ƃ����";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�݂��Ƃ����";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�݂��Ƃ����";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�݂��Ƃ����";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�݂��Ƃ����";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�݂��Ƃ����";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�݂��Ƃ����";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�݂��Ƃ����";

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
            memory.na = "�݂��Ƃ����";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�݂��Ƃ����";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�݂��Ƃ����";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�݂��Ƃ����";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�݂��Ƃ����";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�݂��Ƃ����";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�݂��Ƃ����";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�݂��Ƃ����";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�݂��Ƃ����";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�݂��Ƃ����";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�݂��Ƃ����";
        }
        else if (M == 11)
        {
            memory.a12 = 2;
            memory.na12 = "�݂��Ƃ����";

        }
        else if (M == 12)
        {
            memory.a11 = 2;
            memory.na11 = "�݂��Ƃ����";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�݂��Ƃ����";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�݂��Ƃ����";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�݂��Ƃ����";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�݂��Ƃ����";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�݂��Ƃ����";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�݂��Ƃ����";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�݂��Ƃ����";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�݂��Ƃ����";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�݂��Ƃ����";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�݂��Ƃ����";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�݂��Ƃ����";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�݂��Ƃ����";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�݂��Ƃ����";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�݂��Ƃ����";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�݂��Ƃ����";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�݂��Ƃ����";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�݂��Ƃ����";

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
            memory.na = "�݂��Ƃ����";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�݂��Ƃ����";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�݂��Ƃ����";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�݂��Ƃ����";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�݂��Ƃ����";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�݂��Ƃ����";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�݂��Ƃ����";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�݂��Ƃ����";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�݂��Ƃ����";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�݂��Ƃ����";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�݂��Ƃ����";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�݂��Ƃ����";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�݂��Ƃ����";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�݂��Ƃ����";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�݂��Ƃ����";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�݂��Ƃ����";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�݂��Ƃ����";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�݂��Ƃ����";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�݂��Ƃ����";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�݂��Ƃ����";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�݂��Ƃ����";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�݂��Ƃ����";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�݂��Ƃ����";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�݂��Ƃ����";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�݂��Ƃ����";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�݂��Ƃ����";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�݂��Ƃ����";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�݂��Ƃ����";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�݂��Ƃ����";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�݂��Ƃ����";

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
            memory.na = "�݂��Ƃ����";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�݂��Ƃ����";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�݂��Ƃ����";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�݂��Ƃ����";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�݂��Ƃ����";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�݂��Ƃ����";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�݂��Ƃ����";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�݂��Ƃ����";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�݂��Ƃ����";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�݂��Ƃ����";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�݂��Ƃ����";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�݂��Ƃ����";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�݂��Ƃ����";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�݂��Ƃ����";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�݂��Ƃ����";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�݂��Ƃ����";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�݂��Ƃ����";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�݂��Ƃ����";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�݂��Ƃ����";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�݂��Ƃ����";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�݂��Ƃ����";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�݂��Ƃ����";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�݂��Ƃ����";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�݂��Ƃ����";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�݂��Ƃ����";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�݂��Ƃ����";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�݂��Ƃ����";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�݂��Ƃ����";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�݂��Ƃ����";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�݂��Ƃ����";

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
            memory.na = "�݂��Ƃ����";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�݂��Ƃ����";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�݂��Ƃ����";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�݂��Ƃ����";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�݂��Ƃ����";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�݂��Ƃ����";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�݂��Ƃ����";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�݂��Ƃ����";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�݂��Ƃ����";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�݂��Ƃ����";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�݂��Ƃ����";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�݂��Ƃ����";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�݂��Ƃ����";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�݂��Ƃ����";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�݂��Ƃ����";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�݂��Ƃ����";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�݂��Ƃ����";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�݂��Ƃ����";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�݂��Ƃ����";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�݂��Ƃ����";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�݂��Ƃ����";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�݂��Ƃ����";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�݂��Ƃ����";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�݂��Ƃ����";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�݂��Ƃ����";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�݂��Ƃ����";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�݂��Ƃ����";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�݂��Ƃ����";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�݂��Ƃ����";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�݂��Ƃ����";

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
            memory.na = "�݂��Ƃ����";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�݂��Ƃ����";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�݂��Ƃ����";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�݂��Ƃ����";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�݂��Ƃ����";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�݂��Ƃ����";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�݂��Ƃ����";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�݂��Ƃ����";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�݂��Ƃ����";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�݂��Ƃ����";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�݂��Ƃ����";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�݂��Ƃ����";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�݂��Ƃ����";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�݂��Ƃ����";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�݂��Ƃ����";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�݂��Ƃ����";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�݂��Ƃ����";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�݂��Ƃ����";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�݂��Ƃ����";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�݂��Ƃ����";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�݂��Ƃ����";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�݂��Ƃ����";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�݂��Ƃ����";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�݂��Ƃ����";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�݂��Ƃ����";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�݂��Ƃ����";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�݂��Ƃ����";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�݂��Ƃ����";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�݂��Ƃ����";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�݂��Ƃ����";

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
            memory.na = "�݂��Ƃ����";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�݂��Ƃ����";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�݂��Ƃ����";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�݂��Ƃ����";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�݂��Ƃ����";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�݂��Ƃ����";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�݂��Ƃ����";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�݂��Ƃ����";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�݂��Ƃ����";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�݂��Ƃ����";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�݂��Ƃ����";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�݂��Ƃ����";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�݂��Ƃ����";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�݂��Ƃ����";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�݂��Ƃ����";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�݂��Ƃ����";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�݂��Ƃ����";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�݂��Ƃ����";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�݂��Ƃ����";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�݂��Ƃ����";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�݂��Ƃ����";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�݂��Ƃ����";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�݂��Ƃ����";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�݂��Ƃ����";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�݂��Ƃ����";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�݂��Ƃ����";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�݂��Ƃ����";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�݂��Ƃ����";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�݂��Ƃ����";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�݂��Ƃ����";

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
            memory.na = "�H��";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�H��";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�H��";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�H��";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�H��";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�H��";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�H��";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�H��";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�H��";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�H��";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�H��";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�H��";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�H��";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�H��";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�H��";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�H��";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�H��";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�H��";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�H��";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�H��";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�H��";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�H��";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�H��";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�H��";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�H��";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�H��";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�H��";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�H��";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�H��";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�H��";

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
            memory.na = "�H��";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�H��";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�H��";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�H��";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�H��";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�H��";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�H��";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�H��";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�H��";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�H��";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�H��";
        }
        else if (M == 11)
        {
            memory.a12 = 2;
            memory.na12 = "�H��";

        }
        else if (M == 12)
        {
            memory.a11 = 2;
            memory.na11 = "�H��";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�H��";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�H��";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�H��";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�H��";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�H��";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�H��";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�H��";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�H��";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�H��";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�H��";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�H��";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�H��";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�H��";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�H��";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�H��";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�H��";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�H��";

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
            memory.na = "�H��";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�H��";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�H��";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�H��";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�H��";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�H��";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�H��";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�H��";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�H��";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�H��";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�H��";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�H��";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�H��";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�H��";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�H��";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�H��";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�H��";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�H��";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�H��";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�H��";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�H��";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�H��";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�H��";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�H��";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�H��";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�H��";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�H��";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�H��";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�H��";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�H��";

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
            memory.na = "�H��";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�H��";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�H��";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�H��";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�H��";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�H��";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�H��";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�H��";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�H��";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�H��";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�H��";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�H��";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�H��";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�H��";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�H��";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�H��";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�H��";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�H��";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�H��";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�H��";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�H��";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�H��";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�H��";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�H��";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�H��";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�H��";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�H��";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�H��";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�H��";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�H��";

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
            memory.na = "�H��";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�H��";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�H��";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�H��";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�H��";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�H��";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�H��";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�H��";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�H��";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�H��";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�H��";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�H��";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�H��";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�H��";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�H��";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�H��";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�H��";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�H��";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�H��";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�H��";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�H��";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�H��";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�H��";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�H��";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�H��";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�H��";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�H��";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�H��";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�H��";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�H��";

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
            memory.na = "�H��";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�H��";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�H��";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�H��";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�H��";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�H��";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�H��";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�H��";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�H��";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�H��";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�H��";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�H��";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�H��";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�H��";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�H��";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�H��";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�H��";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�H��";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�H��";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�H��";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�H��";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�H��";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�H��";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�H��";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�H��";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�H��";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�H��";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�H��";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�H��";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�H��";

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
            memory.na = "�H��";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�H��";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�H��";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�H��";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�H��";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�H��";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�H��";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�H��";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�H��";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�H��";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�H��";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�H��";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�H��";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�H��";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�H��";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�H��";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�H��";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�H��";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�H��";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�H��";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�H��";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�H��";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�H��";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�H��";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�H��";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�H��";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�H��";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�H��";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�H��";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�H��";

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
            memory.na = "�{�X";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�{�X";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�{�X";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�{�X";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�{�X";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�{�X";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�{�X";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�{�X";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�{�X";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�{�X";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�{�X";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�{�X";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�{�X";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�{�X";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�{�X";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�{�X";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�{�X";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�{�X";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�{�X";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�{�X";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�{�X";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�{�X";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�{�X";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�{�X";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�{�X";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�{�X";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�{�X";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�{�X";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�{�X";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�{�X";

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
            memory.na = "�{�X";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�{�X";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�{�X";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�{�X";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�{�X";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�{�X";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�{�X";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�{�X";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�{�X";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�{�X";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�{�X";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�{�X";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�{�X";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�{�X";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�{�X";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�{�X";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�{�X";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�{�X";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�{�X";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�{�X";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�{�X";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�{�X";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�{�X";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�{�X";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�{�X";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�{�X";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�{�X";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�{�X";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�{�X";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�{�X";

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
            memory.na = "�{�X";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�{�X";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�{�X";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�{�X";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�{�X";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�{�X";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�{�X";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�{�X";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�{�X";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�{�X";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�{�X";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�{�X";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�{�X";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�{�X";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�{�X";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�{�X";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�{�X";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�{�X";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�{�X";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�{�X";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�{�X";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�{�X";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�{�X";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�{�X";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�{�X";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�{�X";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�{�X";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�{�X";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�{�X";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�{�X";

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
            memory.na = "�{�X";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�{�X";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�{�X";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�{�X";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�{�X";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�{�X";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�{�X";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�{�X";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�{�X";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�{�X";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�{�X";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�{�X";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�{�X";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�{�X";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�{�X";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�{�X";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�{�X";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�{�X";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�{�X";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�{�X";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�{�X";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�{�X";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�{�X";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�{�X";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�{�X";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�{�X";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�{�X";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�{�X";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�{�X";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�{�X";

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
            memory.na = "�{�X";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�{�X";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�{�X";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�{�X";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�{�X";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�{�X";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�{�X";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�{�X";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�{�X";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�{�X";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�{�X";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�{�X";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�{�X";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�{�X";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�{�X";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�{�X";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�{�X";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�{�X";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�{�X";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�{�X";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�{�X";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�{�X";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�{�X";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�{�X";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�{�X";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�{�X";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�{�X";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�{�X";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�{�X";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�{�X";

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
            memory.na = "�{�X";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�{�X";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�{�X";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�{�X";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�{�X";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�{�X";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�{�X";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�{�X";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�{�X";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�{�X";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�{�X";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�{�X";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�{�X";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�{�X";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�{�X";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�{�X";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�{�X";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�{�X";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�{�X";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�{�X";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�{�X";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�{�X";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�{�X";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�{�X";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�{�X";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�{�X";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�{�X";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�{�X";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�{�X";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�{�X";

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
            memory.na = "�{�X";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�{�X";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�{�X";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�{�X";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�{�X";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�{�X";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�{�X";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�{�X";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�{�X";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�{�X";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�{�X";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�{�X";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�{�X";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�{�X";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�{�X";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�{�X";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�{�X";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�{�X";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�{�X";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�{�X";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�{�X";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�{�X";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�{�X";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�{�X";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�{�X";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�{�X";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�{�X";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�{�X";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�{�X";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�{�X";

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
            memory.na = "�V�X�^�[";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�V�X�^�[";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�V�X�^�[";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�V�X�^�[";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�V�X�^�[";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�V�X�^�[";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�V�X�^�[";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�V�X�^�[";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�V�X�^�[";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�V�X�^�[";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�V�X�^�[";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�V�X�^�[";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�V�X�^�[";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�V�X�^�[";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�V�X�^�[";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�V�X�^�[";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�V�X�^�[";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�V�X�^�[";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�V�X�^�[";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�V�X�^�[";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�V�X�^�[";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�V�X�^�[";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�V�X�^�[";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�V�X�^�[";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�V�X�^�[";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�V�X�^�[";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�V�X�^�[";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�V�X�^�[";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�V�X�^�[";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�V�X�^�[";

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
            memory.na = "�V�X�^�[";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�V�X�^�[";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�V�X�^�[";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�V�X�^�[";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�V�X�^�[";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�V�X�^�[";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�V�X�^�[";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�V�X�^�[";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�V�X�^�[";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�V�X�^�[";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�V�X�^�[";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�V�X�^�[";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�V�X�^�[";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�V�X�^�[";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�V�X�^�[";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�V�X�^�[";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�V�X�^�[";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�V�X�^�[";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�V�X�^�[";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�V�X�^�[";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�V�X�^�[";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�V�X�^�[";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�V�X�^�[";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�V�X�^�[";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�V�X�^�[";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�V�X�^�[";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�V�X�^�[";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�V�X�^�[";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�V�X�^�[";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�V�X�^�[";

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
            memory.na = "�V�X�^�[";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�V�X�^�[";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�V�X�^�[";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�V�X�^�[";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�V�X�^�[";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�V�X�^�[";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�V�X�^�[";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�V�X�^�[";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�V�X�^�[";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�V�X�^�[";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�V�X�^�[";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�V�X�^�[";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�V�X�^�[";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�V�X�^�[";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�V�X�^�[";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�V�X�^�[";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�V�X�^�[";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�V�X�^�[";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�V�X�^�[";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�V�X�^�[";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�V�X�^�[";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�V�X�^�[";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�V�X�^�[";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�V�X�^�[";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�V�X�^�[";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�V�X�^�[";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�V�X�^�[";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�V�X�^�[";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�V�X�^�[";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�V�X�^�[";

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
            memory.na = "�V�X�^�[";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�V�X�^�[";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�V�X�^�[";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�V�X�^�[";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�V�X�^�[";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�V�X�^�[";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�V�X�^�[";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�V�X�^�[";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�V�X�^�[";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�V�X�^�[";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�V�X�^�[";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�V�X�^�[";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�V�X�^�[";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�V�X�^�[";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�V�X�^�[";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�V�X�^�[";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�V�X�^�[";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�V�X�^�[";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�V�X�^�[";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�V�X�^�[";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�V�X�^�[";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�V�X�^�[";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�V�X�^�[";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�V�X�^�[";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�V�X�^�[";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�V�X�^�[";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�V�X�^�[";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�V�X�^�[";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�V�X�^�[";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�V�X�^�[";

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
            memory.na = "�V�X�^�[";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�V�X�^�[";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�V�X�^�[";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�V�X�^�[";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�V�X�^�[";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�V�X�^�[";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�V�X�^�[";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�V�X�^�[";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�V�X�^�[";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�V�X�^�[";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�V�X�^�[";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�V�X�^�[";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�V�X�^�[";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�V�X�^�[";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�V�X�^�[";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�V�X�^�[";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�V�X�^�[";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�V�X�^�[";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�V�X�^�[";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�V�X�^�[";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�V�X�^�[";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�V�X�^�[";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�V�X�^�[";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�V�X�^�[";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�V�X�^�[";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�V�X�^�[";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�V�X�^�[";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�V�X�^�[";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�V�X�^�[";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�V�X�^�[";

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
            memory.na = "�V�X�^�[";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�V�X�^�[";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�V�X�^�[";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�V�X�^�[";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�V�X�^�[";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�V�X�^�[";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�V�X�^�[";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�V�X�^�[";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�V�X�^�[";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�V�X�^�[";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�V�X�^�[";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�V�X�^�[";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�V�X�^�[";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�V�X�^�[";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�V�X�^�[";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�V�X�^�[";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�V�X�^�[";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�V�X�^�[";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�V�X�^�[";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�V�X�^�[";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�V�X�^�[";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�V�X�^�[";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�V�X�^�[";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�V�X�^�[";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�V�X�^�[";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�V�X�^�[";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�V�X�^�[";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�V�X�^�[";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�V�X�^�[";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�V�X�^�[";

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
            memory.na = "�V�X�^�[";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�V�X�^�[";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�V�X�^�[";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�V�X�^�[";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�V�X�^�[";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�V�X�^�[";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�V�X�^�[";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�V�X�^�[";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�V�X�^�[";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�V�X�^�[";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�V�X�^�[";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�V�X�^�[";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�V�X�^�[";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�V�X�^�[";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�V�X�^�[";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�V�X�^�[";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�V�X�^�[";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�V�X�^�[";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�V�X�^�[";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�V�X�^�[";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�V�X�^�[";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�V�X�^�[";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�V�X�^�[";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�V�X�^�[";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�V�X�^�[";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�V�X�^�[";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�V�X�^�[";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�V�X�^�[";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�V�X�^�[";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�V�X�^�[";

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
            memory.na = "�œ�";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�œ�";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�œ�";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�œ�";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�œ�";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�œ�";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�œ�";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�œ�";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�œ�";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�œ�";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�œ�";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�œ�";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�œ�";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�œ�";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�œ�";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�œ�";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�œ�";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�œ�";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�œ�";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�œ�";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�œ�";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�œ�";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�œ�";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�œ�";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�œ�";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�œ�";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�œ�";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�œ�";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�œ�";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�œ�";

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
            memory.na = "�œ�";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�œ�";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�œ�";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�œ�";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�œ�";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�œ�";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�œ�";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�œ�";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�œ�";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�œ�";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�œ�";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�œ�";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�œ�";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�œ�";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�œ�";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�œ�";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�œ�";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�œ�";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�œ�";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�œ�";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�œ�";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�œ�";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�œ�";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�œ�";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�œ�";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�œ�";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�œ�";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�œ�";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�œ�";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�œ�";

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
            memory.na = "�œ�";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�œ�";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�œ�";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�œ�";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�œ�";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�œ�";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�œ�";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�œ�";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�œ�";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�œ�";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�œ�";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�œ�";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�œ�";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�œ�";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�œ�";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�œ�";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�œ�";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�œ�";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�œ�";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�œ�";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�œ�";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�œ�";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�œ�";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�œ�";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�œ�";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�œ�";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�œ�";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�œ�";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�œ�";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�œ�";

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
            memory.na = "�œ�";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�œ�";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�œ�";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�œ�";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�œ�";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�œ�";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�œ�";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�œ�";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�œ�";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�œ�";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�œ�";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�œ�";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�œ�";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�œ�";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�œ�";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�œ�";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�œ�";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�œ�";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�œ�";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�œ�";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�œ�";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�œ�";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�œ�";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�œ�";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�œ�";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�œ�";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�œ�";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�œ�";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�œ�";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�œ�";

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
            memory.na = "�œ�";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�œ�";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�œ�";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�œ�";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�œ�";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�œ�";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�œ�";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�œ�";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�œ�";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�œ�";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�œ�";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�œ�";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�œ�";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�œ�";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�œ�";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�œ�";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�œ�";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�œ�";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�œ�";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�œ�";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�œ�";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�œ�";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�œ�";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�œ�";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�œ�";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�œ�";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�œ�";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�œ�";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�œ�";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�œ�";

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
            memory.na = "�œ�";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�œ�";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�œ�";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�œ�";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�œ�";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�œ�";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�œ�";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�œ�";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�œ�";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�œ�";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�œ�";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�œ�";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�œ�";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�œ�";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�œ�";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�œ�";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�œ�";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�œ�";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�œ�";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�œ�";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�œ�";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�œ�";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�œ�";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�œ�";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�œ�";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�œ�";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�œ�";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�œ�";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�œ�";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�œ�";

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
            memory.na = "�œ�";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�œ�";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�œ�";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�œ�";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�œ�";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�œ�";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�œ�";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�œ�";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�œ�";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�œ�";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�œ�";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�œ�";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�œ�";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�œ�";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�œ�";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�œ�";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�œ�";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�œ�";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�œ�";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�œ�";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�œ�";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�œ�";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�œ�";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�œ�";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�œ�";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�œ�";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�œ�";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�œ�";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�œ�";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�œ�";

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
            memory.na = "��C";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "��C";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "��C";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "��C";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "��C";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "��C";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "��C";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "��C";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "��C";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "��C";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "��C";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "��C";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "��C";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "��C";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "��C";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "��C";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "��C";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "��C";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "��C";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "��C";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "��C";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "��C";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "��C";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "��C";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "��C";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "��C";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "��C";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "��C";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "��C";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "��C";

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
            memory.na = "��C";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "��C";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "��C";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "��C";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "��C";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "��C";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "��C";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "��C";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "��C";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "��C";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "��C";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "��C";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "��C";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "��C";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "��C";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "��C";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "��C";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "��C";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "��C";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "��C";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "��C";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "��C";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "��C";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "��C";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "��C";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "��C";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "��C";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "��C";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "��C";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "��C";

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
            memory.na = "��C";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "��C";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "��C";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "��C";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "��C";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "��C";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "��C";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "��C";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "��C";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "��C";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "��C";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "��C";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "��C";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "��C";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "��C";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "��C";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "��C";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "��C";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "��C";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "��C";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "��C";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "��C";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "��C";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "��C";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "��C";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "��C";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "��C";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "��C";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "��C";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "��C";

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
            memory.na = "��C";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "��C";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "��C";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "��C";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "��C";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "��C";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "��C";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "��C";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "��C";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "��C";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "��C";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "��C";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "��C";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "��C";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "��C";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "��C";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "��C";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "��C";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "��C";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "��C";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "��C";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "��C";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "��C";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "��C";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "��C";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "��C";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "��C";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "��C";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "��C";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "��C";

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
            memory.na = "��C";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "��C";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "��C";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "��C";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "��C";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "��C";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "��C";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "��C";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "��C";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "��C";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "��C";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "��C";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "��C";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "��C";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "��C";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "��C";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "��C";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "��C";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "��C";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "��C";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "��C";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "��C";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "��C";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "��C";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "��C";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "��C";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "��C";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "��C";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "��C";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "��C";

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
            memory.na = "��C";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "��C";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "��C";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "��C";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "��C";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "��C";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "��C";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "��C";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "��C";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "��C";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "��C";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "��C";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "��C";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "��C";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "��C";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "��C";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "��C";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "��C";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "��C";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "��C";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "��C";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "��C";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "��C";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "��C";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "��C";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "��C";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "��C";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "��C";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "��C";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "��C";

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
            memory.na = "��C";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "��C";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "��C";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "��C";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "��C";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "��C";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "��C";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "��C";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "��C";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "��C";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "��C";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "��C";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "��C";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "��C";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "��C";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "��C";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "��C";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "��C";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "��C";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "��C";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "��C";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "��C";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "��C";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "��C";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "��C";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "��C";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "��C";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "��C";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "��C";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "��C";

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
            memory.na = "�}�b�L�[";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�}�b�L�[";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�}�b�L�[";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�}�b�L�[";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�}�b�L�[";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�}�b�L�[";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�}�b�L�[";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�}�b�L�[";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�}�b�L�[";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�}�b�L�[";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�}�b�L�[";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�}�b�L�[";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�}�b�L�[";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�}�b�L�[";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�}�b�L�[";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�}�b�L�[";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�}�b�L�[";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�}�b�L�[";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�}�b�L�[";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�}�b�L�[";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�}�b�L�[";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�}�b�L�[";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�}�b�L�[";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�}�b�L�[";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�}�b�L�[";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�}�b�L�[";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�}�b�L�[";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�}�b�L�[";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�}�b�L�[";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�}�b�L�[";

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
            memory.na = "�}�b�L�[";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�}�b�L�[";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�}�b�L�[";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�}�b�L�[";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�}�b�L�[";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�}�b�L�[";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�}�b�L�[";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�}�b�L�[";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�}�b�L�[";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�}�b�L�[";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�}�b�L�[";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�}�b�L�[";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�}�b�L�[";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�}�b�L�[";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�}�b�L�[";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�}�b�L�[";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�}�b�L�[";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�}�b�L�[";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�}�b�L�[";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�}�b�L�[";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�}�b�L�[";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�}�b�L�[";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�}�b�L�[";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�}�b�L�[";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�}�b�L�[";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�}�b�L�[";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�}�b�L�[";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�}�b�L�[";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�}�b�L�[";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�}�b�L�[";

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
            memory.na = "�}�b�L�[";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�}�b�L�[";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�}�b�L�[";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�}�b�L�[";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�}�b�L�[";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�}�b�L�[";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�}�b�L�[";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�}�b�L�[";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�}�b�L�[";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�}�b�L�[";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�}�b�L�[";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�}�b�L�[";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�}�b�L�[";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�}�b�L�[";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�}�b�L�[";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�}�b�L�[";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�}�b�L�[";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�}�b�L�[";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�}�b�L�[";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�}�b�L�[";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�}�b�L�[";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�}�b�L�[";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�}�b�L�[";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�}�b�L�[";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�}�b�L�[";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�}�b�L�[";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�}�b�L�[";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�}�b�L�[";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�}�b�L�[";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�}�b�L�[";

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
            memory.na = "�}�b�L�[";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�}�b�L�[";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�}�b�L�[";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�}�b�L�[";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�}�b�L�[";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�}�b�L�[";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�}�b�L�[";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�}�b�L�[";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�}�b�L�[";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�}�b�L�[";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�}�b�L�[";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�}�b�L�[";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�}�b�L�[";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�}�b�L�[";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�}�b�L�[";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�}�b�L�[";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�}�b�L�[";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�}�b�L�[";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�}�b�L�[";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�}�b�L�[";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�}�b�L�[";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�}�b�L�[";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�}�b�L�[";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�}�b�L�[";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�}�b�L�[";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�}�b�L�[";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�}�b�L�[";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�}�b�L�[";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�}�b�L�[";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�}�b�L�[";

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
            memory.na = "�}�b�L�[";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�}�b�L�[";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�}�b�L�[";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�}�b�L�[";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�}�b�L�[";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�}�b�L�[";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�}�b�L�[";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�}�b�L�[";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�}�b�L�[";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�}�b�L�[";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�}�b�L�[";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�}�b�L�[";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�}�b�L�[";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�}�b�L�[";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�}�b�L�[";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�}�b�L�[";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�}�b�L�[";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�}�b�L�[";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�}�b�L�[";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�}�b�L�[";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�}�b�L�[";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�}�b�L�[";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�}�b�L�[";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�}�b�L�[";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�}�b�L�[";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�}�b�L�[";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�}�b�L�[";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�}�b�L�[";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�}�b�L�[";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�}�b�L�[";

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
            memory.na = "�}�b�L�[";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�}�b�L�[";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�}�b�L�[";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�}�b�L�[";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�}�b�L�[";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�}�b�L�[";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�}�b�L�[";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�}�b�L�[";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�}�b�L�[";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�}�b�L�[";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�}�b�L�[";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�}�b�L�[";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�}�b�L�[";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�}�b�L�[";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�}�b�L�[";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�}�b�L�[";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�}�b�L�[";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�}�b�L�[";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�}�b�L�[";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�}�b�L�[";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�}�b�L�[";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�}�b�L�[";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�}�b�L�[";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�}�b�L�[";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�}�b�L�[";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�}�b�L�[";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�}�b�L�[";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�}�b�L�[";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�}�b�L�[";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�}�b�L�[";

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
            memory.na = "�}�b�L�[";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�}�b�L�[";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�}�b�L�[";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�}�b�L�[";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�}�b�L�[";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�}�b�L�[";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�}�b�L�[";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�}�b�L�[";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�}�b�L�[";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�}�b�L�[";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�}�b�L�[";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�}�b�L�[";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�}�b�L�[";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�}�b�L�[";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�}�b�L�[";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�}�b�L�[";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�}�b�L�[";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�}�b�L�[";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�}�b�L�[";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�}�b�L�[";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�}�b�L�[";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�}�b�L�[";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�}�b�L�[";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�}�b�L�[";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�}�b�L�[";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�}�b�L�[";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�}�b�L�[";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�}�b�L�[";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�}�b�L�[";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�}�b�L�[";

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
            memory.na = "�}���[";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�}���[";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�}���[";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�}���[";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�}���[";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�}���[";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�}���[";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�}���[";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�}���[";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�}���[";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�}���[";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�}���[";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�}���[";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�}���[";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�}���[";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�}���[";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�}���[";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�}���[";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�}���[";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�}���[";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�}���[";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�}���[";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�}���[";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�}���[";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�}���[";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�}���[";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�}���[";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�}���[";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�}���[";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�}���[";

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
            memory.na = "�}���[";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�}���[";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�}���[";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�}���[";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�}���[";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�}���[";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�}���[";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�}���[";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�}���[";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�}���[";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�}���[";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�}���[";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�}���[";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�}���[";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�}���[";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�}���[";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�}���[";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�}���[";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�}���[";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�}���[";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�}���[";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�}���[";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�}���[";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�}���[";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�}���[";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�}���[";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�}���[";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�}���[";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�}���[";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�}���[";

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
            memory.na = "�}���[";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�}���[";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�}���[";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�}���[";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�}���[";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�}���[";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�}���[";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�}���[";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�}���[";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�}���[";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�}���[";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�}���[";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�}���[";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�}���[";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�}���[";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�}���[";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�}���[";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�}���[";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�}���[";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�}���[";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�}���[";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�}���[";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�}���[";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�}���[";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�}���[";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�}���[";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�}���[";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�}���[";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�}���[";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�}���[";

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
            memory.na = "�}���[";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�}���[";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�}���[";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�}���[";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�}���[";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�}���[";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�}���[";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�}���[";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�}���[";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�}���[";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�}���[";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�}���[";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�}���[";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�}���[";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�}���[";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�}���[";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�}���[";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�}���[";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�}���[";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�}���[";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�}���[";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�}���[";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�}���[";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�}���[";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�}���[";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�}���[";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�}���[";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�}���[";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�}���[";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�}���[";

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
            memory.na = "�}���[";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�}���[";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�}���[";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�}���[";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�}���[";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�}���[";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�}���[";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�}���[";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�}���[";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�}���[";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�}���[";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�}���[";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�}���[";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�}���[";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�}���[";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�}���[";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�}���[";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�}���[";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�}���[";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�}���[";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�}���[";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�}���[";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�}���[";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�}���[";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�}���[";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�}���[";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�}���[";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�}���[";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�}���[";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�}���[";

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
            memory.na = "�}���[";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�}���[";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�}���[";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�}���[";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�}���[";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�}���[";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�}���[";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�}���[";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�}���[";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�}���[";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�}���[";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�}���[";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�}���[";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�}���[";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�}���[";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�}���[";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�}���[";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�}���[";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�}���[";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�}���[";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�}���[";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�}���[";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�}���[";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�}���[";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�}���[";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�}���[";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�}���[";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�}���[";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�}���[";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�}���[";

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
            memory.na = "�}���[";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�}���[";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�}���[";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�}���[";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�}���[";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�}���[";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�}���[";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�}���[";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�}���[";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�}���[";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�}���[";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�}���[";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�}���[";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�}���[";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�}���[";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�}���[";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�}���[";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�}���[";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�}���[";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�}���[";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�}���[";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�}���[";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�}���[";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�}���[";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�}���[";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�}���[";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�}���[";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�}���[";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�}���[";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�}���[";

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
            memory.na = "�W���[";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�W���[";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�W���[";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�W���[";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�W���[";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�W���[";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�W���[";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�W���[";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�W���[";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�W���[";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�W���[";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�W���[";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�W���[";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�W���[";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�W���[";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�W���[";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�W���[";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�W���[";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�W���[";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�W���[";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�W���[";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�W���[";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�W���[";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�W���[";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�W���[";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�W���[";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�W���[";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�W���[";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�W���[";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�W���[";

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
            memory.na = "�W���[";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�W���[";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�W���[";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�W���[";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�W���[";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�W���[";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�W���[";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�W���[";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�W���[";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�W���[";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�W���[";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�W���[";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�W���[";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�W���[";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�W���[";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�W���[";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�W���[";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�W���[";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�W���[";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�W���[";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�W���[";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�W���[";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�W���[";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�W���[";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�W���[";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�W���[";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�W���[";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�W���[";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�W���[";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�W���[";

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
            memory.na = "�W���[";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�W���[";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�W���[";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�W���[";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�W���[";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�W���[";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�W���[";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�W���[";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�W���[";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�W���[";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�W���[";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�W���[";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�W���[";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�W���[";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�W���[";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�W���[";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�W���[";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�W���[";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�W���[";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�W���[";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�W���[";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�W���[";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�W���[";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�W���[";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�W���[";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�W���[";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�W���[";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�W���[";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�W���[";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�W���[";

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
            memory.na = "�W���[";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�W���[";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�W���[";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�W���[";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�W���[";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�W���[";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�W���[";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�W���[";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�W���[";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�W���[";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�W���[";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�W���[";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�W���[";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�W���[";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�W���[";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�W���[";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�W���[";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�W���[";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�W���[";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�W���[";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�W���[";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�W���[";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�W���[";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�W���[";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�W���[";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�W���[";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�W���[";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�W���[";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�W���[";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�W���[";

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
            memory.na = "�W���[";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�W���[";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�W���[";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�W���[";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�W���[";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�W���[";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�W���[";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�W���[";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�W���[";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�W���[";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�W���[";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�W���[";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�W���[";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�W���[";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�W���[";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�W���[";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�W���[";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�W���[";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�W���[";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�W���[";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�W���[";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�W���[";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�W���[";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�W���[";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�W���[";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�W���[";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�W���[";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�W���[";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�W���[";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�W���[";

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
            memory.na = "�W���[";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�W���[";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�W���[";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�W���[";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�W���[";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�W���[";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�W���[";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�W���[";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�W���[";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�W���[";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�W���[";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�W���[";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�W���[";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�W���[";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�W���[";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�W���[";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�W���[";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�W���[";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�W���[";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�W���[";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�W���[";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�W���[";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�W���[";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�W���[";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�W���[";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�W���[";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�W���[";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�W���[";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�W���[";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�W���[";

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
            memory.na = "�W���[";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�W���[";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�W���[";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�W���[";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�W���[";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�W���[";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�W���[";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�W���[";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�W���[";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�W���[";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�W���[";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�W���[";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�W���[";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�W���[";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�W���[";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�W���[";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�W���[";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�W���[";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�W���[";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�W���[";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�W���[";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�W���[";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�W���[";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�W���[";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�W���[";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�W���[";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�W���[";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�W���[";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�W���[";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�W���[";

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
            memory.na = "�p�Y";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�p�Y";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�p�Y";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�p�Y";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�p�Y";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�p�Y";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�p�Y";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�p�Y";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�p�Y";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�p�Y";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�p�Y";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�p�Y";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�p�Y";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�p�Y";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�p�Y";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�p�Y";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�p�Y";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�p�Y";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�p�Y";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�p�Y";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�p�Y";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�p�Y";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�p�Y";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�p�Y";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�p�Y";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�p�Y";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�p�Y";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�p�Y";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�p�Y";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�p�Y";

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
            memory.na = "�p�Y";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�p�Y";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�p�Y";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�p�Y";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�p�Y";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�p�Y";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�p�Y";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�p�Y";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�p�Y";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�p�Y";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�p�Y";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�p�Y";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�p�Y";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�p�Y";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�p�Y";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�p�Y";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�p�Y";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�p�Y";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�p�Y";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�p�Y";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�p�Y";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�p�Y";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�p�Y";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�p�Y";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�p�Y";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�p�Y";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�p�Y";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�p�Y";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�p�Y";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�p�Y";

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
            memory.na = "�p�Y";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�p�Y";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�p�Y";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�p�Y";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�p�Y";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�p�Y";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�p�Y";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�p�Y";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�p�Y";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�p�Y";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�p�Y";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�p�Y";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�p�Y";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�p�Y";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�p�Y";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�p�Y";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�p�Y";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�p�Y";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�p�Y";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�p�Y";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�p�Y";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�p�Y";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�p�Y";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�p�Y";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�p�Y";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�p�Y";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�p�Y";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�p�Y";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�p�Y";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�p�Y";

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
            memory.na = "�p�Y";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�p�Y";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�p�Y";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�p�Y";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�p�Y";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�p�Y";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�p�Y";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�p�Y";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�p�Y";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�p�Y";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�p�Y";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�p�Y";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�p�Y";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�p�Y";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�p�Y";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�p�Y";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�p�Y";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�p�Y";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�p�Y";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�p�Y";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�p�Y";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�p�Y";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�p�Y";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�p�Y";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�p�Y";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�p�Y";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�p�Y";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�p�Y";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�p�Y";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�p�Y";

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
            memory.na = "�p�Y";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�p�Y";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�p�Y";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�p�Y";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�p�Y";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�p�Y";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�p�Y";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�p�Y";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�p�Y";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�p�Y";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�p�Y";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�p�Y";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�p�Y";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�p�Y";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�p�Y";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�p�Y";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�p�Y";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�p�Y";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�p�Y";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�p�Y";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�p�Y";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�p�Y";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�p�Y";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�p�Y";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�p�Y";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�p�Y";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�p�Y";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�p�Y";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�p�Y";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�p�Y";

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
            memory.na = "�p�Y";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�p�Y";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�p�Y";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�p�Y";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�p�Y";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�p�Y";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�p�Y";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�p�Y";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�p�Y";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�p�Y";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�p�Y";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�p�Y";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�p�Y";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�p�Y";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�p�Y";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�p�Y";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�p�Y";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�p�Y";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�p�Y";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�p�Y";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�p�Y";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�p�Y";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�p�Y";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�p�Y";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�p�Y";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�p�Y";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�p�Y";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�p�Y";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�p�Y";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�p�Y";

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
            memory.na = "�p�Y";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�p�Y";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�p�Y";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�p�Y";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�p�Y";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�p�Y";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�p�Y";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�p�Y";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�p�Y";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�p�Y";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�p�Y";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�p�Y";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�p�Y";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�p�Y";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�p�Y";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�p�Y";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�p�Y";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�p�Y";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�p�Y";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�p�Y";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�p�Y";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�p�Y";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�p�Y";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�p�Y";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�p�Y";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�p�Y";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�p�Y";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�p�Y";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�p�Y";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�p�Y";

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
            memory.na = "�~��";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "�~��";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "�~��";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "�~��";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "�~��";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "�~��";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "�~��";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "�~��";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "�~��";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "�~��";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "�~��";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "�~��";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "�~��";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "�~��";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "�~��";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "�~��";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "�~��";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "�~��";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "�~��";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "�~��";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "�~��";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "�~��";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "�~��";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "�~��";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "�~��";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "�~��";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "�~��";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "�~��";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "�~��";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "�~��";

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
            memory.na = "�~��";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "�~��";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "�~��";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "�~��";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "�~��";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "�~��";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "�~��";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "�~��";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "�~��";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "�~��";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "�~��";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "�~��";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "�~��";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "�~��";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "�~��";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "�~��";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "�~��";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "�~��";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "�~��";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "�~��";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "�~��";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "�~��";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "�~��";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "�~��";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "�~��";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "�~��";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "�~��";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "�~��";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "�~��";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "�~��";

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
            memory.na = "�~��";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "�~��";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "�~��";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "�~��";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "�~��";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "�~��";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "�~��";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "�~��";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "�~��";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "�~��";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "�~��";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "�~��";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "�~��";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "�~��";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "�~��";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "�~��";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "�~��";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "�~��";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "�~��";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "�~��";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "�~��";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "�~��";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "�~��";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "�~��";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "�~��";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "�~��";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "�~��";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "�~��";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "�~��";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "�~��";

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
            memory.na = "�~��";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "�~��";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "�~��";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "�~��";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "�~��";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "�~��";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "�~��";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "�~��";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "�~��";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "�~��";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "�~��";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "�~��";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "�~��";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "�~��";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "�~��";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "�~��";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "�~��";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "�~��";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "�~��";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "�~��";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "�~��";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "�~��";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "�~��";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "�~��";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "�~��";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "�~��";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "�~��";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "�~��";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "�~��";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "�~��";

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
            memory.na = "�~��";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "�~��";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "�~��";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "�~��";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "�~��";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "�~��";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "�~��";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "�~��";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "�~��";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "�~��";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "�~��";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "�~��";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "�~��";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "�~��";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "�~��";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "�~��";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "�~��";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "�~��";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "�~��";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "�~��";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "�~��";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "�~��";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "�~��";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "�~��";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "�~��";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "�~��";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "�~��";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "�~��";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "�~��";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "�~��";

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
            memory.na = "�~��";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "�~��";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "�~��";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "�~��";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "�~��";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "�~��";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "�~��";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "�~��";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "�~��";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "�~��";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "�~��";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "�~��";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "�~��";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "�~��";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "�~��";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "�~��";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "�~��";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "�~��";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "�~��";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "�~��";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "�~��";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "�~��";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "�~��";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "�~��";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "�~��";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "�~��";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "�~��";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "�~��";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "�~��";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "�~��";

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
            memory.na = "�~��";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "�~��";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "�~��";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "�~��";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "�~��";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "�~��";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "�~��";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "�~��";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "�~��";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "�~��";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "�~��";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "�~��";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "�~��";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "�~��";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "�~��";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "�~��";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "�~��";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "�~��";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "�~��";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "�~��";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "�~��";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "�~��";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "�~��";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "�~��";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "�~��";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "�~��";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "�~��";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "�~��";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "�~��";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "�~��";

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
            memory.na = "���~";
        }
        else if (M == 1)
        {
            memory.a1 = 1;
            memory.na1 = "���~";

        }
        else if (M == 2)
        {
            memory.a2 = 1;
            memory.na2 = "���~";

        }
        else if (M == 3)
        {
            memory.a3 = 1;
            memory.na3 = "���~";

        }
        else if (M == 4)
        {
            memory.a4 = 1;
            memory.na4 = "���~";

        }
        else if (M == 5)
        {
            memory.a5 = 1;
            memory.na5 = "���~";
        }
        else if (M == 6)
        {
            memory.a6 = 1;
            memory.na6 = "���~";

        }
        else if (M == 7)
        {
            memory.a7 = 1;
            memory.na7 = "���~";

        }
        else if (M == 8)
        {
            memory.a8 = 1;
            memory.na8 = "���~";

        }
        else if (M == 9)
        {
            memory.a9 = 1;
            memory.na9 = "���~";

        }
        else if (M == 10)
        {
            memory.a10 = 1;
            memory.na10 = "���~";
        }
        else if (M == 11)
        {
            memory.a11 = 1;
            memory.na11 = "���~";

        }
        else if (M == 12)
        {
            memory.a12 = 1;
            memory.na12 = "���~";

        }
        else if (M == 13)
        {
            memory.a13 = 1;
            memory.na13 = "���~";

        }
        else if (M == 14)
        {
            memory.a14 = 1;
            memory.na14 = "���~";

        }
        else if (M == 15)
        {
            memory.a15 = 1;
            memory.na15 = "���~";
        }
        else if (M == 16)
        {
            memory.a16 = 1;
            memory.na16 = "���~";

        }
        else if (M == 17)
        {
            memory.a17 = 1;
            memory.na17 = "���~";

        }
        else if (M == 18)
        {
            memory.a18 = 1;
            memory.na18 = "���~";

        }
        else if (M == 19)
        {
            memory.a19 = 1;
            memory.na19 = "���~";

        }
        else if (M == 20)
        {
            memory.a20 = 1;
            memory.na20 = "���~";
        }
        else if (M == 21)
        {
            memory.a21 = 1;
            memory.na21 = "���~";

        }
        else if (M == 22)
        {
            memory.a22 = 1;
            memory.na22 = "���~";

        }
        else if (M == 23)
        {
            memory.a23 = 1;
            memory.na23 = "���~";

        }
        else if (M == 24)
        {
            memory.a24 = 1;
            memory.na24 = "���~";

        }
        else if (M == 25)
        {
            memory.a25 = 1;
            memory.na25 = "���~";
        }
        else if (M == 26)
        {
            memory.a26 = 1;
            memory.na26 = "���~";

        }
        else if (M == 27)
        {
            memory.a27 = 1;
            memory.na27 = "���~";

        }
        else if (M == 28)
        {
            memory.a28 = 1;
            memory.na28 = "���~";

        }
        else if (M == 29)
        {
            memory.a29 = 1;
            memory.na29 = "���~";

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
            memory.na = "���~";
        }
        else if (M == 1)
        {
            memory.a1 = 2;
            memory.na1 = "���~";

        }
        else if (M == 2)
        {
            memory.a2 = 2;
            memory.na2 = "���~";

        }
        else if (M == 3)
        {
            memory.a3 = 2;
            memory.na3 = "���~";

        }
        else if (M == 4)
        {
            memory.a4 = 2;
            memory.na4 = "���~";

        }
        else if (M == 5)
        {
            memory.a5 = 2;
            memory.na5 = "���~";
        }
        else if (M == 6)
        {
            memory.a6 = 2;
            memory.na6 = "���~";

        }
        else if (M == 7)
        {
            memory.a7 = 2;
            memory.na7 = "���~";

        }
        else if (M == 8)
        {
            memory.a8 = 2;
            memory.na8 = "���~";

        }
        else if (M == 9)
        {
            memory.a9 = 2;
            memory.na9 = "���~";

        }
        else if (M == 10)
        {
            memory.a10 = 2;
            memory.na10 = "���~";
        }
        else if (M == 11)
        {
            memory.a11 = 2;
            memory.na11 = "���~";

        }
        else if (M == 12)
        {
            memory.a12 = 2;
            memory.na12 = "���~";

        }
        else if (M == 13)
        {
            memory.a13 = 2;
            memory.na13 = "���~";

        }
        else if (M == 14)
        {
            memory.a14 = 2;
            memory.na14 = "���~";

        }
        else if (M == 15)
        {
            memory.a15 = 2;
            memory.na15 = "���~";
        }
        else if (M == 16)
        {
            memory.a16 = 2;
            memory.na16 = "���~";

        }
        else if (M == 17)
        {
            memory.a17 = 2;
            memory.na17 = "���~";

        }
        else if (M == 18)
        {
            memory.a18 = 2;
            memory.na18 = "���~";

        }
        else if (M == 19)
        {
            memory.a19 = 2;
            memory.na19 = "���~";

        }
        else if (M == 20)
        {
            memory.a20 = 2;
            memory.na20 = "���~";
        }
        else if (M == 21)
        {
            memory.a21 = 2;
            memory.na21 = "���~";

        }
        else if (M == 22)
        {
            memory.a22 = 2;
            memory.na22 = "���~";

        }
        else if (M == 23)
        {
            memory.a23 = 2;
            memory.na23 = "���~";

        }
        else if (M == 24)
        {
            memory.a24 = 2;
            memory.na24 = "���~";

        }
        else if (M == 25)
        {
            memory.a25 = 2;
            memory.na25 = "���~";
        }
        else if (M == 26)
        {
            memory.a26 = 2;
            memory.na26 = "���~";

        }
        else if (M == 27)
        {
            memory.a27 = 2;
            memory.na27 = "���~";

        }
        else if (M == 28)
        {
            memory.a28 = 2;
            memory.na28 = "���~";

        }
        else if (M == 29)
        {
            memory.a29 = 2;
            memory.na29 = "���~";

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
            memory.na = "���~";
        }
        else if (M == 1)
        {
            memory.a1 = 3;
            memory.na1 = "���~";

        }
        else if (M == 2)
        {
            memory.a2 = 3;
            memory.na2 = "���~";

        }
        else if (M == 3)
        {
            memory.a3 = 3;
            memory.na3 = "���~";

        }
        else if (M == 4)
        {
            memory.a4 = 3;
            memory.na4 = "���~";

        }
        else if (M == 5)
        {
            memory.a5 = 3;
            memory.na5 = "���~";
        }
        else if (M == 6)
        {
            memory.a6 = 3;
            memory.na6 = "���~";

        }
        else if (M == 7)
        {
            memory.a7 = 3;
            memory.na7 = "���~";

        }
        else if (M == 8)
        {
            memory.a8 = 3;
            memory.na8 = "���~";

        }
        else if (M == 9)
        {
            memory.a9 = 3;
            memory.na9 = "���~";

        }
        else if (M == 10)
        {
            memory.a10 = 3;
            memory.na10 = "���~";
        }
        else if (M == 11)
        {
            memory.a11 = 3;
            memory.na11 = "���~";

        }
        else if (M == 12)
        {
            memory.a12 = 3;
            memory.na12 = "���~";

        }
        else if (M == 13)
        {
            memory.a13 = 3;
            memory.na13 = "���~";

        }
        else if (M == 14)
        {
            memory.a14 = 3;
            memory.na14 = "���~";

        }
        else if (M == 15)
        {
            memory.a15 = 3;
            memory.na15 = "���~";
        }
        else if (M == 16)
        {
            memory.a16 = 3;
            memory.na16 = "���~";

        }
        else if (M == 17)
        {
            memory.a17 = 3;
            memory.na17 = "���~";

        }
        else if (M == 18)
        {
            memory.a18 = 3;
            memory.na18 = "���~";

        }
        else if (M == 19)
        {
            memory.a19 = 3;
            memory.na19 = "���~";

        }
        else if (M == 20)
        {
            memory.a20 = 3;
            memory.na20 = "���~";
        }
        else if (M == 21)
        {
            memory.a21 = 3;
            memory.na21 = "���~";

        }
        else if (M == 22)
        {
            memory.a22 = 3;
            memory.na22 = "���~";

        }
        else if (M == 23)
        {
            memory.a23 = 3;
            memory.na23 = "���~";

        }
        else if (M == 24)
        {
            memory.a24 = 3;
            memory.na24 = "���~";

        }
        else if (M == 25)
        {
            memory.a25 = 3;
            memory.na25 = "���~";
        }
        else if (M == 26)
        {
            memory.a26 = 3;
            memory.na26 = "���~";

        }
        else if (M == 27)
        {
            memory.a27 = 3;
            memory.na27 = "���~";

        }
        else if (M == 28)
        {
            memory.a28 = 3;
            memory.na28 = "���~";

        }
        else if (M == 29)
        {
            memory.a29 = 3;
            memory.na29 = "���~";

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
            memory.na = "���~";
        }
        else if (M == 1)
        {
            memory.a1 = 4;
            memory.na1 = "���~";

        }
        else if (M == 2)
        {
            memory.a2 = 4;
            memory.na2 = "���~";

        }
        else if (M == 3)
        {
            memory.a3 = 4;
            memory.na3 = "���~";

        }
        else if (M == 4)
        {
            memory.a4 = 4;
            memory.na4 = "���~";

        }
        else if (M == 5)
        {
            memory.a5 = 4;
            memory.na5 = "���~";
        }
        else if (M == 6)
        {
            memory.a6 = 4;
            memory.na6 = "���~";

        }
        else if (M == 7)
        {
            memory.a7 = 4;
            memory.na7 = "���~";

        }
        else if (M == 8)
        {
            memory.a8 = 4;
            memory.na8 = "���~";

        }
        else if (M == 9)
        {
            memory.a9 = 4;
            memory.na9 = "���~";

        }
        else if (M == 10)
        {
            memory.a10 = 4;
            memory.na10 = "���~";
        }
        else if (M == 11)
        {
            memory.a11 = 4;
            memory.na11 = "���~";

        }
        else if (M == 12)
        {
            memory.a12 = 4;
            memory.na12 = "���~";

        }
        else if (M == 13)
        {
            memory.a13 = 4;
            memory.na13 = "���~";

        }
        else if (M == 14)
        {
            memory.a14 = 4;
            memory.na14 = "���~";

        }
        else if (M == 15)
        {
            memory.a15 = 4;
            memory.na15 = "���~";
        }
        else if (M == 16)
        {
            memory.a16 = 4;
            memory.na16 = "���~";

        }
        else if (M == 17)
        {
            memory.a17 = 4;
            memory.na17 = "���~";

        }
        else if (M == 18)
        {
            memory.a18 = 4;
            memory.na18 = "���~";

        }
        else if (M == 19)
        {
            memory.a19 = 4;
            memory.na19 = "���~";

        }
        else if (M == 20)
        {
            memory.a20 = 4;
            memory.na20 = "���~";
        }
        else if (M == 21)
        {
            memory.a21 = 4;
            memory.na21 = "���~";

        }
        else if (M == 22)
        {
            memory.a22 = 4;
            memory.na22 = "���~";

        }
        else if (M == 23)
        {
            memory.a23 = 4;
            memory.na23 = "���~";

        }
        else if (M == 24)
        {
            memory.a24 = 4;
            memory.na24 = "���~";

        }
        else if (M == 25)
        {
            memory.a25 = 4;
            memory.na25 = "���~";
        }
        else if (M == 26)
        {
            memory.a26 = 4;
            memory.na26 = "���~";

        }
        else if (M == 27)
        {
            memory.a27 = 4;
            memory.na27 = "���~";

        }
        else if (M == 28)
        {
            memory.a28 = 4;
            memory.na28 = "���~";

        }
        else if (M == 29)
        {
            memory.a29 = 4;
            memory.na29 = "���~";

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
            memory.na = "���~";
        }
        else if (M == 1)
        {
            memory.a1 = 5;
            memory.na1 = "���~";

        }
        else if (M == 2)
        {
            memory.a2 = 5;
            memory.na2 = "���~";

        }
        else if (M == 3)
        {
            memory.a3 = 5;
            memory.na3 = "���~";

        }
        else if (M == 4)
        {
            memory.a4 = 5;
            memory.na4 = "���~";

        }
        else if (M == 5)
        {
            memory.a5 = 5;
            memory.na5 = "���~";
        }
        else if (M == 6)
        {
            memory.a6 = 5;
            memory.na6 = "���~";

        }
        else if (M == 7)
        {
            memory.a7 = 5;
            memory.na7 = "���~";

        }
        else if (M == 8)
        {
            memory.a8 = 5;
            memory.na8 = "���~";

        }
        else if (M == 9)
        {
            memory.a9 = 5;
            memory.na9 = "���~";

        }
        else if (M == 10)
        {
            memory.a10 = 5;
            memory.na10 = "���~";
        }
        else if (M == 11)
        {
            memory.a11 = 5;
            memory.na11 = "���~";

        }
        else if (M == 12)
        {
            memory.a12 = 5;
            memory.na12 = "���~";

        }
        else if (M == 13)
        {
            memory.a13 = 5;
            memory.na13 = "���~";

        }
        else if (M == 14)
        {
            memory.a14 = 5;
            memory.na14 = "���~";

        }
        else if (M == 15)
        {
            memory.a15 = 5;
            memory.na15 = "���~";
        }
        else if (M == 16)
        {
            memory.a16 = 5;
            memory.na16 = "���~";

        }
        else if (M == 17)
        {
            memory.a17 = 5;
            memory.na17 = "���~";

        }
        else if (M == 18)
        {
            memory.a18 = 5;
            memory.na18 = "���~";

        }
        else if (M == 19)
        {
            memory.a19 = 5;
            memory.na19 = "���~";

        }
        else if (M == 20)
        {
            memory.a20 = 5;
            memory.na20 = "���~";
        }
        else if (M == 21)
        {
            memory.a25 = 5;
            memory.na25 = "���~";

        }
        else if (M == 22)
        {
            memory.a22 = 5;
            memory.na22 = "���~";

        }
        else if (M == 23)
        {
            memory.a23 = 5;
            memory.na23 = "���~";

        }
        else if (M == 24)
        {
            memory.a24 = 5;
            memory.na24 = "���~";

        }
        else if (M == 25)
        {
            memory.a25 = 5;
            memory.na25 = "���~";
        }
        else if (M == 26)
        {
            memory.a26 = 5;
            memory.na26 = "���~";

        }
        else if (M == 27)
        {
            memory.a27 = 5;
            memory.na27 = "���~";

        }
        else if (M == 28)
        {
            memory.a28 = 5;
            memory.na28 = "���~";

        }
        else if (M == 29)
        {
            memory.a29 = 5;
            memory.na29 = "���~";

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
            memory.na = "���~";
        }
        else if (M == 1)
        {
            memory.a1 = 6;
            memory.na1 = "���~";

        }
        else if (M == 2)
        {
            memory.a2 = 6;
            memory.na2 = "���~";

        }
        else if (M == 3)
        {
            memory.a3 = 6;
            memory.na3 = "���~";

        }
        else if (M == 4)
        {
            memory.a4 = 6;
            memory.na4 = "���~";

        }
        else if (M == 5)
        {
            memory.a5 = 6;
            memory.na5 = "���~";
        }
        else if (M == 6)
        {
            memory.a6 = 6;
            memory.na6 = "���~";

        }
        else if (M == 7)
        {
            memory.a7 = 6;
            memory.na7 = "���~";

        }
        else if (M == 8)
        {
            memory.a8 = 6;
            memory.na8 = "���~";

        }
        else if (M == 9)
        {
            memory.a9 = 6;
            memory.na9 = "���~";

        }
        else if (M == 10)
        {
            memory.a10 = 6;
            memory.na10 = "���~";
        }
        else if (M == 11)
        {
            memory.a11 = 6;
            memory.na11 = "���~";

        }
        else if (M == 12)
        {
            memory.a12 = 6;
            memory.na12 = "���~";

        }
        else if (M == 13)
        {
            memory.a13 = 6;
            memory.na13 = "���~";

        }
        else if (M == 14)
        {
            memory.a14 = 6;
            memory.na14 = "���~";

        }
        else if (M == 15)
        {
            memory.a15 = 6;
            memory.na15 = "���~";
        }
        else if (M == 16)
        {
            memory.a16 = 6;
            memory.na16 = "���~";

        }
        else if (M == 17)
        {
            memory.a17 = 6;
            memory.na17 = "���~";

        }
        else if (M == 18)
        {
            memory.a18 = 6;
            memory.na18 = "���~";

        }
        else if (M == 19)
        {
            memory.a19 = 6;
            memory.na19 = "���~";

        }
        else if (M == 20)
        {
            memory.a20 = 6;
            memory.na20 = "���~";
        }
        else if (M == 21)
        {
            memory.a21 = 6;
            memory.na21 = "���~";

        }
        else if (M == 22)
        {
            memory.a22 = 6;
            memory.na22 = "���~";

        }
        else if (M == 23)
        {
            memory.a23 = 6;
            memory.na23 = "���~";

        }
        else if (M == 24)
        {
            memory.a24 = 6;
            memory.na24 = "���~";

        }
        else if (M == 25)
        {
            memory.a25 = 6;
            memory.na25 = "���~";
        }
        else if (M == 26)
        {
            memory.a26 = 6;
            memory.na26 = "���~";

        }
        else if (M == 27)
        {
            memory.a27 = 6;
            memory.na27 = "���~";

        }
        else if (M == 28)
        {
            memory.a28 = 6;
            memory.na28 = "���~";

        }
        else if (M == 29)
        {
            memory.a29 = 6;
            memory.na29 = "���~";

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
            memory.na = "���~";
        }
        else if (M == 1)
        {
            memory.a1 = 7;
            memory.na1 = "���~";

        }
        else if (M == 2)
        {
            memory.a2 = 7;
            memory.na2 = "���~";

        }
        else if (M == 3)
        {
            memory.a3 = 7;
            memory.na3 = "���~";

        }
        else if (M == 4)
        {
            memory.a4 = 7;
            memory.na4 = "���~";

        }
        else if (M == 5)
        {
            memory.a5 = 7;
            memory.na5 = "���~";
        }
        else if (M == 6)
        {
            memory.a6 = 7;
            memory.na6 = "���~";

        }
        else if (M == 7)
        {
            memory.a7 = 7;
            memory.na7 = "���~";

        }
        else if (M == 8)
        {
            memory.a8 = 7;
            memory.na8 = "���~";

        }
        else if (M == 9)
        {
            memory.a9 = 7;
            memory.na9 = "���~";

        }
        else if (M == 10)
        {
            memory.a10 = 7;
            memory.na10 = "���~";
        }
        else if (M == 11)
        {
            memory.a11 = 7;
            memory.na11 = "���~";

        }
        else if (M == 12)
        {
            memory.a12 = 7;
            memory.na12 = "���~";

        }
        else if (M == 13)
        {
            memory.a13 = 7;
            memory.na13 = "���~";

        }
        else if (M == 14)
        {
            memory.a14 = 7;
            memory.na14 = "���~";

        }
        else if (M == 15)
        {
            memory.a15 = 7;
            memory.na15 = "���~";
        }
        else if (M == 16)
        {
            memory.a16 = 7;
            memory.na16 = "���~";

        }
        else if (M == 17)
        {
            memory.a17 = 7;
            memory.na17 = "���~";

        }
        else if (M == 18)
        {
            memory.a18 = 7;
            memory.na18 = "���~";

        }
        else if (M == 19)
        {
            memory.a19 = 7;
            memory.na19 = "���~";

        }
        else if (M == 20)
        {
            memory.a20 = 7;
            memory.na20 = "���~";
        }
        else if (M == 21)
        {
            memory.a21 = 7;
            memory.na21 = "���~";

        }
        else if (M == 22)
        {
            memory.a22 = 7;
            memory.na22 = "���~";

        }
        else if (M == 23)
        {
            memory.a23 = 7;
            memory.na23 = "���~";

        }
        else if (M == 24)
        {
            memory.a24 = 7;
            memory.na24 = "���~";

        }
        else if (M == 25)
        {
            memory.a25 = 7;
            memory.na25 = "���~";
        }
        else if (M == 26)
        {
            memory.a26 = 7;
            memory.na26 = "���~";

        }
        else if (M == 27)
        {
            memory.a27 = 7;
            memory.na27 = "���~";

        }
        else if (M == 28)
        {
            memory.a28 = 7;
            memory.na28 = "���~";

        }
        else if (M == 29)
        {
            memory.a29 = 7;
            memory.na29 = "���~";

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





