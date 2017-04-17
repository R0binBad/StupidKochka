using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayNormal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.GetComponent<groundScroll>().checkEndPoint == true)
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            gameObject.GetComponent<Collider2D>().isTrigger = true;
        }
    }
}
