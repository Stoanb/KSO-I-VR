using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class videoStorer : MonoBehaviour
{
   public VideoPlayer casual;
   public VideoPlayer shades;
   public VideoPlayer formal;
   public VideoPlayer lastplayed;


    public GameObject fmodObjects;
    public GameObject fmodController;
    public Button startButton;
  
   public TMPro.TMP_Dropdown dropdown;

    // private ArrayList themes; 
    public List<VideoPlayer> themes = new List<VideoPlayer>();
    public bool allVideosPlaying;
    [Tooltip("Set to 0.2 when building on headset for delay")]
    public float wait; 
    private bool doOnce = true;
    private bool playingVideos = false;

  

private void Start() {
   
   lastplayed = casual;
        allVideosPlaying = false; 

}
   private void Update() {

        /*
          if (formal.isPrepared == true && playingVideos == false && fmodController.GetComponent<FmodMusic>().masterBankLoaded == true)
        {
            Debug.Log("All videos are prepared");
            //  fmodController.GetComponent<FmodMusic>().startMusic();
            // playAllvideos();

            ShowFirstFrame();
            // StartCoroutine(waitForLoad());
            startButton.SetActive(true);
            playingVideos = true;
            
                    }*/

        if (playingVideos == false && fmodController.GetComponent<FmodMusic>().masterBankLoaded == true)
        {
            Debug.Log("All videos are prepared");
            //  fmodController.GetComponent<FmodMusic>().startMusic();
            // playAllvideos();

            ShowFirstFrame();
            // StartCoroutine(waitForLoad());
            //startButton.SetActive(true);
            playingVideos = true;
            
                    }
        if (formal.isPlaying == true && doOnce == true)
        {

          //              Debug.Log("Activating music");
            //   StartCoroutine(startMusicWithDelay());
            doOnce = false;
        }

    }

    IEnumerator startVideoDelay()
    {
        yield return new WaitForSeconds(wait);
        playAllvideos();

    }
  
    public void casualVid(){

   changeVideo(casual);

}


public void shadesVid(){

   changeVideo(shades);

}


public void formalVid(){

   changeVideo(formal);
        Debug.Log("test");
    }

   

public void usingDropDown()
    {
        var dropDownValue = dropdown.value;

        changeVideo(themes[dropDownValue]);
    }

public void pauseAllvideos()
    {
      for (int i = 0; i < themes.Count; i++)
           {
                themes[i].Pause();
            allVideosPlaying = false;
           }
    }

    public void playVideosWithDelay()
    {
        StartCoroutine(startVideoDelay());
    }

public void FirstTimeStartAllVideos()
    {
        playVideosWithDelay();
        fmodController.GetComponent<FmodMusic>().startMusic();
        startButton.Select();
    }

public void playAllvideos()
    {
        for (int i = 0; i < themes.Count; i++)
        {
            themes[i].Play();
            allVideosPlaying = true; 
            Debug.Log(themes[i] + " is playing");
        }
    }


public void restartAllvideos()
    {
        for (int i = 0; i < themes.Count; i++)
        {
            themes[i].Stop();
        }

        // playAllvideos();
        playVideosWithDelay();
    }

    public void prepareVideos()
    {
       for (int i = 0; i < themes.Count; i++)
        {
            themes[i].Prepare();
      
        }

    }

    public void ShowFirstFrame()
    {
        for (int i = 0; i < themes.Count; i++)
        {

            themes[i].time = 0;
            themes[i].Play();
            themes[i].Pause();

        }
    }


    public void changeVideo(VideoPlayer pickedVideoPlayer){

       lastplayed.renderMode = UnityEngine.Video.VideoRenderMode.APIOnly;
       pickedVideoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.RenderTexture;
       lastplayed = pickedVideoPlayer;

  } 

}


