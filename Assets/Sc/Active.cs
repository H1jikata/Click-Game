using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active : MonoBehaviour
{
    [SerializeField] string _coroutineName = "";
    [SerializeField] float _waitTime = 1;
    private void Start()
    {
        StartCoroutine(_coroutineName);
    }

    IEnumerator ActiveTime()
    {
        yield return new WaitForSeconds(_waitTime);
        Destroy(gameObject);
    }
}
