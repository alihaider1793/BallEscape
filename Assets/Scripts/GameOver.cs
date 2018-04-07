using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using System;

public class GameOver : MonoBehaviour {
    Scene mScene;
    InterstitialAd interstitial;
    public GameObject gameOverPanel;
    
    //private	void onCollisionEnter(Collision col)
    //{
    //	if (col.gameObject.name == "ball")
    //	{
    //		Destroy (col.gameObject);
    //	}
    //}

    private void OnTriggerEnter ( Collider other)
	{
        mScene = SceneManager.GetActiveScene();
        if (other.gameObject.name == "ball")
        {
            Destroy(other.gameObject);
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

    }

    public void showInterstitialAd()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
			string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
			string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);

        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }

    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
        // Create an empty ad request & load it again
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }

}
