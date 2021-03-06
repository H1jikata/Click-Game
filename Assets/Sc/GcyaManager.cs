using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GcyaManager : MonoBehaviour
{
    [SerializeField] int _maneyCost = 50;
    //ガチャからでるものを入れるList
    [SerializeField] List<GameObject> _normal = new List<GameObject>();
    [SerializeField] List<GameObject> _rare = new List<GameObject>();
    [SerializeField] List<GameObject> _sRare = new List<GameObject>();
    [SerializeField] List<GameObject> _ssRare = new List<GameObject>();

    //ガチャができなかったときにだす、UI
    [SerializeField] GameObject _cantGacyaPrefub = default;
    [SerializeField] GameObject _prefubLocation = default;

    [SerializeField,Tooltip("ガチャができるかを判断するフラグ")] static bool Isflag = default;

    //すべてのレアリティの確率
    [SerializeField,Tooltip("ノーマルの確率")] float _nRnd = default;
    [SerializeField,Tooltip("レアの確率")] float _rRnd = default;
    [SerializeField,Tooltip("スーパーレアの確率")] float _sRnd = default;
    [SerializeField,Tooltip("スーパースペシャルレアのの確率")] float _ssRnd = default;

    [SerializeField,Tooltip("確率を格納する変数")] float _rndProbability = default;
    [SerializeField,Tooltip("Listの要素数")] int _rndNum = default;

    [SerializeField,Tooltip("ガチャからでたものをだすところ")] GameObject _instancePos = default;
    [SerializeField,Tooltip("ガチャからでるお金")] int _money = 10;

    [SerializeField] GameObject _textObject = default;
    Text _text;

    private void Start()
    {
        _text = _textObject.GetComponent<Text>();
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
        if(_nRnd <= _rndProbability)
        {
            _rndNum = Random.Range(0, _normal.Count);
            Instantiate(_normal[_rndNum], _instancePos.transform);
            if(_normal[_rndNum] == _normal[1])
            {
                GameManager.AddMoney(_money);
            }
            _text.text = "Normal";
            _text.color = Color.white;
            Debug.Log("n");
        }
        else if(_rRnd <= _rndProbability && _nRnd > _rndProbability)
        {
            _rndNum = Random.Range(0, _rare.Count);
            Instantiate(_rare[_rndNum], _instancePos.transform);
            _text.text = "Rare";
            _text.color = Color.black;
            Debug.Log("r");
        }
        else if(_sRnd <= _rndProbability && _rRnd > _rndProbability )
        {
            _rndNum = Random.Range(0, _sRare.Count);
            Instantiate(_sRare[_rndNum], _instancePos.transform);
            if (_sRare[_rndNum] == _sRare[1])
            {
                GameManager.CanLevelUp(true);
            }
            _text.text = "SRare";
            _text.color = Color.yellow;
            Debug.Log("s");
        }
        else if(_ssRnd > _rndProbability)
        {
            _rndNum = Random.Range(0, _ssRare.Count);
            Instantiate(_ssRare[_rndNum], _instancePos.transform);
            Debug.Log("ss");
            _text.text = "SSRare";
            _text.color = Color.red;
        }
        GameManager.AfterGacha(_maneyCost);
    }

    static public void Judgement(bool isGacya)
    {
        Isflag = isGacya;
    }
}
