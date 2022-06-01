using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalClick : MonoBehaviour
{
    [SerializeField] bool cheat = false;
    static int _addScore = 1;

    public void Click()
    {
        ScoreButtom();
        if (cheat) _addScore += 1000000;
    }
    static  public void ScoreButtom()
    {
        GameManager.AddMoney(_addScore);
    }
}