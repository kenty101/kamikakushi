using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class Instruction : MonoBehaviour
{
    SoundManager soundManager;

    [SerializeField] AudioClip aclip;

    // Start is called before the first frame update
    void Start()
    {
        var button = GetComponent<Button>();
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

        button.onClick.AddListener(() =>
        {
            soundManager.PlaySe(aclip);

            SceneManager.LoadScene("Tutorial");
        });

    }

    // Update is called once per frame
    void Update()
    {

    }
}
