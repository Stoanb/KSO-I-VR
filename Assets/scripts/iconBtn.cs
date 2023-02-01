using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class iconBtn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool ishighlighted;
    public Slider fluteSlider; 
      public void OnPointerEnter(PointerEventData eventData){

          
          ishighlighted = true;

    }

    public void OnPointerExit(PointerEventData eventData){

        
        ishighlighted = false;

        }

    public void setSliderActive(){

        bool isActive = !fluteSlider.gameObject.activeSelf;
        fluteSlider.gameObject.SetActive(isActive);
    }


}
   