using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.Video;
using UnityEngine;
using UnityEngine.UI;


public class menuScript : MonoBehaviour
{
    public InputActionReference toggleRefrence = null;
    public Transform Headset_tracker;

    public GameObject canvas;
    public GameObject starterText; 

    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;

    public bool istracking;

  
    public videoStorer VideoStorer;




    private void Awake() {
        toggleRefrence.action.started += Toggle;
    }

    private void OnDestroy() {
        toggleRefrence.action.started += Toggle;
    }

    // Update is called once per frame
    void Update()
    {
        if (istracking)
        {
            transform.position = Vector3.SmoothDamp(transform.position, Headset_tracker.position, ref velocity, smoothTime);
            transform.rotation = Headset_tracker.rotation;
        }    
    }

    private void Toggle(InputAction.CallbackContext context){

        bool isActive = !canvas.activeSelf;
        canvas.SetActive(isActive);
        

    }
}
