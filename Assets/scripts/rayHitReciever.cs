using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
public class rayHitReciever : MonoBehaviour
{

     public void OnRayHit()
     {
         Debug.Log("i am hit" + gameObject);
     }
}
