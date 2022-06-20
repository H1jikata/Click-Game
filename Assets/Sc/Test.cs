using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortClass : MonoBehaviour
{
    public string Name;
    public GameObject GameObject;

    public SortClass(string Name, GameObject GameObject)
    {
        this.Name = Name;
        this.GameObject = GameObject;
    }
}
