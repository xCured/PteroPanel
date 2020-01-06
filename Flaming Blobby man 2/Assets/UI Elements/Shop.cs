using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Shop : MonoBehaviour
{
   int moneyamount;

   int orangeissold;
    int greenissold;
   int purpleissold;
   int blueissold;
   int redissold;
    

    public Text moneyamounttext;

    public Button greenbuybutton;
    public Button purplebuybutton;
    public Button bluebuybutton;
    public Button redbuybutton;

    // Start is called before the first frame update
    void Start()
    {
        moneyamount = PlayerPrefs.GetInt("Moneyamount");
    }
    // Update is called once per frame
    void Update()
    {
        moneyamounttext.text = moneyamount.ToString();
        greenissold = PlayerPrefs.GetInt("greenissold");
        purpleissold = PlayerPrefs.GetInt("purpleissold");
        blueissold = PlayerPrefs.GetInt("blueissold");
        redissold = PlayerPrefs.GetInt("redissold");
        orangeissold = PlayerPrefs.GetInt("orangeissold");

        // green buy - green buy - green buy - green buy - green buy -
        if (moneyamount >= 20 && greenissold <= 0)
            greenbuybutton.interactable = true;

        if (greenissold >= 1)
        {
            greenbuybutton.gameObject.SetActive(false);
            greenbuybutton.enabled = false;
        }
        //purple buy -purple buy -purple buy -purple buy -purple buy -
        if (moneyamount >= 80 && purpleissold <= 0)
            purplebuybutton.interactable = true;

        if (purpleissold >= 1)
        {
            purplebuybutton.gameObject.SetActive(false);
            purplebuybutton.enabled = false;
        }

        //blue buy - blue buy - blue buy - blue buy - blue buy -
        if (moneyamount >= 140 && blueissold <= 0)
            bluebuybutton.interactable = true;

        if (blueissold >= 1)
        {
            bluebuybutton.gameObject.SetActive(false);
            bluebuybutton.enabled = false;
        }
        //red buy - red buy - red buy - red buy - red buy - 
        if (moneyamount >= 200 && redissold == 0)
            redbuybutton.interactable = true;

        if (redissold >= 1)
        {
            redbuybutton.gameObject.SetActive(false);
            redbuybutton.enabled = false;
        }
    }

    public void buy20()
    {
        moneyamount -= 20;
        PlayerPrefs.SetInt("greenissold", 1);
        PlayerPrefs.SetInt("Moneyamount", moneyamount);
    }
    public void buy80()
    {
        moneyamount -= 80;
        PlayerPrefs.SetInt("purpleissold", 1);
        PlayerPrefs.SetInt("Moneyamount", moneyamount);
    }
    public void buy140()
    {
        moneyamount -= 140;
        PlayerPrefs.SetInt("blueissold", 1);
        PlayerPrefs.SetInt("Moneyamount", moneyamount);

    }
    public void buy200()
    {
        moneyamount -= 200;
        PlayerPrefs.SetInt("redissold", 1);
        PlayerPrefs.SetInt("Moneyamount", moneyamount);

    }
    // USE USE USE USE USE USE USE USE USE USE USE USE USE USE USE USE USE USE USE 
    public void Useorange()
    {
        PlayerPrefs.SetInt("orangeissold", 2);

        if(greenissold == 2)
        {
            PlayerPrefs.SetInt("greenissold", 1);
        }
        if (purpleissold == 2)
        {
            PlayerPrefs.SetInt("purpleissold", 1);
        }
        if (blueissold == 2)
        {
            PlayerPrefs.SetInt("blueissold", 1);
        }
        if (redissold == 2)
        {
            PlayerPrefs.SetInt("redissold", 1);
        }
    }
    public void Usegreen()
    {
        PlayerPrefs.SetInt("greenissold", 2);

        if (orangeissold == 2)
        {
            PlayerPrefs.SetInt("orangeissold", 1);
        }

        if (purpleissold == 2)
        {
            PlayerPrefs.SetInt("purpleissold", 1);
        }
        if (blueissold == 2)
        {
            PlayerPrefs.SetInt("blueissold", 1);
        }
        if (redissold == 2)
        {
            PlayerPrefs.SetInt("redissold", 1);
        }
    }
    public void Usepurple()
    {
        PlayerPrefs.SetInt("purpleissold", 2);

        if (orangeissold == 2)
        {
            PlayerPrefs.SetInt("orangeissold", 1);
        }
        if (greenissold == 2)
        {
            PlayerPrefs.SetInt("greenissold", 1);
        }
        if (blueissold == 2)
        {
            PlayerPrefs.SetInt("blueissold", 1);
        }
        if (redissold == 2)
        {
            PlayerPrefs.SetInt("redissold", 1);
        }
    }
    public void Useblue()
    {
        PlayerPrefs.SetInt("blueissold", 2);

        if (greenissold == 2)
        {
            PlayerPrefs.SetInt("greenissold", 1);
        }
        if (purpleissold == 2)
        {
            PlayerPrefs.SetInt("purpleissold", 1);
        }
        if (orangeissold == 2)
        {
            PlayerPrefs.SetInt("orangeissold", 1);
        }
        if (redissold == 2)
        {
            PlayerPrefs.SetInt("redissold", 1);
        }
    }
    public void Usered()
    {
        PlayerPrefs.SetInt("redissold", 2);

        if (greenissold == 2)
        {
            PlayerPrefs.SetInt("greenissold", 1);
        }
        if (purpleissold == 2)
        {
            PlayerPrefs.SetInt("purpleissold", 1);
        }
        if (blueissold == 2)
        {
            PlayerPrefs.SetInt("blueissold", 1);
        }
        if (orangeissold == 2)
        {
            PlayerPrefs.SetInt("orangeissold", 1);
        }
    }
}
