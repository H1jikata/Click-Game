using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalClick : MonoBehaviour
{
    [SerializeField] bool cheat = false;
    public static int _addScore = 1;

    public static int AddScore { get => _addScore; set => _addScore = value; }

    public void Click()
    {
        ScoreButtom();
        if (cheat)
        {
            AddScore += 1000000;
        }
    }
    static  public void ScoreButtom()
    {
        GameManager.AddMoney(AddScore);
    }
}