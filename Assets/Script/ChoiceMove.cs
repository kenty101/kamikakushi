using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;



public class ChoiceMove : MonoBehaviour
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
    public GameObject Open;
    public GameObject kakunin;

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
    Number number;
    Black black;
    Tarou tarou;
    Timer timer;
    Memo memo;
 
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






    void Start()
    {
        number = GameObject.Find("Numbers").GetComponent<Number>();
        black = GameObject.Find("Blackout").GetComponent<Black>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        memo = GameObject.Find("Textmemo").GetComponent<Memo>();
    }
    public void hiraku()
    {
        Open.SetActive(true);
    }
    public void shimeru()
    {
        Open.SetActive(false);
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
            tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
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
            else
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);

                panelfade.SetActive(true);

            }
        }
        if (number.DaysPoint == 5)
        {
            memo.a = 1;
            memo.na = "���Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.b = 1;
            memo.na1 = "���Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.c = 1;
            memo.na2 = "���Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.d = 1;
            memo.na3 = "���Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.e = 1;
            memo.na4 = "���Y";

        }


    }

    public void Red()
    {
            GameObject God = GameObject.FindWithTag("God");
            tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
            GameObject Believer = GameObject.FindWithTag("Believer");
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
            else
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);


            }
        }
                if (number.DaysPoint == 5)
        {
            memo.a = 2;
            memo.na = "���Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.b = 2;
            memo.na1 = "���Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.c = 2;
            memo.na2 = "���Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.d = 2;
            memo.na3 = "���Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.e = 2;
            memo.na4 = "���Y";

        }

    }
    public void White()
    {
         GameObject God = GameObject.FindWithTag("God");
         tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
         GameObject Believer = GameObject.FindWithTag("Believer");
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
            else
            {
                soundManager.PlaySe(eclip);

                Questions[a].SetActive(false);
                Nos[a].SetActive(false);
                Yess[a].SetActive(true);


            }
        }
        if (number.DaysPoint == 5)
        {
            memo.a = 3;
            memo.na = "���Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.b = 3;
            memo.na1 = "���Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.c = 3;
            memo.na2 = "���Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.d = 3;
            memo.na3 = "���Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.e = 3;
            memo.na4 = "���Y";

        }


    }
    public void High()
    {
                GameObject God = GameObject.FindWithTag("God");
                tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
                GameObject Believer = GameObject.FindWithTag("Believer");
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
        if (number.DaysPoint == 5)
        {
            memo.a = 4;
            memo.na = "���Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.b = 4;
            memo.na1 = "���Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.c = 4;
            memo.na2 = "���Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.d = 4;
            memo.na3 = "���Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.e = 4;
            memo.na4 = "���Y";

        }

    }
    public void Low()
    {
                    GameObject God = GameObject.FindWithTag("God");
                    tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
                    GameObject Believer = GameObject.FindWithTag("Believer");
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
        if (number.DaysPoint == 5)
        {
            memo.a = 5;
            memo.na = "���Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.b = 5;
            memo.na1 = "���Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.c = 5;
            memo.na2 = "���Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.d = 5;
            memo.na3 = "���Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.e = 5;
            memo.na4 = "���Y";

        }

    }
    public void Hevy()
    {
                    GameObject God = GameObject.FindWithTag("God");
                    GameObject Believer = GameObject.FindWithTag("Believer");
                    tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
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
        if (number.DaysPoint == 5)
        {
            memo.a = 6;
            memo.na = "���Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.b = 6;
            memo.na1 = "���Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.c = 6;
            memo.na2 = "���Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.d = 6;
            memo.na3 = "���Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.e = 6;
            memo.na4 = "���Y";

        }


    }
    public void karui()
    {
                    GameObject God = GameObject.FindWithTag("God");
                    GameObject Believer = GameObject.FindWithTag("Believer");
                    tarou = GameObject.FindWithTag("God").GetComponent<Tarou>();
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
        if (number.DaysPoint == 5)
        {
            memo.a = 7;
            memo.na = "���Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.b = 7;
            memo.na1 = "���Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.c = 7;
            memo.na2 = "���Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.d = 7;
            memo.na3 = "���Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.e = 7;
            memo.na4 = "���Y";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "B��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "B��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "B��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "B��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "B��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "B��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "B��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "B��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "B��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "B��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "B��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "B��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "B��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "B��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "B��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "B��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "B��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "B��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "B��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "B��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "B��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "B��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "B��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "B��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "B��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "B��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "B��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "B��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "B��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "B��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "B��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "B��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "B��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "B��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "B��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���C�R";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���C�R";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���C�R";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���C�R";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���C�R";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���C�R";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���C�R";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���C�R";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���C�R";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���C�R";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���C�R";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���C�R";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���C�R";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���C�R";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���C�R";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���C�R";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���C�R";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���C�R";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���C�R";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���C�R";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���C�R";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���C�R";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���C�R";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���C�R";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���C�R";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���C�R";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���C�R";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���C�R";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���C�R";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���C�R";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���C�R";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���C�R";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���C�R";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���C�R";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���C�R";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�Ďq";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�Ďq";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�Ďq";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�Ďq";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�Ďq";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�Ďq";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�Ďq";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�Ďq";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�Ďq";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�Ďq";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�Ďq";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�Ďq";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�Ďq";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�Ďq";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�Ďq";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�Ďq";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�Ďq";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�Ďq";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�Ďq";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�Ďq";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�Ďq";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�Ďq";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�Ďq";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�Ďq";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�Ďq";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�Ďq";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�Ďq";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�Ďq";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�Ďq";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�Ďq";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�Ďq";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�Ďq";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�Ďq";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�Ďq";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�Ďq";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���b�J";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���b�J";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���b�J";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���b�J";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���b�J";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���b�J";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���b�J";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���b�J";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���b�J";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���b�J";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���b�J";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���b�J";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���b�J";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���b�J";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���b�J";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���b�J";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���b�J";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���b�J";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���b�J";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���b�J";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���b�J";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���b�J";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���b�J";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���b�J";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���b�J";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���b�J";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���b�J";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���b�J";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���b�J";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���b�J";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���b�J";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���b�J";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���b�J";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���b�J";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���b�J";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�l��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�l��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�l��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�l��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�l��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�l��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�l��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�l��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�l��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�l��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�l��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�l��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�l��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�l��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�l��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�l��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�l��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�l��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�l��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�l��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�l��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�l��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�l��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�l��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�l��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�l��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�l��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�l��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�l��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�l��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�l��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�l��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�l��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�l��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�l��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�鑠";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�鑠";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�鑠";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�鑠";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�鑠";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�鑠";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�鑠";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�鑠";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�鑠";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�鑠";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�鑠";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�鑠";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�鑠";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�鑠";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�鑠";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�鑠";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�鑠";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�鑠";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�鑠";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�鑠";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�鑠";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�鑠";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�鑠";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�鑠";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�鑠";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�鑠";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�鑠";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�鑠";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�鑠";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�鑠";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�鑠";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�鑠";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�鑠";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�鑠";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�鑠";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�ߐ{��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�ߐ{��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�ߐ{��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�ߐ{��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�ߐ{��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�ߐ{��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�ߐ{��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�ߐ{��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�ߐ{��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�ߐ{��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�ߐ{��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�ߐ{��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�ߐ{��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�ߐ{��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�ߐ{��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�ߐ{��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�ߐ{��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�ߐ{��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�ߐ{��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�ߐ{��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�ߐ{��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�ߐ{��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�ߐ{��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�ߐ{��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�ߐ{��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�ߐ{��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�ߐ{��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�ߐ{��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�ߐ{��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�ߐ{��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�ߐ{��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�ߐ{��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�ߐ{��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�ߐ{��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�ߐ{��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "K";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "K";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "K";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "K";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "K";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "K";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "K";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "K";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "K";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "K";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "K";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "K";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "K";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "K";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "K";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "K";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "K";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "K";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "K";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "K";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "K";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "K";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "K";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "K";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "K";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "K";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "K";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "K";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "K";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "K";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "K";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "K";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "K";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "K";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "K";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�q";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�q";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�q";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�q";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�q";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�q";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�q";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�q";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�q";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�q";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�q";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�q";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�q";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�q";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�q";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�q";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�q";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�q";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�q";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�q";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�q";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�q";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�q";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�q";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�q";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�q";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�q";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�q";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�q";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�q";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�܂�q";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�܂�q";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�܂�q";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�܂�q";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�܂�q";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���I";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���I";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���I";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���I";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���I";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���I";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���I";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���I";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���I";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���I";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���I";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���I";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���I";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���I";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���I";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���I";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���I";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���I";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���I";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���I";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���I";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���I";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���I";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���I";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���I";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���I";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���I";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���I";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���I";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���I";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���I";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���I";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���I";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���I";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���I";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�^�[�V";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�^�[�V";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�^�[�V";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�^�[�V";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�^�[�V";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�^�[�V";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�^�[�V";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�^�[�V";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�^�[�V";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�^�[�V";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�^�[�V";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�^�[�V";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�^�[�V";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�^�[�V";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�^�[�V";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�^�[�V";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�^�[�V";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�^�[�V";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�^�[�V";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�^�[�V";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�^�[�V";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�^�[�V";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�^�[�V";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�^�[�V";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�^�[�V";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�^�[�V";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�^�[�V";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�^�[�V";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�^�[�V";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�^�[�V";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�^�[�V";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�^�[�V";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�^�[�V";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�^�[�V";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�^�[�V";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�݂��Ƃ����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�݂��Ƃ����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�݂��Ƃ����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�݂��Ƃ����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�݂��Ƃ����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�݂��Ƃ����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�݂��Ƃ����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�݂��Ƃ����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�݂��Ƃ����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�݂��Ƃ����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�݂��Ƃ����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�݂��Ƃ����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�݂��Ƃ����";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�݂��Ƃ����";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�݂��Ƃ����";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�H��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�H��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�H��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�H��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�H��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�H��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�H��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�H��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�H��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�H��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�H��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�H��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�H��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�H��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�H��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�H��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�H��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�H��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�H��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�H��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�H��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�H��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�H��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�H��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�H��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�H��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�H��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�H��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�H��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�H��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�H��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�H��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�H��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�H��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�H��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�{�X";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�{�X";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�{�X";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�{�X";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�{�X";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�{�X";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�{�X";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�{�X";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�{�X";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�{�X";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�{�X";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�{�X";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�{�X";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�{�X";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�{�X";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�{�X";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�{�X";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�{�X";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�{�X";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�{�X";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�{�X";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�{�X";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�{�X";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�{�X";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�{�X";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�{�X";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�{�X";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�{�X";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�{�X";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�{�X";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�{�X";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�{�X";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�{�X";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�{�X";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�{�X";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�V�X�^�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�V�X�^�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�V�X�^�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�V�X�^�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�V�X�^�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�V�X�^�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�V�X�^�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�V�X�^�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�V�X�^�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�V�X�^�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�V�X�^�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�V�X�^�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�V�X�^�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�V�X�^�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�V�X�^�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�œ�";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�œ�";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�œ�";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�œ�";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�œ�";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�œ�";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�œ�";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�œ�";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�œ�";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�œ�";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�œ�";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�œ�";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�œ�";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�œ�";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�œ�";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�œ�";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�œ�";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�œ�";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�œ�";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�œ�";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�œ�";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�œ�";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�œ�";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�œ�";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�œ�";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�œ�";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�œ�";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�œ�";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�œ�";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�œ�";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�œ�";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�œ�";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�œ�";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�œ�";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�œ�";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��C";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��C";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��C";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��C";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��C";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��C";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��C";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��C";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��C";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��C";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��C";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��C";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��C";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��C";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��C";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��C";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��C";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��C";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��C";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��C";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��C";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��C";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��C";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��C";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��C";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��C";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��C";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��C";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��C";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��C";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "��C";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "��C";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "��C";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "��C";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "��C";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}�b�L�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}�b�L�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}�b�L�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}�b�L�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}�b�L�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}�b�L�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}�b�L�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}�b�L�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}�b�L�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}�b�L�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}�b�L�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}�b�L�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}�b�L�[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}�b�L�[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}�b�L�[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�}���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�}���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�}���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�}���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�}���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�W���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�W���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�W���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�W���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�W���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�W���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�W���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�W���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�W���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�W���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�W���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�W���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�W���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�W���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�W���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�W���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�W���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�W���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�W���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�W���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�W���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�W���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�W���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�W���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�W���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�W���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�W���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�W���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�W���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�W���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�W���[";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�W���[";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�W���[";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�W���[";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�W���[";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�p�Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�p�Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�p�Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�p�Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�p�Y";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�p�Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�p�Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�p�Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�p�Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�p�Y";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�p�Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�p�Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�p�Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�p�Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�p�Y";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�p�Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�p�Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�p�Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�p�Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�p�Y";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�p�Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�p�Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�p�Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�p�Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�p�Y";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�p�Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�p�Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�p�Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�p�Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�p�Y";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�p�Y";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�p�Y";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�p�Y";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�p�Y";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�p�Y";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�~��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�~��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�~��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�~��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�~��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�~��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�~��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�~��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�~��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�~��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�~��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�~��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�~��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�~��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�~��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�~��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�~��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�~��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�~��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�~��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�~��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�~��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�~��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�~��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�~��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�~��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�~��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�~��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�~��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�~��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "�~��";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "�~��";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "�~��";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "�~��";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "�~��";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���~";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���~";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���~";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���~";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���~";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���~";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���~";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���~";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���~";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���~";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���~";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���~";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���~";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���~";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���~";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���~";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���~";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���~";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���~";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���~";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���~";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���~";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���~";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���~";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���~";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���~";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���~";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���~";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���~";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���~";

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
        if (number.DaysPoint == 5)
        {
            memo.na = "���~";
        }
        else if (number.DaysPoint == 4)
        {
            memo.na1 = "���~";

        }
        else if (number.DaysPoint == 3)
        {
            memo.na2 = "���~";

        }
        else if (number.DaysPoint == 2)
        {
            memo.na3 = "���~";

        }
        else if (number.DaysPoint == 1)
        {
            memo.na4 = "���~";

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
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);

            Over.SetActive(true);
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
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);


        }

    }
    public void Check3()
    {
        BlackPanel.SetActive(true);


        if (characters[2].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);


        }

    }
    public void Check4()
    {
        BlackPanel.SetActive(true);


        if (characters[3].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check5()
    {
        BlackPanel.SetActive(true);


        if (characters[4].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check6()
    {
        BlackPanel.SetActive(true);


        if (characters[5].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
  
            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check7()
    {
        BlackPanel.SetActive(true);


        if (characters[6].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check8()
    {
        BlackPanel.SetActive(true);


        if (characters[7].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
  
            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);


        }

    }
    public void Check9()
    {
        BlackPanel.SetActive(true);


        if (characters[8].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);


        }

    }
    public void Check10()
    {
        BlackPanel.SetActive(true);


        if (characters[9].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check11()
    {
        BlackPanel.SetActive(true);


        if (characters[10].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);

            Over.SetActive(true);

        }

    }
    public void Check12()
    {
        BlackPanel.SetActive(true);


        if (characters[11].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);

        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check13()
    {
        BlackPanel.SetActive(true);


        if (characters[12].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check14()
    {
        BlackPanel.SetActive(true);


        if (characters[13].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
    
            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check15()
    {
        BlackPanel.SetActive(true);


        if (characters[14].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
 
            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check16()
    {
        BlackPanel.SetActive(true);


        if (characters[15].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check17()
    {
        BlackPanel.SetActive(true);


        if (characters[16].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check18()
    {
        BlackPanel.SetActive(true);


        if (characters[17].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check19()
    {
        BlackPanel.SetActive(true);


        if (characters[18].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check20()
    {
        BlackPanel.SetActive(true);


        if (characters[19].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check21()
    {
        BlackPanel.SetActive(true);


        if (characters[20].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);

            Over.SetActive(true);

        }

    }
    public void Check22()
    {
        BlackPanel.SetActive(true);


        if (characters[21].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);

        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check23()
    {
        BlackPanel.SetActive(true);


        if (characters[22].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check24()
    {
        BlackPanel.SetActive(true);


        if (characters[23].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check25()
    {
        BlackPanel.SetActive(true);


        if (characters[24].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check26()
    {
        BlackPanel.SetActive(true);


        if (characters[25].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check27()
    {
        BlackPanel.SetActive(true);


        if (characters[26].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check28()
    {
        BlackPanel.SetActive(true);


        if (characters[27].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check29()
    {
        BlackPanel.SetActive(true);


        if (characters[28].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);
            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void Check30()
    {
        BlackPanel.SetActive(true);


        if (characters[29].CompareTag("God"))
        {
            soundManager.PlayBgm(jclip);

            Clear.SetActive(true);


        }
        else
        {
            soundManager.PlayBgm(gclip);
            soundManager.PlaySe(iclip);
            Over.SetActive(true);

        }

    }
    public void menu(string direction)
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
        rooms[33].SetActive(false);

        if (direction == "menu")
        {
            if (number.DaysPoint < 1)
            {
                BlackPanel.SetActive(true);
                SceneManager.LoadScene("GameOver");
            }

        }
        soundManager.PlaySe(bclip);

        soundManager.PlayBgm(cclip);
        Day.SetActive(true);
        rooms[0].SetActive(true);
    }
        public void Fadeout()
    {
        rooms[b].SetActive(false);

        number.Move();
        panelfade.SetActive(false);
        rooms[32].SetActive(true);
        soundManager.PlaySe(fclip);


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
        Day.SetActive(false);

        panelfade.SetActive(false);
        rooms[33].SetActive(true);
        soundManager.PlayBgm(hclip);


    }

    public void fade()
    {

        Invoke("blaky", 1.0f);
            Invoke("god", 2.0f);
            panelfade.SetActive(true);

    }

    public void blaky()
    {
        black.fadeout = true;
        soundManager.PlayBgm(gclip);

        black.Update();
    }


}





