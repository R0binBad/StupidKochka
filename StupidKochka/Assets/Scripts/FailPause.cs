using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailPause : MonoBehaviour
{

    bool paused = false;
    public string action;
    public GameObject PauseUI;

    private void OnMouseUpAsButton()
    {

        switch (action)//если так на паузу ставить то меню не вылезет или будет неактивно....после паузы ничего не выполняется
        {
                case "pause":
                {
                    if (!paused)
                    {
                        PauseUI.SetActive(true);
                        Time.timeScale = 0;
                        paused = true;
                        
                    }
                    else
                    {
                        Time.timeScale = 1;
                        paused = false;
                        PauseUI.SetActive(false);
                    }
                }
                    break;

        }
    }
}