using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastObject : MonoBehaviour
{

    public delegate void UnityDelegate();

    public static event UnityDelegate lastObjectOnstart;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "endPoint")
        {
            lastObjectOnstart();
            Debug.Log(gameObject.name+"event");
        }
    }
}
