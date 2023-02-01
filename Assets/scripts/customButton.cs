using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class customButton : Selectable
{
    public float alphaThreshhold = 0.5f;
    public bool customShape;
    public bool followPlayer; 
    public bool sliderIsHighligheted;
    public float turnOffDelay; 
    
    public Transform target;
    public GameObject slider;
    public GameObject text; 
    public GameObject sliderScript;

    public bool iscounting; 
 


   protected override void Start()
    {

        iscounting = false;
        
        if (customShape)
        {
            GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshhold;
        }

    }
   public void Update() {

        if (followPlayer)
        {
            transform.LookAt(target);

        }

        sliderIsHighligheted = sliderScript.GetComponent<sliderHandle>().sliderHighlighted;

        if (IsHighlighted() || sliderIsHighligheted == true)
        {
            slider.SetActive(true);
            text.SetActive(true);
            iscounting = false;
        }
        else
        {
            slider.SetActive(false);
            text.SetActive(false);
        }   
    }
   override public void OnSelect(BaseEventData eventData)
    {
        return;
    }
}
   

    

