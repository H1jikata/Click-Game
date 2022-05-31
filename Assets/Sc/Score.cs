using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField, Tooltip("トータルスコア")] int _addScore = 0;

     public void ScoreButtom()
    {
        _addScore++;
    }
}