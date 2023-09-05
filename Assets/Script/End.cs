using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    SoundManager soundManager;

    [SerializeField] AudioClip clip;
    [SerializeField] AudioClip aclip;
    public GameObject confirmationPanel;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

        confirmationPanel.SetActive(false);
        soundManager.PlayBgm(clip);
    }

    public void confimation()
    {
        soundManager.PlaySe(aclip);

        confirmationPanel.SetActive(true);
    }

    public void close()
    {
        soundManager.PlaySe(aclip);

        confirmationPanel.SetActive(false);

    }
    public void EndGame()
    {
        soundManager.PlaySe(aclip);

#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;

#else
        Application.Quit();
#endif
    }


}
