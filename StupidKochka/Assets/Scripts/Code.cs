using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Code : MonoBehaviour
{

    // Use this for initializations
    StringBuilder str = new StringBuilder();
    void Start()
    {
        str.Append("scene = new List<Prefab>();\n");
        foreach (Transform child in transform)
        {
            str.Append("    prefab = new Prefab(" + child.name + ", new Vector3((float)" + child.transform.position.x + ", (float)" + child.transform.position.y + ", (float)" + child.transform.position.z + "));" + "\n    scene.Add(prefab);\n");
        }
        Debug.Log(str);
    }

    // Update is called once per frame
    void Update()
    {

    }
}