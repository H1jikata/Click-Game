using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test1 : MonoBehaviour
{
    [SerializeField] string _destroySceneName = "";
    private void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            SceneManager.LoadScene(_destroySceneName);
        }
    }
}

