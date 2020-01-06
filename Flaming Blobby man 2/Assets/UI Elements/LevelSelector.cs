using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Button Level1, Level2, Level3, Level4;
    int LevelPassed;

    void Start()
    {
        LevelPassed = PlayerPrefs.GetInt("LevelPassed");
        Level2.interactable = false;
        Level3.interactable = false;
        Level4.interactable = false;

        switch (LevelPassed)
        {
            case 1:
                Level2.interactable = true;
                break;
            case 2:
                Level3.interactable = true;
                break;
            case 3:
                Level4.interactable = true;
                break;
        }

        
    }
    public void resetPlayerPrefs()
    {
        Level2.interactable = false;
        Level3.interactable = false;
        Level4.interactable = false;
    }

    public void Leveltoload(int Level)
    {
        SceneManager.LoadScene(Level);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
