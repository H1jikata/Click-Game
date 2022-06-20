using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateBase : MonoBehaviour
{
    [SerializeField] List<GameObject> _mashPhoto = new List<GameObject>();
    [SerializeField] GameObject _mashMoji = default;

    [SerializeField] int _currentNum = default;

    List<string> _sortMash = new List<string>();
    GameObject _resourcesBox = default;

    Text _text;
    void Start()
    {
        ListSorted();

        _resourcesBox = Resources.Load(_sortMash[_currentNum]) as GameObject;
        Instantiate(_resourcesBox, new Vector3(-4.31f, 0.14f, 1f), Quaternion.identity);

        _text = _mashMoji.GetComponent<Text>();
        _text.text = _sortMash[_currentNum];
    }
    public void OnNextClick()
    {
        if(_mashPhoto.Count - 1 <= _currentNum)
        {
            ClickDestroy.FlagDestroy(true);

            _currentNum = 0;
            InstancePho();
        }
        else
        {
            ClickDestroy.FlagDestroy(true);

            _currentNum++;
            InstancePho();
        }
    }
    public void OnReturnClick()
    {
        if (0 >= _currentNum)
        {
            ClickDestroy.FlagDestroy(true);

            _currentNum = _mashPhoto.Count - 1;
            InstancePho();
        }
        else
        {
            ClickDestroy.FlagDestroy(true);

            _currentNum--;
            InstancePho();
        }
    }

    void ListSorted()
    {
        for (int i = 0; i < _mashPhoto.Count; i++)
        {
            _sortMash.Add(_mashPhoto[i].name);
        }
        _sortMash.Sort();
    }

    void InstancePho()
    {
        _resourcesBox = Resources.Load(_sortMash[_currentNum]) as GameObject;
        Instantiate(_resourcesBox, new Vector3(-4.31f, 0.14f, 1f), Quaternion.identity);
        _text.text = _sortMash[_currentNum];
    }
}
