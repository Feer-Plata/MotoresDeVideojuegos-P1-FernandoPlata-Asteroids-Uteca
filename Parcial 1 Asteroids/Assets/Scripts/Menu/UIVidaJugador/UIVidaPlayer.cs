using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIVidaPlayer : MonoBehaviour
{
    //Atributos de jugador
    public  List<GameObject> Heart;
    int restHeart = 0;
    int auxHeart;

    public  void LifePlayer(int restHeart)
    {
        int auxHeart = Heart.Count;
        Destroy(Heart[auxHeart - restHeart]);
    }
}
