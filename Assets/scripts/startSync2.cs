using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class startsync2 : MonoBehaviour
{
    
     public VideoPlayer videoPlayerCasual; 
     public VideoPlayer videoPlayerFormal; 
     public VideoPlayer videoPlayerFestive; 
     public GameObject fmodEmitter;

     public bool init;
     
    // Start is called before the first frame update
    void Start()
    {
    
    videoPlayerCasual.Prepare();
    init = true;
    }

    

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(videoPlayer.isPrepared);

        if(videoPlayerCasual.isPrepared && init == true){
           
            videoPlayerCasual.Play();
            Debug.Log("starting video");
             fmodEmitter.SetActive(true);
            Debug.Log("starting Fmod");
            videoPlayerCasual.playOnAwake = true;
            init = false;


            
            
        }
    }
}
