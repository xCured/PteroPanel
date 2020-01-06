using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alphadown : MonoBehaviour
{
    public static float alphacolor = 0;
    public Image img;
    public Text tex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alphacolor -= .03f;
        img.color = new Color(1, 1, 1, alphacolor);
        tex.color = new Color(1, 1, 1, alphacolor);
        if(alphacolor < 0)
        {
            alphacolor = 0;
        }
    }
}
