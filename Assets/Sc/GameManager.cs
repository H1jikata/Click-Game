using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static private GameManager _instance = new GameManager();
    static public GameManager Instance => _instance;
    [SerializeField] GameObject _scoreText = default;
    [SerializeField] int _totalScore = 0;
    Text _scoreObject;
    private GameManager() { }
    void Update()
    {
        Text _scoreObject = _scoreText.GetComponent<Text>();
        _scoreObject.text = "" + _instance._totalScore;
    }

    static public void AddMoney (int num)
    {
        _instance._totalScore += num;
    }
}
