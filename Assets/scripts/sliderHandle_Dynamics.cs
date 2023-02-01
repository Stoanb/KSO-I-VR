using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class sliderHandle_Dynamics : MonoBehaviour
{
    public Slider slider_handle;
    public GameObject fmodSoundScript; 
    public Animator opacityAnim;
  
 

    private void Update()
    {
        if(fmodSoundScript.GetComponent<FmodMusic>().adjustingDynamics == true)
        {
            opacityAnim.SetBool("triggered", true);
        }
        else
        {
            opacityAnim.SetBool("triggered", false);
        }
    }
}
