using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FMODUnity;


public class volumeController : MonoBehaviour
{
    string masterBusString = "event:/Normal dynamics";
    FMOD.Studio.Bus masterbus;
    public Slider slider; 
    public float volume;

    public float offset;
    private float setControllerPos;
    public bool isAdjustingVolume = false;
    
    // Start is called before the first frame update
    void Start()
    {
       // volume = 2.5f;
       masterbus = FMODUnity.RuntimeManager.GetBus(masterBusString);
       Debug.Log(masterbus);
    }

    // Update is called once per frame
    void Update()
    {

        //When click controller, y range gets locked
        //When over or lower than the set Y, sets the volume accordingly 
        //

        if(isAdjustingVolume){

            adjustVolume();

        };

    }

    public void setControllerPosition(){

        setControllerPos = gameObject.transform.position.y;

        setAdjustVolumeBool();
    }

    public void setAdjustVolumeBool() {

        if(!isAdjustingVolume){
            isAdjustingVolume = true;
        }
        else {
            isAdjustingVolume = true;
        }
    }

    public void adjustVolume(){

        // hvis kontroller går under setcontrollerpos, gjør den til minus. 

        float adjustedControllerPos; 

         adjustedControllerPos = -gameObject.transform.position.y;

        offset = setControllerPos + adjustedControllerPos;
        volume = 0.5f + -offset;

        slider.value = volume;
        /*

        float volumePlaceHolder = 0f; 
        
        Debug.Log("Adjusting Volume to: " + volume + offset);
        volume = 50 + offset; 
        volumePlaceHolder = volume;
        
      
//Hvis volumet er det samme, ikke gjør noe. */

    }



}
