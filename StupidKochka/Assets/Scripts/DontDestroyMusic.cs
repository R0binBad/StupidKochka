using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyMusic : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (GameObject.FindGameObjectsWithTag("audio").Length == 1)
            DontDestroyOnLoad(gameObject);
        else
            Destroy(gameObject);
	}
	

}
