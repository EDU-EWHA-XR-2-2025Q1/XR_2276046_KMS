using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_Animator1_Door_Controller_back : MonoBehaviour
{
    public Animator Animator;

    private void OnTriggerEnter(Collider other)
    {
        Animator.SetInteger("back", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        if(Animator.GetInteger("back")==1){
            Animator.SetInteger("back", 0);
        }
    }
}
