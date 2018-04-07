using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class DifficultyUnlock : MonoBehaviour {

    public GameObject easyBtn, mediumBtn, hardBtn;
    public Sprite lockImg,unlockImg;
	// Use this for initialization
	void Start () {
        

        if (PlayerPrefs.GetInt("levelCleard") < 4)
        {
            easyBtn.GetComponent<Button>().interactable = true;

            mediumBtn.GetComponent<Button>().interactable = false;
            mediumBtn.GetComponentInChildren<Text>().text = "";
            mediumBtn.GetComponent<Button>().image.sprite = lockImg;

            hardBtn.GetComponent<Button>().interactable = false;
            hardBtn.GetComponentInChildren<Text>().text = "";
            hardBtn.GetComponent<Button>().image.sprite = lockImg;
        }

        if (PlayerPrefs.GetInt("levelCleard") >= 5)
        {
            easyBtn.GetComponent<Button>().interactable = true;

            mediumBtn.GetComponent<Button>().interactable = true;
            mediumBtn.GetComponentInChildren<Text>().text = "MEDIUM";
            mediumBtn.GetComponent<Button>().image.sprite = unlockImg;

            hardBtn.GetComponent<Button>().interactable = false;
            hardBtn.GetComponentInChildren<Text>().text = "";
            hardBtn.GetComponent<Button>().image.sprite = lockImg;
        }
           
        if (PlayerPrefs.GetInt("levelCleard") >9)
        {
            easyBtn.GetComponent<Button>().interactable = true;

            mediumBtn.GetComponent<Button>().interactable = true;
            mediumBtn.GetComponentInChildren<Text>().text = "MEDIUM";
            mediumBtn.GetComponent<Button>().image.sprite = unlockImg;

            hardBtn.GetComponent<Button>().interactable = true;
            hardBtn.GetComponent<Button>().image.sprite = unlockImg;
            hardBtn.GetComponentInChildren<Text>().text = "HARD";
        }
    }
	
   
}
