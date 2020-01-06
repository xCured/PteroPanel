using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using GameAnalyticsSDK;


public class Collision : MonoBehaviour
{
    public Movement move;
    public Collider body;
    public GameObject restart;
    public Slider slide;
    public float pointsgained;
    public Animator anim;
    public TouchControls touchc;
    public GameObject splash;
    public GameObject pool;
    public GameObject victory;
    public GameObject slider;
    public float jumpForce = 10.0f;
    public TouchControls touch;
    public Button level2;
   

    

    public float speed = 10f;

    public GameObject foam;

    private bool oil = false;
    private bool faster = false;

    public static LevelSelector instance = null;
    int sceneIndex, LevelPassed;

    public GameObject next;

    public float cooldown = 1;
    public float cooldowntimer = 10000;
    private void Start()
    {

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        LevelPassed = PlayerPrefs.GetInt("LevelPassed");
    }
    private void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "obstacle")
        {
            move.enabled = false;
            touchc.enabled = false;

            slide.value = 0;
            restart.SetActive(true);
            anim.SetBool("death", true);

            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = Resources.Load<AudioClip>("Impact");
            audio.Play();  // plays sound when collided.

        }
        // points points points points 

        if (collisionInfo.gameObject.tag == "points")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = Resources.Load<AudioClip>("IceCube");
            audio.Play();  // plays sound when collided.

            Object.Destroy(collisionInfo.gameObject);
            slide.value += pointsgained;
            GameControlScript.moneyamount += 1;
            Alphadown.alphacolor = 1;
            
        }
        // candle candle candle candle candle
        {
            if (collisionInfo.gameObject.tag == "Hurt")
            {
                slide.value -= 500;
                Object.Destroy(collisionInfo.gameObject);

                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = Resources.Load<AudioClip>("Impact");
                audio.Play();  // plays sound when collided.

            }
        }

        // Win Win Win Win Win Win Win Win Win  
        if (collisionInfo.gameObject.tag == "win")
        {
            
            EventSelector();
            Object.Destroy(collisionInfo.gameObject);

            cooldowntimer = cooldown;
            splash.SetActive(true);

            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = Resources.Load<AudioClip>("NewSplash2");
            audio.Play();  // plays sound when collided.



        }
        if (collisionInfo.gameObject.tag == "splash")
        {
            Object.Destroy(collisionInfo.gameObject);
            splash.SetActive(true);
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpForce / 3;
            anim.SetBool("jump", true);
            touch.enabled = false;
            next.SetActive(true);

        }
        if (collisionInfo.gameObject.tag == "save")
        {
            savgame.savegame();


            Object.Destroy(collisionInfo.gameObject);

        }

      

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "extinguisher")
        {
            Object.Destroy(other.gameObject);
            GetComponent<Rigidbody>().velocity = (Vector3.up * 1.5f + Vector3.right) * jumpForce / 2;
            foam.SetActive(true);
            slide.value += pointsgained * 2;

            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = Resources.Load<AudioClip>("Extinguisher");
            audio.Play();  // plays sound when collided.

        }


        if (other.gameObject.tag == "oil")
        {
            anim.SetBool("Slip", true);
            oil = true;
            faster = true;
        }
        // trampoline trampoline trampoline trampoline

        if (other.gameObject.tag == "tramp")
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpForce ;

            anim.SetBool("tramp", true);

            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = Resources.Load<AudioClip>("TrampolineJump");
            audio.Play();  // plays sound when collided.
        }

        if (other.gameObject.tag == "pause")
        {
            Time.timeScale = 0f;
            Object.Destroy(other.gameObject);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "oil")
        {
            anim.SetBool("Slip", false);
            oil = false;
            faster = false;
        }
        if (other.gameObject.tag == "tramp")
        {
            anim.SetBool("tramp", false);

        }

    }
    void Update ()
    {
        if (cooldowntimer > 0)
        {
            cooldowntimer -= 1;
        }


        if (cooldowntimer < 0)
        {
            cooldowntimer = 0;
        }

        if(cooldowntimer < 2)
        {
            gameObject.SetActive(false);

            victory.SetActive(true);

            slider.SetActive(false);
            slide.value = 500000;
        }

        if (oil == true)
        {
            slide.value -= 5;
        }

        if (faster == true)
        {
            transform.Translate(4 * Time.deltaTime, 0f, 0f);
        }
    }

    public void EventSelector()
    {
        if ( sceneIndex == 2)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, Application.version, "Level 2 - City");
        }
        else if ( sceneIndex == 3)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, Application.version, "Level 3 - City");
        }
        else if ( sceneIndex == 4)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, Application.version, "Level 4 - City");
        }
        else if ( sceneIndex == 5)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, Application.version, "Level 5 - City");
        }
        else if (sceneIndex == 6)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, Application.version, "Level 6 - City");
        }
        else if ( sceneIndex == 7)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, Application.version, "Level 7 - City");
        }
        else if ( sceneIndex == 8)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, Application.version, "Level 8 - City");
        }
        else if ( sceneIndex == 9)
        {
            GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, Application.version, "Level 9 - City");
        }




    }

}
