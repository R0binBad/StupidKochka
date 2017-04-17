using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillKochka : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D Kochka)
    {
        if (Kochka.transform.tag == "killer")
        {
            /*        //Destroy(gameObject);
            GameObject.FindGameObjectWithTag("groundQuad").GetComponent<bgMove>().enabled = false;
            GameObject.FindGameObjectWithTag("forest").GetComponent<bgMove>().enabled = false;

            int n = GameObject.FindGameObjectsWithTag("killer").Length;
            for(int i = 0; i < n; i++)
            {
                GameObject.FindGameObjectWithTag("killer").active = false;
            }*/

            gameObject.GetComponent<Player>().isLive = false;//убийство кровь матюки
            gameObject.GetComponent<Player>().GetComponent<AudioSource>().clip = gameObject.GetComponent<Player>().dead;//надо нормальную архитектуры сделать наверна или хуй забить 
            gameObject.GetComponent<Player>().GetComponent<AudioSource>().Play();
            /*Application.LoadLevel("StartMenu");
            //Application.LoadLevel("main");
            GameObject.FindGameObjectWithTag("home").active = true;
            Time.timeScale = 0;*/

        }
    }
}
