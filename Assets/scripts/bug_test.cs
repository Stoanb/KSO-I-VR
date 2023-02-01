using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bug_test : MonoBehaviour
{
    public GameObject controller;
    public float leftcontroller;
    public Slider sliderTest; 
    private void Start()
    {
        
    }
    void Update()
    {
        leftcontroller = controller.transform.position.y;
        sliderTest.value = leftcontroller; 
    }
}
