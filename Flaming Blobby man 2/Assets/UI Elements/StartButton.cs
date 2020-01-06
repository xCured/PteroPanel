using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public Movement move;
    public TouchControls touchc;
    public Timer timer;
    public GameObject opt;
    public GameObject shop;
    public int Sceneezzz;

    public bool StartButtonChecker = false;

    // Start is called before the first frame update
    void Start()
    {
         Sceneezzz = SceneManager.GetActiveScene().buildIndex;
    }

 
   

    public void startbutton()
    {
        StartButtonChecker = true;
        EventSelector();
        move.enabled = true;
        touchc.enabled = true;
        Destroy(gameObject.gameObject);
        timer.enabled = true;
        opt.SetActive(false);
        shop.SetActive(false);
    }


    public void EventSelector()
    {
        if(StartButtonChecker == true && Sceneezzz == 2)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, Application.version, "Level 2 - City");
        } else if (StartButtonChecker == true && Sceneezzz == 3)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, Application.version, "Level 3 - City");
        }
        else if (StartButtonChecker == true && Sceneezzz == 4)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, Application.version, "Level 4 - City");
        }
        else if (StartButtonChecker == true && Sceneezzz == 5)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, Application.version, "Level 5 - City");
        }
        else if (StartButtonChecker == true && Sceneezzz == 6)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, Application.version, "Level 6 - City");
        }
        else if (StartButtonChecker == true && Sceneezzz == 7)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, Application.version, "Level 7 - City");
        }
        else if (StartButtonChecker == true && Sceneezzz == 8)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, Application.version, "Level 8 - City");
        }
        else if (StartButtonChecker == true && Sceneezzz == 9)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, Application.version, "Level 9 - City");
        }
    }

}
