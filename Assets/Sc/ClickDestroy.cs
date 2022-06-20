using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDestroy : MonoBehaviour
{
    static bool Isflag = default;

    private void Start()
    {
        Isflag = false;
    }

    private void Update()
    {
        if(Isflag == true)
        {
            Destroy(this.gameObject);
        }
    }

    public static void FlagDestroy(bool isflag)
    {
        Isflag = isflag;
    }
}
