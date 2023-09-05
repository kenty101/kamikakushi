using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource bgmAudioSource;
    [SerializeField] AudioSource seAudioSource;
    public float levelvalue;
    public float levelvaluer;

    public float BgmVolume
    {
        get
        {
            return bgmAudioSource.volume;
        }
        set
        {
            bgmAudioSource.volume = Mathf.Clamp01(value);
        }
    }

    public float SeVolume
    {
        get
        {
            return seAudioSource.volume;

        }
        set
        {
            seAudioSource.volume = Mathf.Clamp01(value);

        }
    }

    void Start()
    {
        float volume = PlayerPrefs.GetFloat("Volume", 1);
        float volumer = PlayerPrefs.GetFloat("Volume2", 1);
        levelvalue = volume;
        BgmVolume = levelvalue;      
        levelvaluer = volumer;
        SeVolume = levelvaluer;        
        GameObject soundManager = CheckOtherSoundManager();
        bool checkResult = soundManager != null && soundManager != gameObject;

        if(checkResult)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    GameObject CheckOtherSoundManager()
    {
        return GameObject.FindGameObjectWithTag("Soundmanager");

    }

    public void PlayBgm(AudioClip clip)
    {
        bgmAudioSource.clip = clip;

        if(clip == null)
        {
            return;
        }

        bgmAudioSource.Play();
    }

    public void PlaySe(AudioClip clip)
    {
        if(clip == null)
        {
            return;
        }

        seAudioSource.PlayOneShot(clip);
    }



}
