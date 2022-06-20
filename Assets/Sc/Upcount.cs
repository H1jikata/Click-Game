using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upcount : MonoBehaviour
{
    [SerializeField] int _AddMoney = 0; //放置で増えるお金
    [SerializeField] float _time = default; 
    [SerializeField,Tooltip("お金が増えるインターバル")] float _interval = 2;

    [SerializeField, Tooltip("建てる建物のPrefub")] GameObject _buildingPrefub = default;
    [SerializeField, Tooltip("建物を建てる位置")] GameObject[] _buildingPosi = default;
    [SerializeField, Tooltip("建ってる建物の数")] int _currentNum = 0;

    void Start()
    {
        for (int i = 0; i < _buildingPosi.Length; i++)
        {
            Instantiate(_buildingPrefub, _buildingPosi[i].transform);
            _buildingPosi[i].SetActive(false);
        }
    }
    private void Update()
    { 
        _time += Time.deltaTime;
        if(_time >= _interval)
        {
            UpCount();
            _time = 0;
        }
    }
    public void OnLevelUp()
    {
        if (_buildingPosi.Length > _currentNum)
        {
            _buildingPosi[_currentNum].SetActive(true);
            _currentNum++;
            if (_AddMoney == 0)
            {
                _AddMoney = 1;
            }
            else
            {
                _AddMoney *= 10;
            }
        }
    }

    void UpCount()
    {
        GameManager.AddMoney(_AddMoney);
    }
}
