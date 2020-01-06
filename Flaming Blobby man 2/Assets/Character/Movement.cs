using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float jumpForce = 10.0f;
    public float speed = 10f;
    public Movement move;

    static Animator anim;

    public Rigidbody rb;

    

    void Start()
    {

        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // MOVE MOVE MOVE MOVE
        transform.Translate(speed*Time.deltaTime,0f,0f);
        if (rb.position.y > -5)
        {
            GetComponent<Rigidbody>().velocity += Vector3.up * Physics.gravity.y *Time.deltaTime;
        }

        // JUMP JUMP JUMP JUMP

        if ((Input.GetKeyDown(KeyCode.Space)) & (rb.position.y<-5))
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpForce;
            anim.SetBool("jump", true);
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = Resources.Load<AudioClip>("Jump");
            audio.Play();  // plays sound when collided.
        }
        else
        {
            anim.SetBool("jump", false);
        }
        // DUCK DUCK DUCK DUCK

        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetBool("duck", true);
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = Resources.Load<AudioClip>("Slide");
            audio.Play();  // plays sound when collided.
        }
        else
        {
            anim.SetBool("duck", false);
        }

        // RUN ANIMATION RUN ANIMATION
        if (move.enabled == true)
        {
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
        }

        // Timer Timer Timer Timer Timer Timer Timer Timer 


    }
}
