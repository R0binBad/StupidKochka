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
    private System.Random rnd;

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

    public void Generate()
    {

        int i = rnd.Next(0, (scenes.Count));

        for (int j = 0; j < scenes[i].Count; j++)
        {
            lastPref = Instantiate(scenes[i][j].entity, scenes[i][j].coordinate, Quaternion.identity);
            lastPref.AddComponent<groundScroll>();
            lastPref.GetComponent<groundScroll>().endPoint = endPoint;
            lastPref.GetComponent<groundScroll>().startPoint = startPoint;
            lastPref.GetComponent<groundScroll>().speed = 6;
        }
        lastPref.AddComponent<lastObject>();

    }

    public void Init()
    {

        scenes = new List<List<Prefab>>();

        scene = new List<Prefab>();
        prefab = new Prefab(DoubleBottle, new Vector3((float)9.71, (float)-0.1, (float)-5.839844));
        scene.Add(prefab);
        prefab = new Prefab(FattyBitch, new Vector3((float)14.38, (float)-1.05, (float)-5.839844));
        scene.Add(prefab);
        prefab = new Prefab(Bottle, new Vector3((float)21.18, (float)-1.11, (float)-5.839844));
        scene.Add(prefab);
        scenes.Add(scene);

        scene = new List<Prefab>();
        prefab = new Prefab(DoubleBottle, new Vector3((float)12.15, (float)-0.3, (float)-5.839844));
        scene.Add(prefab);
        prefab = new Prefab(Bottle, new Vector3((float)16.75, (float)-1.23, (float)-5.839844));
        scene.Add(prefab);
        prefab = new Prefab(FattyBitch, new Vector3((float)18.93, (float)-1.13, (float)-5.839844));
        scene.Add(prefab);
        scenes.Add(scene);

        scene = new List<Prefab>();
        prefab = new Prefab(FattyBitch, new Vector3((float)10.93, (float)-1.13, (float)-5.839844));
        scene.Add(prefab);
        prefab = new Prefab(FattyBitch, new Vector3((float)13.93, (float)-1.13, (float)-5.839844));
        scene.Add(prefab);
        prefab = new Prefab(Bottle, new Vector3((float)16.75, (float)-1.23, (float)-5.839844));
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