using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProteinChecker : MonoBehaviour
{
    public Text txt;
    //private int amount = 0;
    private float distance;
    public Slider progressBar;
    private float speed;
    //Посмотреть как будет работать при генерации новых сцен, типа объекты удаляются же,
    //если сцена будет рандомом второй раз выбрана, останутся ли там банки или нет
    void Start()
    {
        speed = 8;
        distance = 0;
    }

    void OnTriggerEnter2D(Collider2D prot)
    {
        if (prot.transform.tag == "coin")
        {
           // amount += 1;
            Destroy(prot.gameObject);
            progressBar.value += 25;
        }
     

    }
    void OnGUI()
    {
        if (gameObject.GetComponent<Player>().isLive == true)//пока жив обновлять
        {
            progressBar.value -= Time.deltaTime * 5;
            if (progressBar.value == 0) gameObject.GetComponent<Player>().isLive = false;//если катаболизм ноль-смерть
            distance += (Time.deltaTime * speed) / 5;
            txt.text = System.Math.Round(distance, 0).ToString() + " м";
        }
    }
}

