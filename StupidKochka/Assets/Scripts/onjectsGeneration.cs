using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class onjectsGeneration : MonoBehaviour
{
    private List<List<Prefab>> scenes;
    private List<Prefab> scene;
    private Prefab prefab;
    public GameObject Bottle;
    public GameObject DoubleBottle;
    public GameObject FattyBitch;
    public GameObject Protein;
    public GameObject Cock;
    private System.Random rnd;
    public bool groundCheck;

    public Transform endPoint;
    public Transform startPoint;

    private GameObject lastPref;
    void Start()
    {
        Init();
        rnd = new System.Random();
        Generate();
        lastObject.lastObjectOnstart += Generate;
    }

    void Update()
    {
     
    }

  /*  IEnumerator WaitOneSecond()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject ob = Instantiate(balls, gameObject.transform.position, Quaternion.identity) as GameObject;
        Repeat();
    }*/

    public void Generate()
    {

        int i = rnd.Next(0, (scenes.Count));

        for (int j = 0; j < scenes[i].Count; j++)
        {
            lastPref = Instantiate(scenes[i][j].entity, scenes[i][j].coordinate, Quaternion.identity);
            lastPref.AddComponent<groundScroll>();
            lastPref.GetComponent<groundScroll>().endPoint = endPoint;
            lastPref.GetComponent<groundScroll>().startPoint = startPoint;
            lastPref.GetComponent<groundScroll>().speed = 8;
                         
        }
        
        lastPref.AddComponent<lastObject>();
        Debug.Log(lastPref.name);

    }

    public void Init()
    {

        scenes = new List<List<Prefab>>();

        scene = new List<Prefab>();
            prefab = new Prefab(DoubleBottle, new Vector3((float)11.81, (float)-0.91, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Protein, new Vector3((float)12.41, (float)1.4, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(FattyBitch, new Vector3((float)17.34, (float)-1, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Bottle, new Vector3((float)23.6, (float)-1.48, (float)-5.839844));
            scene.Add(prefab);

        scenes.Add(scene);

        scene = new List<Prefab>();
            prefab = new Prefab(Cock, new Vector3((float)13.11, (float)4.47, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Protein, new Vector3((float)17.41, (float)1.4, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Bottle, new Vector3((float)23.6, (float)-1.48, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Cock, new Vector3((float)28.76, (float)4.47, (float)-5.839844));
            scene.Add(prefab);
        scenes.Add(scene);

        scene = new List<Prefab>();
            prefab = new Prefab(FattyBitch, new Vector3((float)14.01, (float)-1, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Protein, new Vector3((float)17.41, (float)1.4, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(DoubleBottle, new Vector3((float)21.93, (float)-0.91, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Bottle, new Vector3((float)26.86, (float)-1.48, (float)-5.839844));
            scene.Add(prefab);
        scenes.Add(scene);
        scene = new List<Prefab>();
            prefab = new Prefab(Bottle, new Vector3((float)12.66, (float)-1.48, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Protein, new Vector3((float)18.37, (float)0.25, (float)0));
            scene.Add(prefab);
            prefab = new Prefab(Cock, new Vector3((float)21.01, (float)4.47, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(DoubleBottle, new Vector3((float)29.54, (float)-0.91, (float)-5.839844));
            scene.Add(prefab);
        scenes.Add(scene);

        scene = new List<Prefab>();
            prefab = new Prefab(FattyBitch, new Vector3((float)13.92, (float)-1, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Protein, new Vector3((float)17.77, (float)1.23, (float)0));
            scene.Add(prefab);
            prefab = new Prefab(Bottle, new Vector3((float)19.3, (float)-1.48, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(DoubleBottle, new Vector3((float)24.1, (float)-0.91, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Cock, new Vector3((float)29.03, (float)4.47, (float)-5.839844));
            scene.Add(prefab);
        scenes.Add(scene);

        scene = new List<Prefab>();
            prefab = new Prefab(Bottle, new Vector3((float)13.24971, (float)-1.48, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Bottle, new Vector3((float)18.08, (float)-1.48, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Cock, new Vector3((float)23.35, (float)3.99, (float)-5.839844));
            scene.Add(prefab);
            prefab = new Prefab(Protein, new Vector3((float)27.25, (float)0.55, (float)0));
            scene.Add(prefab);
            prefab = new Prefab(Cock, new Vector3((float)31.07, (float)4.47, (float)-5.839844));
            scene.Add(prefab);
        scenes.Add(scene);
    }
}

public class Prefab
{
    public Vector3 coordinate { get; set; }
    public GameObject entity { get; set; }

    public Prefab(GameObject entity, Vector3 coordinate)
    {
        this.entity = entity;
        this.coordinate = coordinate;
    }
}