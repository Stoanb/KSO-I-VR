using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class OnEnterMask : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool followPlayer;
    public bool sliderIsHighligheted;
    public bool insideArea;
    public bool sliderActivated; 
   

  
    public GameObject slider;
    public GameObject text;
    public GameObject sliderScript;

    public bool iscounting;
    public void Start()
    {

        iscounting = false;
        sliderActivated = false;
       

    }
    public void Update()
    {

     

         sliderIsHighligheted = sliderScript.GetComponent<sliderHandle>().sliderHighlighted;

        if (insideArea || sliderIsHighligheted == true)
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

   
   public void OnPointerEnter(PointerEventData eventData)
    {
        insideArea = true;
           
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        insideArea = false;
    
    }

   /* public IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        if (insideArea == false)
        {
             
        }
    } */
}
