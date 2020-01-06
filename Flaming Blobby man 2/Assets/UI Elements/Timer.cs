using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingtime = 10f;
    public Slider sliderInstance;
    public Movement move;
    public float health = 1000f;

    public GameObject restart;

    public Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingtime;


    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        sliderInstance.value -= 1.8f;
        health = sliderInstance.value;
        if (health == 0)
        {
            move.enabled = false;
            restart.SetActive (true);
            anim.SetBool("death", true);


        }
        if (sliderInstance.value > 1000)
        {
            sliderInstance.value = 1000;
        }

        if(Time.timeScale == 0.0f)
        {
            sliderInstance.value += 1.8f;

        }
    }

   
}
