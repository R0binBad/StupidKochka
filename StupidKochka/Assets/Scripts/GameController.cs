using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// в этот класс надо перенисти всю логику игры так будет правильно
public class GameController : MonoBehaviour {

	public GameObject player;
	public GameObject ground;
	private bool dist100 = false;
	private bool dist250 = false;
	private bool dist500 = false;
	public float speed = 8;
	private float bgSpeed ;
	private float distance;
	void Start () {
		
		speed = gameObject.GetComponent<onjectsGeneration>().speed;
		groundScroll.speed = speed; 
		bgSpeed = ground.GetComponent<bgMove>().speed;
		//sound check
		if(PlayerPrefs.GetString("music")=="off"){
			gameObject.GetComponent<AudioSource> ().enabled = false; 
		}
	}
	// Update is called once per frame
	void Update () {
		distance = player.GetComponent<Player> ().distance;
		progress();

	}
	void progress(){
			if ((distance > 50) && dist100 == false) {
				groundScroll.speed = (float)(speed*1.1);
				ground.GetComponent<bgMove>().speed = (float)(bgSpeed*1.1);
				dist100 = true;
			}
			if ((distance > 150) && dist250 == false) {
				groundScroll.speed=(float)(speed*1.25);
				ground.GetComponent<bgMove>().speed = (float)(bgSpeed*1.2);
				dist250 = true;
			}
			if (distance > 300 && dist500 == false ) {
				groundScroll.speed = (float)(speed*1.35);
				ground.GetComponent<bgMove>().speed = (float)(bgSpeed*1.3);
				dist500 = true;
			}
	}
}
