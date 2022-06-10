using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GcyaManager : MonoBehaviour
{
    //ガチャからでるものを入れるList
    [SerializeField] List<GameObject> _normal = new List<GameObject>();
    [SerializeField] List<GameObject> _rare = new List<GameObject>();
    [SerializeField] List<GameObject> _srare = new List<GameObject>();
    [SerializeField] List<GameObject> _ssrare = new List<GameObject>();

    static int _currentMoney = 0;

    void start()
    {

    }

    public void OnClick()
    {
        Gacha();
        //_currentMoney = GameManager.TotalScore; 
    }

    void Gacha()
    {

    }
}
