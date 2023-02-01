using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class rayCastHitCheck : MonoBehaviour
{
        void Update()    // Or FixedUpdate() for physical stuf
     {
         RaycastHit hit;
         if (Physics.Raycast(transform.position, transform.forward, out hit))
         {
             if (hit.collider != null)
             {
                 // Find the hit reciver (if existant) and call the method
                 var hitReciver = hit.collider.gameObject.GetComponent<rayHitReciever>();
                
                 Debug.Log("i hit" + hitReciver);
                 if (hitReciver != null)
                 {
                     Debug.Log(hitReciver);
                 }
             }
         }
     }
 }
 
