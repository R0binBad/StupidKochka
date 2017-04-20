using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundScroll : MonoBehaviour
{
	public static float speed;
    public Transform endPoint;
    public Transform startPoint;
    private Vector3 direction = new Vector3(-1, 0, 0);
	public bool checkEndPoint = false;
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x < startPoint.position.x)
        {
            Destroy(transform.gameObject);
        }
		if(transform.position.x < endPoint.position.x)
        {
			checkEndPoint = true;
		}
    }
}
