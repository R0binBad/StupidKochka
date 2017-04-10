using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillKochka : MonoBehaviour {

      //Посмотреть как будет работать при генерации новых сцен, типа объекты удаляются же,
    //если сцена будет рандомом второй раз выбрана, останутся ли там банки или нет

    void OnTriggerEnter2D(Collider2D Kochka)
    {
        if (Kochka.transform.tag == "killer")
        {
                    Destroy(gameObject);
            GameObject.FindGameObjectWithTag("groundQuad").GetComponent<bgMove>().enabled = false;
            GameObject.FindGameObjectWithTag("forest").GetComponent<bgMove>().enabled = false;

            int n = GameObject.FindGameObjectsWithTag("killer").Length;
            for(int i = 0; i < n; i++)
            {
                GameObject.FindGameObjectWithTag("killer").active = false;

            }
            Application.LoadLevel("StartMenu");
            //GameObject.FindGameObjectWithTag("home").active = true;
            //Time.timeScale = 0;

        }



    }
}
