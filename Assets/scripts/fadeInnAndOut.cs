using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class fadeInnAndOut : MonoBehaviour
{

    public Animator animator;

    void Start()
    {
        animator.SetBool("entry", true);
    }
    
    public void FadeToBlack()
    {
       animator.SetBool("exit", true);
       StartCoroutine(ExitToMenu());
    }
    

    IEnumerator ExitToMenu()
    {
     
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("Menu");
    }

}
