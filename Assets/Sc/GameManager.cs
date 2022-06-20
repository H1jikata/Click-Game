﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static  GameManager _instance;
    static public GameManager Instance => _instance;

    public int TotalScore { get => _totalScore; set => _totalScore = value; }

    [SerializeField,Tooltip("現在のお金を表示するUI")] GameObject _scoreText = default;
    [SerializeField,Tooltip("現在のお金")] int _totalScore = 0;

    [SerializeField, Tooltip("ガチャができるお金")] int _underMoney = default;

    [SerializeField] List<GameObject> _bottoms = new List<GameObject>();
    [SerializeField] string _ZukanSceneName = "";
    [SerializeField] string _GachaSceneName = "";

    static public int TotalMoney => _instance._totalScore;
    static bool IsLevelUp = default;

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

        for(int i = 0; i < _bottoms.Count; i++)
        {
            _bottoms[i].SetActive(false);
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
        Active();
    }

    static public void AddMoney (int num)
    {
        Instance._totalScore += num;
    }

    static public void AfterGacha(int num)
    {
        Instance._totalScore -= num;
    }

    void GacyaTime()
    {
        if (_underMoney <= _totalScore)
        {
            GcyaManager.Judgement(true);
        }
        else
        {
            GcyaManager.Judgement(false);
        }
    }

    static public void CanLevelUp(bool islevelup)
    {
        IsLevelUp = islevelup;
    }

    void Active()
    {
        if (IsLevelUp == true)
        {
            for (int i = 0; i < _bottoms.Count; i++)
            {
                if (_bottoms[i] != null)
                _bottoms[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < _bottoms.Count; i++)
            {
                if(_bottoms[i] != null)
                _bottoms[i].SetActive(false);
            }
        }
    }

    public void Onclicked()
    {
        IsLevelUp = false;
    }

    public void GacyaLoad()
    {
        SceneManager.LoadScene(_GachaSceneName, LoadSceneMode.Additive);
    }

    public void ZukanLoad()
    {
        SceneManager.LoadScene(_ZukanSceneName);
        //SceneManager.LoadScene(_ZukanSceneName, LoadSceneMode.Additive);
    }

    void OnDestroy()
    {
        if(_instance == this)
        {
            _instance = null;
        }
    }
    public void Load()
    {
        //デバッグ時に楽なのでdataPathにしてるけど、persistentDataPathが適切
        var save = LocalData.Load<SaveData>(Application.dataPath + "/save.json");
        if (save == null)
        {
            save = new SaveData();
        }

        _totalScore = save.TotalMoney;
    }

    public void Save()
    {
        SaveData save = new SaveData();

        save.TotalMoney = _totalScore;

        LocalData.Save<SaveData>(Application.dataPath + "/save.json", save);
    }
}
