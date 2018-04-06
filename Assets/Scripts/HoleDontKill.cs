using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HoleDontKill : MonoBehaviour {

    public Text timerText,bestTimeText;
    private float startTime;
    private float minn, secc;
    void Start()
    {
        startTime = Time.time;
        ShowBestTime();
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        minn = ((int)t / 60);
        secc = t%60;
        string min = ((int)t / 60).ToString();
        string sec = (t % 60).ToString("f2");

        timerText.text = min + ":" + sec;
    }

    private void OnTriggerEnter(Collider other)
    {
           
        if (other.gameObject.name == "holedontkill")
        {
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(0))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin1"))
                {
                    if(secc < PlayerPrefs.GetFloat("BestTimeSec1"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin1", minn);
                        PlayerPrefs.SetFloat("BestTimeSec1", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard", 0) < 1)
                    PlayerPrefs.SetInt("levelCleard", 1);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(1))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin2"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec2"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin2", minn);
                        PlayerPrefs.SetFloat("BestTimeSec2", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 2)
                    PlayerPrefs.SetInt("levelCleard", 2);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(2))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin3"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec3"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin3", minn);
                        PlayerPrefs.SetFloat("BestTimeSec3", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 3)
                    PlayerPrefs.SetInt("levelCleard", 3);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(3))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin4"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec4"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin4", minn);
                        PlayerPrefs.SetFloat("BestTimeSec4", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 4)
                    PlayerPrefs.SetInt("levelCleard", 4);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(4))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin5"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec5"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin5", minn);
                        PlayerPrefs.SetFloat("BestTimeSec5", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 5)
                    PlayerPrefs.SetInt("levelCleard", 5);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(5))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin6"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec6"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin6", minn);
                        PlayerPrefs.SetFloat("BestTimeSec6", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 6)
                    PlayerPrefs.SetInt("levelCleard", 6);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(6))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin7"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec7"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin7", minn);
                        PlayerPrefs.SetFloat("BestTimeSec7", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 7)
                    PlayerPrefs.SetInt("levelCleard", 7);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(7))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin8"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec8"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin8", minn);
                        PlayerPrefs.SetFloat("BestTimeSec8", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 8)
                    PlayerPrefs.SetInt("levelCleard", 8);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(8))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin9"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec9"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin9", minn);
                        PlayerPrefs.SetFloat("BestTimeSec9", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 9)
                    PlayerPrefs.SetInt("levelCleard", 9);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(9))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin10"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec10"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin10", minn);
                        PlayerPrefs.SetFloat("BestTimeSec10", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 10)
                    PlayerPrefs.SetInt("levelCleard", 10);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(10))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin11"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec11"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin11", minn);
                        PlayerPrefs.SetFloat("BestTimeSec11", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 11)
                    PlayerPrefs.SetInt("levelCleard", 11);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(11))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin12"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec12"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin12", minn);
                        PlayerPrefs.SetFloat("BestTimeSec12", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 12)
                    PlayerPrefs.SetInt("levelCleard", 12);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(12))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin13"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec13"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin13", minn);
                        PlayerPrefs.SetFloat("BestTimeSec13", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 13)
                    PlayerPrefs.SetInt("levelCleard", 13);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(13))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin14"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec14"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin14", minn);
                        PlayerPrefs.SetFloat("BestTimeSec14", secc);
                    }
                }
                if (PlayerPrefs.GetInt("levelCleard") < 14)
                    PlayerPrefs.SetInt("levelCleard", 14);
            }
            if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(14))
            {
                if (minn <= PlayerPrefs.GetFloat("BestTimeMin15"))
                {
                    if (secc < PlayerPrefs.GetFloat("BestTimeSec15"))
                    {
                        PlayerPrefs.SetFloat("BestTimeMin15", minn);
                        PlayerPrefs.SetFloat("BestTimeSec15", secc);
                    }
                }
            }
            //if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(5))
            //    PlayerPrefs.SetInt("levelCleard", 5);
            Destroy(other.gameObject);
            SceneManager.LoadScene("easyLevelSelection");
        }
    }


    private void ShowBestTime()
    {
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(0))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin1").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec1").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin1").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec1").ToString("f2"));
        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(1))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin2").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec2").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin2").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec2").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(2))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin3").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec3").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin3").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec3").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(3))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin4").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec4").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin4").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec4").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(4))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin5").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec5").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin5").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec5").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(5))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin6").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec6").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin6").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec6").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(6))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin7").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec7").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin7").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec7").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(7))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin8").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec8").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin8").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec8").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(8))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin9").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec9").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin9").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec9").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(9))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin10").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec10").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin10").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec10").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(10))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin11").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec11").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin11").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec11").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(11))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin12").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec12").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin12").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec12").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(12))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin13").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec13").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin13").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec13").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(13))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin14").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec14").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin14").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec14").ToString("f2"));

        }
        if (PlayerPrefs.GetInt("levelFromLevelSelector").Equals(14))
        {
            if (PlayerPrefs.GetFloat("BestTimeMin15").Equals(99999) || PlayerPrefs.GetFloat("BestTimeSec15").Equals(99999))
                bestTimeText.text = "~:~";
            else
                bestTimeText.text = PlayerPrefs.GetFloat("BestTimeMin15").ToString() + ":" + (PlayerPrefs.GetFloat("BestTimeSec15").ToString("f2"));

        }
    }
}
