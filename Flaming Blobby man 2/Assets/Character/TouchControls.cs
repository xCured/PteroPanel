using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchControls : MonoBehaviour
{
    private bool tap, swipeleft, swiperight, swipeup, swipeupup, swipedown, swipe;
    private Vector2 starttouch, swipedelta, endtouch;
    private bool isdragging = false;

    public Vector2 Swipedelta { get { return swipedelta; } }

    public bool Swipeleft { get { return swipeleft; } }
    public bool Swiperight { get { return swiperight; } }

    public bool Swipeup { get { return swipeup; } }
    public bool Swipeupup { get { return swipeupup; } }

    public bool Swipedown { get { return swipedown; } }

    public Rigidbody rb;
    public Animator anim;
    public float jumpForce = 10.0f;

    public Slider jump;

    private Touch touch;

    // Update is called once per frame
    private void Update()
    {
        tap = swipeleft = swipeup = swipeupup = swipedown = swiperight = false;
        jump.value -= 20;


        //mouse mouse mouse mouse mouse 
        if (Input.GetMouseButtonDown(0))
        {
            tap = true;
            isdragging = true;
            starttouch = Input.mousePosition;
        }
        else if
            (Input.GetMouseButtonUp(0))
        {
            isdragging = false;
            Reset();
        }

        //touch touch touch touch
        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                tap = true;
                isdragging = true;
                starttouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isdragging = false;
                Reset();
            }
        }

        swipedelta = Vector2.zero;
        if (isdragging)
        {
            if (Input.touches.Length > 100)
                swipedelta = Input.touches[0].position - starttouch;
            else if (Input.GetMouseButton(0))
                swipedelta = (Vector2)Input.mousePosition - starttouch;
        }

        if (swipedelta.magnitude > 150)
        {
            float x = swipedelta.x;
            float y = swipedelta.y;
            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                if (x < 0)
                    swipeleft = true;
                if (x > 0)
                    swiperight = true;
            }
            else
            {
                if (y >= 50)
                    swipeup = true;


                if (y < 0)
                    swipedown = true;
            }


            Reset();
        }
        // jump jump jump jump
        if (swipeup & (rb.position.y < -5))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpForce;
            anim.SetBool("jump", true);
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = Resources.Load<AudioClip>("Jump");
            audio.Play();  // plays sound when collided.
            jump.value = 1000;
        }

        // duck duck duck duck
        if (swipedown)
        {
            anim.SetBool("duck", true);
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = Resources.Load<AudioClip>("Slide");
            audio.Play();  // plays sound when collided.


            if (starttouch == endtouch)
            {

                Instantiate(tap, transform.position, Quaternion.identity);
            }



        }

         void Instantiate(bool tap, Vector3 position, Quaternion identity)
        {
        }

         void Reset()
        {
            starttouch = swipedelta = Vector2.zero;
            isdragging = false;
        }
    } }
