using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Switch : MonoBehaviour
{

    public Slider slider;
    public Slider sliders;


    SoundManager soundManager;
    public float levelvalue;
    public float levelvaluer;


    void Start()
    {
        float volume = PlayerPrefs.GetFloat("Volume", 1);
        float volumer = PlayerPrefs.GetFloat("Volume2", 1);

        soundManager = GameObject.FindWithTag("Soundmanager").GetComponent<SoundManager>();
        levelvalue = volume;
        soundManager.BgmVolume = levelvalue;
        slider.value = volume;
        levelvaluer = volumer;
        soundManager.SeVolume = levelvaluer;
        sliders.value = volumer;


    }
    public void SoundSliderOnValueChange(float newSliderValue)
    {

        soundManager.BgmVolume = newSliderValue;
        PlayerPrefs.SetFloat("Volume",newSliderValue);
    }
    public void SoundSliderOnValueChange2(float newSliderValue)
    {

        soundManager.SeVolume = newSliderValue;
        PlayerPrefs.SetFloat("Volume2", newSliderValue);
    }



}
