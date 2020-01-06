using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutpause : MonoBehaviour
{
    private Collision col;
    public GameObject pausebox;
    public GameObject blob;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
     void FixedUpdate()
    {

    }
   
   

       
   

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == blob)
        {
            pausebox.SetActive(true);

        }
    }

    public void Unpause()
    {
        Destroy(gameObject);
        Time.timeScale = 1;
    }
}
