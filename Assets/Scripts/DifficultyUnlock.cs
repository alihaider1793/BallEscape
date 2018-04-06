using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class DifficultyUnlock : MonoBehaviour {

    public GameObject easyBtn, mediumBtn, hardBtn;

	// Use this for initialization
	void Start () {
        

        if (PlayerPrefs.GetInt("levelCleard") < 4)
        {
            easyBtn.GetComponent<Button>().interactable = true;
            mediumBtn.GetComponent<Button>().interactable = false;
            hardBtn.GetComponent<Button>().interactable = false;
        }

        if (PlayerPrefs.GetInt("levelCleard") >= 5)
        {
            easyBtn.GetComponent<Button>().interactable = true;
            mediumBtn.GetComponent<Button>().interactable = true;
            hardBtn.GetComponent<Button>().interactable = false;
        }
           
        if (PlayerPrefs.GetInt("levelCleard") >9)
        {
            mediumBtn.GetComponent<Button>().interactable = true;
            hardBtn.GetComponent<Button>().interactable = true;
            easyBtn.GetComponent<Button>().interactable = true;
        }
    }
	
   
}
