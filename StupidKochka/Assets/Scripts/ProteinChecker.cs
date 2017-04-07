using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProteinChecker : MonoBehaviour
{
    public Transform prot;
    public Text txt;
    private int amount = 0;

    //Посмотреть как будет работать при генерации новых сцен, типа объекты удаляются же,
    //если сцена будет рандомом второй раз выбрана, останутся ли там банки или нет

    void OnTriggerEnter2D(Collider2D prot)
    {
        if (prot.transform.tag == "coin")
        {
            amount += 1;
            Destroy(prot.gameObject);
        }
     

    }
    void OnGUI()
        {
            txt.text = "Score: "+ amount.ToString();
        }
}

