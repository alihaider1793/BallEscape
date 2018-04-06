using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolesDecider : MonoBehaviour {

    private int ind = 0;
    public GameObject[] holes;

	// Use this for initialization
	void Start () {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        ind = PlayerPrefs.GetInt("levelFromLevelSelector");
        showRelevantHoles(ind);
        Debug.Log("ind in holedecider: " + ind);
    }

    private void showRelevantHoles(int x)
    {
        for (int i = 0; i < holes.Length; i++)
        {
            if (i == x)
            {
                Debug.Log("HOLES ENABLED: " + i);
                holes[i].SetActive(true);

            }
            else
            {
                holes[i].SetActive(false);
            }
        }
    }
}
