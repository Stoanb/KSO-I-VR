using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class menu_cloths : Selectable, ISelectHandler
{
    public Animator m_animator;
    //public float secondsToWait;
   override protected void Start()
    {
        m_animator.SetBool("open", false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsHighlighted())
        {
            m_animator.SetBool("open", true);
        }
        if (!IsHighlighted() && m_animator.GetBool("open2") == false)
        {
            // StartCoroutine(waitCoroutine());
            m_animator.SetBool("open", false);
        }
        
        
    }

    override public void OnSelect(BaseEventData eventData)
    {
        m_animator.SetBool("open", true);
        return;
    }
    

   /* IEnumerator waitCoroutine()
    {
        yield return new WaitForSeconds(secondsToWait);
        m_animator.SetBool("open", false);
        
    }*/
}
