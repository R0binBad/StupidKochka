using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

  //  public GameObject gameController;
    public string action;
    public GameObject m_on, m_off;
    void Start () {
        //  gameController.GetComponent<AudioSource>().enabled = false;
        if (PlayerPrefs.GetString("music") != "off")
        {
            m_on.SetActive(true);
            m_off.SetActive(false);
        }
        else
        {
            m_on.SetActive(false);
            m_off.SetActive(true);
        }
    }
	

	void Update () {
		
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
        if (PlayerPrefs.GetString("music") == "on")// я тут поменял // и нахуя ишак ебаный .....не умеешь не берись блять
            GameObject.Find("AudioClick").GetComponent<AudioSource>().Play();

        switch (action)
        {
            case "home":
                SceneManager.LoadScene("StartMenu");
                 Time.timeScale = 1;
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
            case "replay":
                
                SceneManager.LoadScene(1);
                Time.timeScale = 1;
                break;


        }

    }
}
