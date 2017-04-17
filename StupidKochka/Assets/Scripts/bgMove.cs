using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMove : MonoBehaviour
{

    public float speed;
    Vector2 bgPos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveBg();
    }

    public void moveBg()
    {
        bgPos = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = bgPos;
    }

}
