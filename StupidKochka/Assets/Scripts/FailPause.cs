using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailPause : MonoBehaviour
{

    bool paused = false;
    public string action;

    private void OnMouseUpAsButton()
    {

        switch (action)//если так на паузу ставить то меню не вылезет или будет неактивно....после паузы ничего не выполняется
        {
                case "pause":
                {
                    if (!paused)
                    {
                        Time.timeScale = 0;
                        paused = true;
                    }
                    else
                    {
                        Time.timeScale = 1;
                        paused = false;
                    }
                }
                    break;

        }
    }
}