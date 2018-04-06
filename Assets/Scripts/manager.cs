 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {

	public GameObject pauseMenu;

	private void Start()
	{
		pauseMenu.SetActive (false);
	}

	public void TogglePause()
	{
        if (!pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
            //Disable scripts that still work while timescale is set to 0
        }
        //else
        //{
        //    pauseMenu.SetActive(false);
        //    Time.timeScale = 1;
        //    //Disable scripts that still work while timescale is set to 0
        //}

    }

    public void continueGame()
	{
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        //Disable scripts that still work while timescale is set to 0
    }
}
