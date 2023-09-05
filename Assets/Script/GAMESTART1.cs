using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class GAMESTART1 : MonoBehaviour
{
    SoundManager soundManager;


    [SerializeField] AudioClip clip;
    [SerializeField] AudioClip aclip;

    void Start()
    {
        var button = GetComponent<Button>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

        button.onClick.AddListener(() =>
        {
            soundManager.PlaySe(clip);

            SceneManager.LoadScene("Gameplay1");
            soundManager.PlayBgm(aclip);

        });
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
