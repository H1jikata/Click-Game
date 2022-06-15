using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GcyaManager : MonoBehaviour
{
    //ガチャからでるものを入れるList
    [SerializeField] List<GameObject> _normal = new List<GameObject>();
    [SerializeField] List<GameObject> _rare = new List<GameObject>();
    [SerializeField] List<GameObject> _sRare = new List<GameObject>();
    [SerializeField] List<GameObject> _ssRare = new List<GameObject>();

    //ガチャができなかったときにだす、UI
    [SerializeField] GameObject _cantGacyaPrefub = default;
    [SerializeField] GameObject _prefubLocation = default;

    [SerializeField,Tooltip("ガチャできるかを判断するフラグ")] static bool Isflag = default;
    [SerializeField] bool IsTestFlag = default;

    []
    [SerializeField] float _rndProbability = default;


    private void Update()
    {
        Isflag = IsTestFlag;
    }

    public void OnClick()
    {
        if(Isflag == true)
        {
            Gacha();
        }
        else
        {
            Instantiate(_cantGacyaPrefub, _prefubLocation.transform);
        }
    }

    void Gacha()
    {
        _rndProbability = Random.Range(0f, 100f);
        //if()
    }

    static public void Judgement(bool isGacya)
    {
        Isflag = isGacya;
    }
}
