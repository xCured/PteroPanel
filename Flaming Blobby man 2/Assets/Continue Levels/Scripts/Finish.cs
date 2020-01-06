using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour {
    public string nextLevelName;
    public string currentLevelName;
	// Use this for initialization
	void Start () {
        PlayerPrefs.SetString("CurrLvl",currentLevelName);
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        LoadNextLevel();
    //    }
    //}

   
    void LoadNextLevel()
    {
        PlayerPrefs.SetString("CurrLvl" , nextLevelName);
        SceneManager.LoadScene(nextLevelName);
      }
}
