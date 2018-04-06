using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class initializeAds : MonoBehaviour {

	// Use this for initialization
	void Start () {
        mobileAdsInitialize();

    }

    private void mobileAdsInitialize()
    {
#if UNITY_ANDROID
        string appId = "ca-app-pub-8962576828551822~6368678754";
#elif UNITY_IPHONE
            string appId = "ca-app-pub-3940256099942544~1458002511";
#else
            string appId = "unexpected_platform";
#endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
    }
}
