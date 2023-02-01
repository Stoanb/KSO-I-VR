using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class sceneManage : MonoBehaviour
{
    public Animator animator;

    public float secondsToWait; 
    private void Start()
    {
        animator.SetBool("entry", true); 
    }

    public void changeScene()
    {
       
        animator.SetBool("exit", true);
        StartCoroutine(waitForFade());
    }

    public IEnumerator waitForFade()
    {
        Debug.Log("is this working start");
        yield return new WaitForSeconds(secondsToWait);
        Debug.Log("is this working?");

        SceneManager.LoadScene("MainScene");
    }

}
