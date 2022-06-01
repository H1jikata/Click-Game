using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDouble : MonoBehaviour
{
    [SerializeField,Tooltip("建物のprefub")] GameObject[] _buildingPrefub = default;
    [SerializeField] int _buildingNum = 10;
    void Start()
    {
        _buildingPrefub = new GameObject[_buildingNum];
    }
    void Update()
    {
        
    }
}
