using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;


public class TextDisplay : MonoBehaviour
{

    [SerializeField] public TMP_Text _text;
    private InterstitialAd interstitial;
    public float d_color;
    public GameObject modoru;

    public void Update()
    {
        d_color += 0.005f;
        _text.faceColor = new Color(255, 255, 255, d_color);

        Invoke("Move", 4.0f);
       

    }

	public void Move()
    {
        modoru.SetActive(true);

    }


}
