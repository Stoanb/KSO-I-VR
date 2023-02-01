using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStart : MonoBehaviour
{
    public GameObject headsetPos;
    public GameObject menu;
    public Vector3 offset;
    void Start()
    {
        menu.transform.position = headsetPos.transform.position + offset; 

    }

    // Update is called once per frame
    void Update()
    {
       // menu.transform.position = headsetPos.transform.position + offset;
    }
}
