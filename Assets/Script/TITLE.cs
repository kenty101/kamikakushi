using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using GoogleMobileAds.Api;

[RequireComponent(typeof(Button))]
public class TITLE : MonoBehaviour
{
    [SerializeField] AudioClip aclip;
    SoundManager soundManager;
    [SerializeField] public TMP_Text _text;
    private InterstitialAd interstitial;
    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("SoundManager").GetComponent<SoundManager>();

        var button = GetComponent<Button>();
        loadInterstitialAd();

        button.onClick.AddListener(() =>
        {
            soundManager.PlaySe(aclip);
            string playText = "Play";
            int playNum = 0;
            if (PlayerPrefs.HasKey(playText))
            {
                playNum = PlayerPrefs.GetInt(playText);
            }
            playNum++;
            if (playNum >= 2)
            {
                showInterstitialAd();

                playNum = 0;
            }
            else
            {
                SceneManager.LoadScene("TitleScene");

            }
            PlayerPrefs.SetInt("Play", playNum);


        });

    }
    public void loadInterstitialAd()
    {
#if UNITY_ANDROID
    string adUnitId = "ca-app-pub-8637589299049295/8899964705";
#elif UNITY_IPHONE
    string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif
        InterstitialAd.Load(adUnitId, new AdRequest(),
          (InterstitialAd ad, LoadAdError loadAdError) =>
          {
              if (loadAdError != null)
              {
                  // Interstitial ad failed to load with error
                  interstitial.Destroy();
                  return;
              }
              else if (ad == null)
              {
                  // Interstitial ad failed to load.
                  return;
              }
              ad.OnAdFullScreenContentClosed += () => {
                  HandleOnAdClosed();
              };
              ad.OnAdFullScreenContentFailed += (AdError error) =>
              {
                  HandleOnAdClosed();
              };
              interstitial = ad;
          });
    }
    private void HandleOnAdClosed()
    {
        this.interstitial.Destroy();
        this.loadInterstitialAd();
        SceneManager.LoadScene("TitleScene");

    }
    public void showInterstitialAd()
    {
        if (interstitial != null && interstitial.CanShowAd())
        {
            interstitial.Show();

        }
        else
        {
            Debug.Log("Interstitial Ad not load");
        }
    }

}
