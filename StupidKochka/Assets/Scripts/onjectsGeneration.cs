using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

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
        for (int j = 0; j < scenes[0].Count; j++)
        {
           Instantiate(scene[j].entity, scene[j].coordinate, Quaternion.identity);
        }
    }

    void Update() {

        Generate();
       
    }
   
    public void Generate() {
        
            int i = rnd.Next(0, scenes.Count);

        for (int j = 0; j < scenes[0].Count; j++)
        {
            if (scene[2].coordinate.x < transform.position.x)
            {
               Instantiate(scene[j].entity, scene[j].coordinate, Quaternion.identity);
            }
        }
    }

   public void Init() {

        scenes = new List<List<Prefab>>();

            scene = new List<Prefab>();

                //элементы сцены
                prefab = new Prefab(bottel , new Vector3(transform.position.x , transform.position.y, transform.position.z));
                scene.Add(prefab);

                prefab = new Prefab(doubleBottel, new Vector3(transform.position.x + 5, transform.position.y, transform.position.z));
                scene.Add(prefab);

                prefab = new Prefab(fattyBitch, new Vector3(transform.position.x + 15, transform.position.y, transform.position.z));
                scene.Add(prefab);

        scenes.Add(scene);

            scene = new List<Prefab>();

              prefab = new Prefab(bottel, new Vector3(transform.position.x , transform.position.y, transform.position.z));
              scene.Add(prefab);

              prefab = new Prefab(doubleBottel, new Vector3(transform.position.x + 6, transform.position.y, transform.position.z));
              scene.Add(prefab);

              prefab = new Prefab(fattyBitch, new Vector3(transform.position.x + 12, transform.position.y, transform.position.z));
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