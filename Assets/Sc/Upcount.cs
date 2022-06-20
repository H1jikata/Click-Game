using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upcount : MonoBehaviour
{
    [SerializeField] int _AddMoney = 0; //放置で増えるお金
    [SerializeField] float _time = default; 
    [SerializeField,Tooltip("お金が増えるインターバル")] float _interval = 2;

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
        if(_AddMoney　== 0)
        {
            _AddMoney = 1;
        }
        else
        {
            _AddMoney *= 10;
        }
    }

    void UpCount()
    {
        GameManager.AddMoney(_AddMoney);
    }
}
