using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnEnter : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Fade1"))
        {
            SceneManager.LoadScene(1);
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Fade2"))
        {
            SceneManager.LoadScene(2);
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Fade3"))
        {
            SceneManager.LoadScene(3);
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Fade4"))
        {
            SceneManager.LoadScene(4);
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Fade5"))
        {
            SceneManager.LoadScene(5);
        }
        else if (animator.GetCurrentAnimatorStateInfo(0).IsName("Fade6"))
        {
            SceneManager.LoadScene(6);
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
