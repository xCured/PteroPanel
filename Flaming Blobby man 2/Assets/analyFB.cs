using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
public class analyFB : MonoBehaviour
{
    private static GameObject instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Application.platform == RuntimePlatform.Android)
        {
            Application.targetFrameRate = 60;
        }

        FB.Init(FBInitCallback);
    }

    private void FBInitCallback()
    {
        if (FB.IsInitialized)
        {
            FB.ActivateApp();
        }
    }

    public void OnApplicationPause(bool pause)
    {
        if (!pause)
        {
            if(FB.IsInitialized)
            {
                FB.ActivateApp();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
