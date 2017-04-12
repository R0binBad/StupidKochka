using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtons : MonoBehaviour {

    public string action;
    public GameObject m_on, m_off;

    private void Start()
    {
        if(PlayerPrefs.GetString("music") != "off")
        {
            m_on.SetActive(false);
            m_off.SetActive(true);
        }
        else
        {
            m_on.SetActive(true);
            m_off.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.05f, transform.position.z);
        
    }

    private void OnMouseUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.05f, transform.position.z);
    }


    private void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("music") == "off")// я тут поменял
            GameObject.Find("Click Audio").GetComponent<AudioSource>().Play() ;

        switch (action)
        {
            case "start":
                Application.LoadLevel("main");
                break;

            case "music":
                if (PlayerPrefs.GetString("music") != "off")
                {
                 PlayerPrefs.SetString("music", "off");
                m_on.SetActive(false);
                m_off.SetActive(true);
                }
                else
                {
                   PlayerPrefs.SetString("music", "on");
                    m_on.SetActive(true);
                    m_off.SetActive(false);
                }
                break;
            case "up":
                GameObject.Find("UpSound").GetComponent<AudioSource>().Play();
                break;

        }
        

          
            

    }

}
