using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlocker : MonoBehaviour {

    public GameObject[] levelButtons;
    public GameObject rateUsCanvas;
    public Sprite lockImg;

    // Use this for initialization
    void Start()
    {
        showRelevantLevel();
        int levelReached = PlayerPrefs.GetInt("levelCleard", 0);
        rateUsCanvas.SetActive(false);
        if (levelReached.Equals(0))
        {
            PlayerPrefs.SetInt("RateUs", 0);
            PlayerPrefs.SetFloat("BestTimeMin1", 99999);
            PlayerPrefs.SetFloat("BestTimeSec1", 99999);
            PlayerPrefs.SetFloat("BestTimeMin2", 99999);
            PlayerPrefs.SetFloat("BestTimeSec2", 99999);
            PlayerPrefs.SetFloat("BestTimeMin3", 99999);
            PlayerPrefs.SetFloat("BestTimeSec3", 99999);
            PlayerPrefs.SetFloat("BestTimeMin4", 99999);
            PlayerPrefs.SetFloat("BestTimeSec4", 99999);
            PlayerPrefs.SetFloat("BestTimeMin5", 99999);
            PlayerPrefs.SetFloat("BestTimeSec5", 99999);
            PlayerPrefs.SetFloat("BestTimeMin6", 99999);
            PlayerPrefs.SetFloat("BestTimeSec6", 99999);
            PlayerPrefs.SetFloat("BestTimeMin7", 99999);
            PlayerPrefs.SetFloat("BestTimeSec7", 99999);
            PlayerPrefs.SetFloat("BestTimeMin8", 99999);
            PlayerPrefs.SetFloat("BestTimeSec8", 99999);
            PlayerPrefs.SetFloat("BestTimeMin9", 99999);
            PlayerPrefs.SetFloat("BestTimeSec9", 99999);
            PlayerPrefs.SetFloat("BestTimeMin10", 99999);
            PlayerPrefs.SetFloat("BestTimeSec10", 99999);
            PlayerPrefs.SetFloat("BestTimeMin11", 99999);
            PlayerPrefs.SetFloat("BestTimeSec11", 99999);
            PlayerPrefs.SetFloat("BestTimeMin12", 99999);
            PlayerPrefs.SetFloat("BestTimeSec12", 99999);
            PlayerPrefs.SetFloat("BestTimeMin13", 99999);
            PlayerPrefs.SetFloat("BestTimeSec13", 99999);
            PlayerPrefs.SetFloat("BestTimeMin14", 99999);
            PlayerPrefs.SetFloat("BestTimeSec14", 99999);
            PlayerPrefs.SetFloat("BestTimeMin15", 99999);
            PlayerPrefs.SetFloat("BestTimeSec15", 99999);
        }

        if (levelReached.Equals(1) || levelReached.Equals(3) || levelReached.Equals(5) || levelReached.Equals(7) || levelReached.Equals(11) || levelReached.Equals(9) || levelReached.Equals(13))
        {
            if (Application.internetReachability == NetworkReachability.NotReachable)
            {
                Debug.Log("Error. Check internet connection!");
            }
            else
            {
                rateUs();
            }
        }

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i > levelReached)
            {
                levelButtons[i].GetComponent<Button>().image.sprite = lockImg;
                levelButtons[i].GetComponentInChildren<Text>().text = "";
                levelButtons[i].GetComponent<Button>().interactable = false;
            }
            else if (i < levelReached)
            {
                levelButtons[i].GetComponentInChildren<Text>().text = ""+(i+1);
            }
        }
    }

    private void rateUs()
    {
        if (PlayerPrefs.GetInt("RateUs").Equals(0))
        {
            rateUsCanvas.SetActive(true);
        }
    }

    private void showRelevantLevel()
    {
        if (PlayerPrefs.GetString("DifficultySelected").Equals("easy"))
        {
            for (int i = 0; i < 15; i++)
            {
                if (i < 5)
                    levelButtons[i].SetActive(true);
                else
                    levelButtons[i].SetActive(false);
            }
        }
        if (PlayerPrefs.GetString("DifficultySelected").Equals("medium"))
        {
            for (int i = 0; i < 15; i++)
            {
                if(i>4 && i<10)
                    levelButtons[i].SetActive(true);
                else
                    levelButtons[i].SetActive(false);

            }
        }
        if (PlayerPrefs.GetString("DifficultySelected").Equals("hard"))
        {
            for (int i = 0; i < 15; i++)
            {
                if(i>9)
                    levelButtons[i].SetActive(true);
                else
                    levelButtons[i].SetActive(false);
            }
        }
    }
}
