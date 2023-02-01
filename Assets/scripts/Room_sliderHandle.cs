using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class sliderHandle : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Slider slider_handle;
    private Slider slider_proxy;
    public GameObject soloImage; 
    public Animator opacityAnim;
    public bool sliderHighlighted;
 


    void Start()
    {
        slider_proxy = GetComponent<Slider>();
        
    }

    private void Update()
    {
        slider_handle.value = slider_proxy.value; 

        if(slider_handle.value >= 0.99f)
        {
            soloImage.SetActive(true);
        }
        else
        {
            soloImage.SetActive(false);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        opacityAnim.SetBool("triggered", true);
       
        sliderHighlighted = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        opacityAnim.SetBool("triggered", false);
  
        sliderHighlighted = false;
    }



}
