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
	public float speed;
    public Transform endPoint;
    public Transform startPoint;
	public float cockY = (float)4.47;
	public float index = (float)1.3;
    private GameObject lastPref;
    void Start()
    {
        Init();
        rnd = new System.Random();
        Generate();
        lastObject.lastObjectOnstart += Generate;
		speed = 8;
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
        }
        lastPref.AddComponent<lastObject>();
        Debug.Log(lastPref.name);

    }

    public void Init()
    {

        scenes = new List<List<Prefab>>();

        scene = new List<Prefab>();
			prefab = new Prefab(DoubleBottle, new Vector3((float)11.81*index, (float)-0.71, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Protein, new Vector3((float)12.41*index, (float)1.4, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(FattyBitch, new Vector3((float)17.34*index, (float)-1.14, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Bottle, new Vector3((float)23.6*index, (float)-1.38, (float)-5.839844));
            scene.Add(prefab);

        scenes.Add(scene);

        scene = new List<Prefab>();
			prefab = new Prefab(Cock, new Vector3((float)13.11*index, cockY, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Protein, new Vector3((float)17.41*index, (float)1.4, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Bottle, new Vector3((float)23.6*index, (float)-1.28, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Cock, new Vector3((float)28.76*index, cockY, (float)-5.839844));
            scene.Add(prefab);
        scenes.Add(scene);

        scene = new List<Prefab>();
			prefab = new Prefab(FattyBitch, new Vector3((float)14.01*index, (float)-1.14, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Protein, new Vector3((float)17.41*index, (float)1.4, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(DoubleBottle, new Vector3((float)21.93*index, (float)-0.71, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Bottle, new Vector3((float)26.86*index, (float)-1.28, (float)-5.839844));
            scene.Add(prefab);
        scenes.Add(scene);

        scene = new List<Prefab>();
			prefab = new Prefab(Bottle, new Vector3((float)12.66*index, (float)-1.28, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Protein, new Vector3((float)18.37*index, (float)0.25, (float)0));
            scene.Add(prefab);
			prefab = new Prefab(Cock, new Vector3((float)21.01*index, cockY, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(DoubleBottle, new Vector3((float)29.54*index, (float)-0.71, (float)-5.839844));
            scene.Add(prefab);
        scenes.Add(scene);

        scene = new List<Prefab>();
			prefab = new Prefab(FattyBitch, new Vector3((float)13.92*index, (float)-1.14, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Protein, new Vector3((float)17.77*index, (float)1.13, (float)0));
            scene.Add(prefab);
			prefab = new Prefab(Bottle, new Vector3((float)19.3*index, (float)-1.28, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(DoubleBottle, new Vector3((float)24.1*index, (float)-0.71, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Cock, new Vector3((float)29.03*index, cockY, (float)-5.839844));
            scene.Add(prefab);
        scenes.Add(scene);

        scene = new List<Prefab>();
			prefab = new Prefab(Bottle, new Vector3((float)13.24971*index, (float)-1.28, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Bottle, new Vector3((float)18.08*index, (float)-1.28, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Cock, new Vector3((float)23.35*index, cockY, (float)-5.839844));
            scene.Add(prefab);
			prefab = new Prefab(Protein, new Vector3((float)27.25*index, (float)0.55, (float)0));
            scene.Add(prefab);
			prefab = new Prefab(Cock, new Vector3((float)31.07*index, cockY, (float)-5.839844));
            scene.Add(prefab);
        scenes.Add(scene);
		//#7 3 бутылки ради протеина надо рисковать
		scene = new List<Prefab>();
			prefab = new Prefab(Bottle, new Vector3((float)16.17971*index, (float)-1.28, (float)-5.839844));
			scene.Add(prefab);
			prefab = new Prefab(Protein, new Vector3((float)19.22*index, (float)1.09, (float)0));
			scene.Add(prefab);
			prefab = new Prefab(DoubleBottle, new Vector3((float)24.01*index, (float)-0.71, (float)-5.839844));
			scene.Add(prefab);
			prefab = new Prefab(Protein, new Vector3((float)27.99*index, (float)-1.31, (float)0));
			scene.Add(prefab);
			prefab = new Prefab(Bottle, new Vector3((float)29.07*index, (float)-1.28, (float)-5.839844));
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