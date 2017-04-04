using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundScroll : MonoBehaviour
{
    public float speed;
    public Transform endPoint;
    public Transform startPoint;
    private Vector3 direction = new Vector3(-1, 0, 0);
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x < startPoint.position.x)
        {
            transform.position = new Vector3(endPoint.position.x, transform.position.y, transform.position.z);
        }
    }
}
