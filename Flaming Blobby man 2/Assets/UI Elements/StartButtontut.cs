using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;

public class StartButtontut : MonoBehaviour
{
    public Movement move;
    public tutorial touchc;
    public Timer timer;
    public GameObject opt;
    public GameObject shop;
    // Start is called before the first frame update
    void Start()
    {
        
    }



   public void startbutton()
    {
        
        move.enabled = true;
        touchc.enabled = true;
        Destroy(gameObject.gameObject);
        timer.enabled = true;
        opt.SetActive(false);
        shop.SetActive(false);
    }


    

}
