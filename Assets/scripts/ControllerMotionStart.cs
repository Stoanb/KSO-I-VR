using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMotionStart : MonoBehaviour
{
    public GameObject fmodMusicScript;
    public GameObject dynamicSliderControllerScript;
    public GameObject starterHandsScript; 

    public GameObject L_controller;
    public GameObject R_controller;

    public float L_controllerPosY;
    public float R_controllerPosY;
    public float StartControllingDynamicPos;

    public bool gatherPosData;
    public bool startTheGame;
    
    void Start()
    {
        gatherPosData = false;
        startTheGame = false; 
    }

    // Update is called once per frame
    void Update()
    {
        L_controllerPosY = L_controller.transform.position.y;
        R_controllerPosY = R_controller.transform.position.y;

        if (L_controllerPosY != 0 && gatherPosData == false)
        {
            gatherPosData = true;

        }

 
    }

    public void StartTheGame(bool StartTheGame)
    {
        if (startTheGame == false)
        {
            startTheGame = true;
            starterHandsScript.GetComponent<starterHands>().StartVideos();
        }
    }

    
}
