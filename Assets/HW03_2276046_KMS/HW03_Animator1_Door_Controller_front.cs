using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_Animator1_Door_Controller_front : MonoBehaviour
{
    public Animator Animator;

    private void OnTriggerEnter(Collider other)
    {
        Animator.SetInteger("front", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        if(Animator.GetInteger("front")==1){
            Animator.SetInteger("front", 0);
        }
    }
}
