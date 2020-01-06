using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Continue : MonoBehaviour {
    public string levelToLoadFirst;
    // Use this for initialization
    public int lastloadedsceneIndex;

    void Start ()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("lastloadedsceneIndex"));

        if (PlayerPrefs.GetInt("lastloadedsceneIndex") < 1)
        {
            SceneManager.LoadScene(1);
        }

        Debug.Log("GameLoaded");
    }
	
	// Update is called once per frame
	void Update ()
 {
		
	}
    public void ContinueLevel()
    {
        if (PlayerPrefs.HasKey("CurrLvl"))
            SceneManager.LoadScene(PlayerPrefs.GetString("CurrLvl"));
        else
        {
            PlayerPrefs.SetString("CurrLvl",levelToLoadFirst);
            SceneManager.LoadScene(PlayerPrefs.GetString("CurrLvl"));
        }
    }
}
