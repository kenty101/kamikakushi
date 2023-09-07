using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class AdMob : MonoBehaviour
{
    private BannerView bannerView;
    public void Start()
    {
        // Google AdMob Initial
        MobileAds.Initialize(initStatus => { });
        this.RequestBanner();
    }
    private void RequestBanner()
    {
#if UNITY_ANDROID
    string adUnitId = "ca-app-pub-3940256099942544/6300978111"; // �e�X�g�p�L�����j�b�gID
#elif UNITY_IPHONE
    string adUnitId = "ca-app-pub-3940256099942544/2934735716"; // �e�X�g�p�L�����j�b�gID
#else
        string adUnitId = "unexpected_platform";
#endif
        // Create a 320x50 banner at the bottom of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        // Create an empty ad request.
        AdRequest request = new AdRequest();
        // Load the banner with the request.
        bannerView.LoadAd(request);
    }
}