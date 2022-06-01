using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static private GameManager _instance = new GameManager();
    static public GameManager Instance => _instance;
    private GameManager() { }

    [SerializeField] GameObject _scoreText = default;
    [SerializeField] int _totalScore = 0;
    Text _text;

    void Awake()
    {
        if (Instance == null) DontDestroyOnLoad(this.gameObject);
        else Destroy(this);
    }
    void Start()
    {
        _text = _scoreText.GetComponent<Text>();
    }
    void Update()
    {
        _text.text = "" + Instance._totalScore;
    }

    static public void AddMoney (int num)
    {
        Instance._totalScore += num;
    }
}
