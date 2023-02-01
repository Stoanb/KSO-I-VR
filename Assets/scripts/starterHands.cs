using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starterHands : MonoBehaviour
{
    public videoStorer VideoStorer;
    public GameObject menu;
    public GameObject holdHandsUpText;
    public GameObject StartThegameScript; 

    public GameObject R_controller;
    public GameObject L_controller;

    public int startHintDelay; 
    public float startPosY;

    public float startTheGamePosY;

    public bool gamestarted; 

    void Start()
    {
        holdHandsUpText.SetActive(false);
        StartCoroutine(startText());
    }

    // Update is called once per frame
    void Update()
    {
        gamestarted = StartThegameScript.GetComponent<ControllerMotionStart>().startTheGame; 

        if (gamestarted == true)
        {

            

        }
    }

    public IEnumerator startText()
    {
        yield return new WaitForSeconds(startHintDelay); 
        if(gamestarted == false)
        {
            holdHandsUpText.SetActive(true);
        }
    }

    public void StartVideos()
    {
        Debug.Log("start the game pls");
        VideoStorer.FirstTimeStartAllVideos();
        menu.SetActive(true);
        holdHandsUpText.SetActive(false);
        Object.Destroy(this);
    }
}
