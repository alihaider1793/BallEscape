using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour {

	public void EasyLevelSelector()
    {
        PlayerPrefs.SetString("DifficultySelected", "easy");
        SceneManager.LoadScene("easyLevelSelection");
    }

    public void MediumLevelSelector()
    {
        PlayerPrefs.SetString("DifficultySelected", "medium");
        SceneManager.LoadScene("easyLevelSelection");
    }

    public void HardLevelSelector()
    {
        PlayerPrefs.SetString("DifficultySelected", "hard");
        SceneManager.LoadScene("easyLevelSelection");
    }

    public void QuitGame()
    {
        Debug.Log("EXITING APPLICATION FROM MAIN MENU");
        Application.Quit();
    }
}
