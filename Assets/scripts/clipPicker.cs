using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class clipPicker : MonoBehaviour
{
    
  public VideoPlayer vp;
    //public AudioSource audioSource; 
    public VideoClip aClip;
    public double clipTime;

    public float cooldownPress = 2f;
    public float nextPress = 0.0f;

    
    void Start()
    {
       // GameObject findAudio = GameObject.FindGameObjectWithTag("menu");
       // audioSource = findAudio.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
    
  #region  //Manuel bytting av scener ved å bruke tastatur
  /*  if(Input.GetKeyDown(KeyCode.Alpha1)){
            Debug.Log("Playing Casual clip");
            clipTime = vp.time;
            vp.clip = clip_Casual;
            setTime();    
          
        }
        else if (Input.GetKeyUp(KeyCode.Alpha2)){
            Debug.Log("Playing Formal Clip");
            clipTime = vp.time;
            Debug.Log("Clip time is: " + clipTime);
            
            vp.clip = clip_Formal;
            setTime();    
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)){
            Debug.Log("Playing Galla Clip");
            clipTime = vp.time;
            vp.clip = clip_Galla;
            setTime();    
         

        } */

    #endregion

    }
  
     private void OnTriggerEnter(Collider other) {

        if(Time.time > nextPress){
         nextPress = Time.time + cooldownPress;
         Debug.Log("playing next" + aClip);

             //Debug.Log("Cooldowntimer is: " + cooldownPress);

            clipTime = vp.time;
          //  audioSource.Play();
            vp.clip = aClip;
            vp.time = clipTime;
        }
    }

}
