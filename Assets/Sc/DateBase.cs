using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DateBase : MonoBehaviour
{
    [SerializeField] List<GameObject> _mashPhoto = new List<GameObject>();
    [SerializeField] List<GameObject> _mashMoji = new List<GameObject>();
    [SerializeField] List<bool> IsYouWin = new List<bool>();

    [SerializeField] GameObject _missingPhoto = default;

    [SerializeField] GameObject _photoPos = default;
    [SerializeField] GameObject _mojiPos = default;

    List<string> _sortMash = new List<string>();
    void Start()
    {
    }
    public void OnNextClick()
    {

    }
    public void OnReturnClick()
    {

    }

    void ListSort()
    {
        for (int i = 0; i < _mashPhoto.Count; i++)
        {
            _sortMash[i] = _mashPhoto[i].name;
        }
        _sortMash.Sort();
    }
}
