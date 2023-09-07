using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class GAMESTART2 : MonoBehaviour
{
    SoundManager soundManager;


    [SerializeField] AudioClip clip;
    [SerializeField] AudioClip eclip;

    public GameObject koukoku;
    AdmobLibrary admoblibrary;


    // Start is called before the first frame update
    void Start()
    {
        var button = GetComponent<Button>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        admoblibrary = GameObject.Find("koukoku").GetComponent<AdmobLibrary>();

        button.onClick.AddListener(() =>
        {
            soundManager.PlaySe(clip);
            kaku();


        });
        
    }
    public void hiraku()
    {

        admoblibrary.ShowReward();

        koukoku.SetActive(false);
        Invoke("meibo",0.1f);
    

    }
   

    public void kaku()
    {
        soundManager.PlaySe(eclip);

        koukoku.SetActive(true);

    }
    public void tojiru()
    {
        soundManager.PlaySe(eclip);

        koukoku.SetActive(false);

    }
    public void meibo()
    {
        SceneManager.LoadScene("Meibo");


    }
}
