using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillKochka : MonoBehaviour {
	private Player player;
	private bool sound = true ;
		//Посмотреть как будет работать при генерации новых сцен, типа объекты удаляются же,
    //если сцена будет рандомом второй раз выбрана, останутся ли там банки или нет
	void Start(){
		player = gameObject.GetComponent<Player>();
		if (PlayerPrefs.GetString ("music") == "off") sound = false;
	}
    void OnTriggerEnter2D(Collider2D entity)
    {
        if (entity.transform.tag == "killer")
        {
            /*        //Destroy(gameObject);
            GameObject.FindGameObjectWithTag("groundQuad").GetComponent<bgMove>().enabled = false;
            GameObject.FindGameObjectWithTag("forest").GetComponent<bgMove>().enabled = false;

            int n = GameObject.FindGameObjectsWithTag("killer").Length;
            for(int i = 0; i < n; i++)
            {
                GameObject.FindGameObjectWithTag("killer").active = false;
            }*/

			player.kill();//убийство кровь матюки
			if(sound == true)entity.GetComponentInParent<AudioSource>().Play();
            /*Application.LoadLevel("StartMenu");
            //Application.LoadLevel("main");
            GameObject.FindGameObjectWithTag("home").active = true;
            Time.timeScale = 0;*/

        }
    }
}
