using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static  GameManager _instance;
    static public GameManager Instance => _instance;

    public int TotalScore { get => _totalScore; set => _totalScore = value; }

    [SerializeField] GameObject _scoreText = default;
    [SerializeField] int _totalScore = 0;
    Text _text;

    void Awake()
    {
        if (_instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
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

    static public void AfterGacha(int num)
    {
        Instance._totalScore = num;
    }
    void OnDestroy()
    {
        if(_instance ==this)
        {
            _instance = null;
        }
    }


}
