using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class menu_clothHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Animator m_animator;

    private void Start()
    {
     
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        m_animator.SetBool("open2", true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        m_animator.SetBool("open2", false);
    }

}