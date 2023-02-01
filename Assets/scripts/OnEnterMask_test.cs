using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class OnEnterMask_test : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image img; 
  

  
   



   
   public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("yuur");
        img.color = Color.blue; 
           
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        Debug.Log("out");

    }

   /* public IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        if (insideArea == false)
        {
             
        }
    } */
}
