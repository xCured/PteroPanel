using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene(2);
    }
    public void Loading()
    {
        SceneManager.LoadScene(0);

    }
}
