using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dynamic_Slider_Controller : MonoBehaviour
{
    [Header("Scripts")]
    public GameObject ControllerMotionStartScript; //Script 
    public GameObject fmodMusicScript; 
    public GameObject left_controller;
    public float leftcontrollerY;

    public Slider dynamic_Slider;

    public float StartControllingDynamicPos;
    public float controllerStartPos;
    
    [Tooltip("Adds a buffer between the controller start position and when to trigger an action.")]
    public float controllerDeadzone;

    [Tooltip("Adjusts when to turn of adjusting dynamics.")]
    public float controllerAddEndZone;

    [Tooltip("How much up the player must move to controller to get max dynamic value")]
    public float maxYRange;

    public float howMuchRangeFor_0_to_1;
    public float dynamicsValue;
    public float controllerDynamicSValue;

    public bool adjustingDynamics;

    [SerializeField]
    private bool gatherPosData;
    [SerializeField]
    private bool PositionGathered;
    private void Start()
    {
        PositionGathered = false;
        gatherPosData = false;
    }
    void Update()
    {
       gatherPosData = ControllerMotionStartScript.GetComponent<ControllerMotionStart>().gatherPosData;

        leftcontrollerY = left_controller.transform.position.y;

        if (gatherPosData == true && PositionGathered == false)
        {
            controllerStartPos = leftcontrollerY;
            StartControllingDynamicPos = controllerStartPos + controllerDeadzone;
            maxYRange = StartControllingDynamicPos + howMuchRangeFor_0_to_1;
            PositionGathered = true;
            
        }



        if (leftcontrollerY > StartControllingDynamicPos)
        {

            adjustingDynamics = true;
            fmodMusicScript.GetComponent<FmodMusic>().adjustSliderwithController(StartControllingDynamicPos, maxYRange, leftcontrollerY);

            ControllerMotionStartScript.GetComponent<ControllerMotionStart>().StartTheGame(true);

            //  rampAnimator.SetBool("DynamicsControllerOn", false);
        }

        if (leftcontrollerY < StartControllingDynamicPos - controllerAddEndZone)
        {
            adjustingDynamics = false;

        }
        if (adjustingDynamics == false)
        {
            fmodMusicScript.GetComponent<FmodMusic>().SetDefaultDynamic();

        }


    }


}
