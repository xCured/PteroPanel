using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameControlScript : MonoBehaviour
{
    public Text moneytext;
    public static int moneyamount;

    int greenissold;
    int purpleissold;
    int blueissold;
    int redissold;
    int orangeissold;

    public GameObject greenflame;
    public GameObject orangeflame;
    public GameObject redflame;
    public GameObject purpleflame;
    public GameObject blueflame;

    // Start is called before the first frame update
    void Start()
    {
        moneyamount = PlayerPrefs.GetInt("Moneyamount");
        greenissold = PlayerPrefs.GetInt("greenissold");
        purpleissold = PlayerPrefs.GetInt("purpleissold");
        blueissold = PlayerPrefs.GetInt("blueissold");
        redissold = PlayerPrefs.GetInt("redissold");
        orangeissold = PlayerPrefs.GetInt("orangeissold");

        if (greenissold == 2)
        {
            greenflame.SetActive(true);
            orangeflame.SetActive(false);
            redflame.SetActive(false);
            blueflame.SetActive(false);
            purpleflame.SetActive(false);
        }

        if (orangeissold == 2)
        {
            greenflame.SetActive(false);
            orangeflame.SetActive(true);
            redflame.SetActive(false);
            blueflame.SetActive(false);
            purpleflame.SetActive(false);
        }

        if (purpleissold == 2)
        {
            greenflame.SetActive(false);
            orangeflame.SetActive(false);
            redflame.SetActive(false);
            blueflame.SetActive(false);
            purpleflame.SetActive(true);
        }

        if (redissold == 2)
        {
            greenflame.SetActive(false);
            orangeflame.SetActive(false);
            redflame.SetActive(true);
            blueflame.SetActive(false);
            purpleflame.SetActive(false);
        }

        if (blueissold == 2)
        {
            greenflame.SetActive(false);
            orangeflame.SetActive(false);
            redflame.SetActive(false);
            blueflame.SetActive(true);
            purpleflame.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        moneytext.text = moneyamount.ToString();
        PlayerPrefs.SetInt("Moneyamount", moneyamount);

    }
    public void gotoshop()
    {
        PlayerPrefs.SetInt("Moneyamount", moneyamount);
    }
}
