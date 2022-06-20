using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnScene : MonoBehaviour
{
    [SerializeField] string _destroySceneName = "";
    private void Update()
    {
        if(Input.GetButton("Cancel"))
        {
            SceneManager.UnloadSceneAsync(_destroySceneName);
        }
    }
}
