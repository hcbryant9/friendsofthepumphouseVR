using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    // array of animators that we reference in the inspector
    public Animator[] animators;

    //public PlayerAudioOnTriggerEnter playerAudioOnTriggerEnter;
    // method to start animators
    public void startAnimators()
    {
        // start the animations for all the game objects.
        foreach (Animator animator in animators)
        {
            animator.SetTrigger("StartAnimation"); 
            // Replace "StartAnimation" with the actual trigger name in your Animator Controller.
        }
        //playerAudioOnTriggerEnter.setIsAnim(true);
    }
    
    // method to stop animators
    public void stopAnimators()
    {
        foreach (Animator animator in animators)
        {
            animator.ResetTrigger("StartAnimation"); // Replace "StartAnimation" with the actual trigger name in your Animator Controller.
            animator.SetTrigger("StopAnimation"); // Create a "StopAnimation" trigger in your Animator Controller.
        }
        //playerAudioOnTriggerEnter.setIsAnim(false);
    }
}
