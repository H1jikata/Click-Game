using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField, Tooltip("クリックして足される数")] static int _addScore = 1;

    public void Click()
    {
        ScoreButtom();
    }
    static  public void ScoreButtom()
    {
        GameManager.AddMoney(_addScore);
    }
}