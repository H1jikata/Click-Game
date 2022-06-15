using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDoubleManager : MonoBehaviour
{
    [SerializeField,Tooltip("建てる建物のPrefub")] GameObject _buildingPrefub = default;
    [SerializeField,Tooltip("建物を建てる位置")] GameObject[] _buildingPosi = default;
    [SerializeField,Tooltip("建ってる建物の数")] int _currentNum = 0;
    [SerializeField,Tooltip("倍数")] int _doubleNum = 2;


    void Start()
    {
        for(int i  = 0; i < _buildingPosi.Length; i++)
        {
            Instantiate(_buildingPrefub,_buildingPosi[i].transform);
            _buildingPosi[i].SetActive(false);
        }
    }
    
    public void OnClick()
    {
        _buildingPosi[_currentNum].SetActive(true);
        _currentNum++;
        Effect();
    }

    void Effect()
    {
        NormalClick.AddScore = NormalClick.AddScore * _doubleNum;
    }
}
