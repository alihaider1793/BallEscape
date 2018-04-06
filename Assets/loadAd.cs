using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class loadAd : MonoBehaviour {

    InterstitialAd interstitial;

    // Use this for initialization
    void Start () {
        RequestInterstitial();

    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-8962576828551822/5965833001";
#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
			string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);

    }

    public void showInterstitialAd()
    {

        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }

    }
}
