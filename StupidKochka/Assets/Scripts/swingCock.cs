using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swingCock : MonoBehaviour {

    public float angleRange;
	void Start () {
        angleRange = 10;
	}
	
	void Update () {
        transform.eulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * 10f, angleRange) - angleRange / 2);
    }
}
