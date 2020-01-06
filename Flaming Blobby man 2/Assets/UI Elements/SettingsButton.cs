using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButton : MonoBehaviour
{

    public void Settings()
    {
        SceneManager.LoadScene(16);
    }

    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }

    public void Shop()
    {
        SceneManager.LoadScene(17);
    }
}
