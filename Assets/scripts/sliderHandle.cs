using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Room_sliderHandle : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Slider slider_handle;
    private Slider slider_proxy;
    public GameObject soloImage; 
    public Animator opacityAnim;
    public bool sliderHighlighted;
    public GameObject text; 


    void Start()
    {
        slider_proxy = GetComponent<Slider>();
        if(text == null)
        {
            Destroy(text);
        }
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
        text.SetActive(true);
        sliderHighlighted = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        opacityAnim.SetBool("triggered", false);
        text.SetActive(false);
        sliderHighlighted = false;
    }



}
