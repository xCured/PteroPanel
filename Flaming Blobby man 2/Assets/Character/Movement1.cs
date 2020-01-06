using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
 
    public float jumpForce = 10.0f;
    public float speed = 10f;
    public Movement move;

    static Animator anim;

    public Rigidbody rb;

    private bool _applyJump;
    void Start()
    {

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // MOVE MOVE MOVE MOVE
        // transform.Translate(speed * Time.deltaTime, 0f, 0f);

        // JUMP JUMP JUMP JUMP


        if ((Input.GetKeyDown(KeyCode.Space)) && (rb.position.y < -5))
        {
            _applyJump = true;
        }
        // DUCK DUCK DUCK DUCK

        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetBool("duck", true);
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
    }

    void FixedUpdate()
    {
        if (_applyJump)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
            _applyJump = false;
        }
        rb.AddForce(transform.right * speed, ForceMode.Acceleration);

    }

}
