using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    private Vector3 direction = new Vector3(-1, 0, 0);
 
	void Update () {
        foreach (Transform child in transform)
        {
            child.Translate(direction * 8 * Time.deltaTime);
        }
    }
}
