using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    private bool tap, swipeleft, swiperight, swipeup, swipeupup, swipedown, swipe;
    private Vector2 starttouch, swipedelta, endtouch;
    private bool isdragging = false;

    public bool Tap { get { return tap; } }
    public Vector2 Swipedelta { get { return swipedelta; } }

    public bool Swipeleft { get { return swipeleft; } }
    public bool Swiperight { get { return swiperight; } }

    public bool Swipeup { get { return swipeup; } }
    public bool Swipeupup { get { return swipeupup; } }

    public bool Swipedown { get { return swipedown; } }

    public Rigidbody rb;
    public Animator anim;
    public float jumpForce = 10.0f;


    private Touch touch;

    public GameObject swipedo;
    public GameObject swipeupy;

    // Update is called once per frame
    private void Update()
    {
        tap = swipeleft = swipeup = swipeupup = swipedown = swiperight = false;
        swipedelta = Vector2.zero;

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
        if (swipeup & (rb.position.y < -5) && Time.timeScale == 0.0f)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpForce;
            anim.SetBool("jump", true);
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = Resources.Load<AudioClip>("Jump");
            audio.Play();  // plays sound when collided.
            Time.timeScale = 1f;
            Destroy(swipeupy);
        }

        // duck duck duck duck
        if (swipedown && Time.timeScale == 0.0f)
        {
            anim.SetBool("duck", true);
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = Resources.Load<AudioClip>("Slide");
            audio.Play();  // plays sound when collided.
            Time.timeScale = 1f;
            Destroy(swipedo);
        }




        void Reset()
        {
            starttouch = swipedelta = Vector2.zero;
            isdragging = false;
        }
    }
}
