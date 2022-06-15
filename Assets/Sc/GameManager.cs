using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    static  GameManager _instance;
    static public GameManager Instance => _instance;

    public int TotalScore { get => _totalScore; set => _totalScore = value; }

    [SerializeField,Tooltip("現在のお金を表示するUI")] GameObject _scoreText = default;
    [SerializeField,Tooltip("現在のお金")] int _totalScore = 0;

    [SerializeField, Tooltip("ガチャができるお金")] int _underMoney = default;
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
        GacyaTime();
    }

    static public void AddMoney (int num)
    {
        Instance._totalScore += num;
    }

    static public void AfterGacha(int num)
    {
        Instance._totalScore = num;
    }

    void GacyaTime()
    {
        if (_underMoney <= _totalScore)
        {
            GcyaManager.Judgement(true);
        }
    }
    void OnDestroy()
    {
        if(_instance ==this)
        {
            _instance = null;
        }
    }


}
