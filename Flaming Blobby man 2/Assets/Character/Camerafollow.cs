using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform playertransform;
    private Vector3 cameraoffset;

    [Range(0.01f, 1f)]
    public float smoothfactor = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        cameraoffset = transform.position - playertransform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 NewPos = playertransform.position + cameraoffset;
        transform.position = Vector3.Slerp(transform.position, NewPos, smoothfactor);
    }
}
