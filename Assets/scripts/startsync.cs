using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class startsync : MonoBehaviour
{
    
     public VideoPlayer videoPlayer; 
     public GameObject fmodEmitter;

     public bool init;
     
    // Start is called before the first frame update
    void Start()
    {
    
    videoPlayer.Prepare();
    init = true;
    }

    

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(videoPlayer.isPrepared);

        if(videoPlayer.isPrepared && init == true){
           
            videoPlayer.Play();
            Debug.Log("starting video");
             fmodEmitter.SetActive(true);
            Debug.Log("starting Fmod");
            videoPlayer.playOnAwake = true;
            init = false;


            
            
        }
    }
}
