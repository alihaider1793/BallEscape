using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateUs : MonoBehaviour {

    public GameObject RateUsWindow;

	public void GoToMarket()
    {
        PlayerPrefs.SetInt("RateUs", 1);
        Application.OpenURL("market://details?id=com.zillion.ballescape");
        Debug.Log("USER LIKED THE GAME!! REDIRECTING TO MARKET");
        RateUsWindow.SetActive(false);
    }

    public void CloseWindow()
    {
        Debug.Log("USER DID NOT LIKE THE GAME!! :(");
        RateUsWindow.SetActive(false);

    }
}
