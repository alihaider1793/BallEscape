using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelSelectorControl : MonoBehaviour {


	public void backToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void startLevel1(int s)
    {
        Debug.Log("Level selected: " + s);
        PlayerPrefs.SetInt("levelFromLevelSelector", s);
        SceneManager.LoadScene("Level1");
    }
}
