using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class TITLE : MonoBehaviour
{
    [SerializeField] AudioClip aclip;
    SoundManager soundManager;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

        var button = GetComponent<Button>();

        button.onClick.AddListener(() =>
        {
            soundManager.PlaySe(aclip);

            SceneManager.LoadScene("TitleScene");
        });

    }

    // Update is called once per frame
    void Update()
    {

    }
}
