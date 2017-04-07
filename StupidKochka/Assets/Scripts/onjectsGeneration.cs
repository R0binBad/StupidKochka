using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class onjectsGeneration : MonoBehaviour {
    private List<List<Prefab>> scenes;
    private List<Prefab> scene;
    private Prefab prefab;
    public GameObject bottel;
    public GameObject doubleBottel;
    public GameObject fattyBitch;
    private System.Random rnd;

    void Start() {
        Init();
        rnd = new System.Random();
    }

    void Update() {
        Generate();
       
    }
   
    public void Generate() {
        
            int i = rnd.Next(0, scenes.Count);

        for (int j = 0; j < scenes[i].Count; j++)
        {
            if (scene[0].coordinate.x < 10)
                Instantiate(scene[i].entity, scene[i].coordinate, Quaternion.identity);
        }
    }

   public void Init() {

        scenes = new List<List<Prefab>>();

            scene = new List<Prefab>();

                //элементы сцены
                prefab = new Prefab(bottel , new Vector3(transform.position.x , transform.position.y, transform.position.z));
                scene.Add(prefab);

                prefab = new Prefab(doubleBottel, new Vector3(transform.position.x + 2, transform.position.y, transform.position.z));
                scene.Add(prefab);

                prefab = new Prefab(fattyBitch, new Vector3(transform.position.x + 4, transform.position.y, transform.position.z));
                scene.Add(prefab);

        scenes.Add(scene);

            scene = new List<Prefab>();

              prefab = new Prefab(bottel, new Vector3(transform.position.x + 5, transform.position.y, transform.position.z));
              scene.Add(prefab);

              prefab = new Prefab(doubleBottel, new Vector3(transform.position.x + 6, transform.position.y, transform.position.z));
              scene.Add(prefab);

              prefab = new Prefab(fattyBitch, new Vector3(transform.position.x + 7, transform.position.y, transform.position.z));
              scene.Add(prefab);
        scenes.Add(scene);

    }
}

public class Prefab
{
     public Vector3 coordinate { get; set; }
     public GameObject entity { get; set; }

    public  Prefab(GameObject entity, Vector3 coordinate)
    {
        this.entity = entity;
        this.coordinate = coordinate;
    }
}