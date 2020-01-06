using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class savgame : MonoBehaviour
{

   

    public int lastloadedsceneIndex;
    //When building your game every scene has its own index number.Starts from 0.Default start scene is 0.
    //(I will assume this is your main menu or scene loader so first level we will load will have index 1)

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);//This makes this gameobject to not to be destroyed when a new level/scene is loaded.So we can track which scene he/she finished lastly.
      //  loading();
    }

    void Start()
    {
        // lastloadedsceneIndex = PlayerPrefs.GetInt("lastloadedsceneIndex");//When the game starts we get the last saved value for index.
        if (lastloadedsceneIndex <  1)
        {
            lastloadedsceneIndex = 1;
        }
    }

    public static void savegame()
    {
        PlayerPrefs.SetInt("lastloadedsceneIndex", SceneManager.GetActiveScene ().buildIndex );
        PlayerPrefs.Save();
        Debug.Log("GameSaved");

    }


    public  void loading()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("lastloadedsceneIndex"));
        Debug.Log("GameLoaded");
    }

    public void UpdateLastLoadedSceneIndex()
    {
        lastloadedsceneIndex++;//We increase index by one.

        PlayerPrefs.SetInt("LastLoadedSceneIndex", lastloadedsceneIndex);//We save the last value for index.SetInt takes two arguments.First one is

        //unique code for our save.Be sure to use same codes for Get and Set functions.Second parameter is the value.You can directly set it as a number but this is not our goal.
    }

}