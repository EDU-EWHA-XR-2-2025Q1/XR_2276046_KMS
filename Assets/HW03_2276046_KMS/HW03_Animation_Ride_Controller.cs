using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW03_Animation_Ride_Controller : MonoBehaviour
{
    public Animator Animator;

    private void OnTriggerEnter(Collider other)
    {
        Animator.speed = 0.5f;
        if(other.name == "Vehicle")
        {
            transform.SetParent(other.transform);
            transform.position = other.transform.position + Vector3.up * 2f;
            Animator.SetInteger("ride", 1);
        }
        if(other.name == "Direction_Controller1")
        {
            Animator.SetInteger("to_Room", 2);
        }
        if(other.name == "Direction_Controller2"){
            Animator.SetInteger("to_Room", 1);
        }
        if(other.name == "Direction_Controller1_Stop"){
            Animator.SetInteger("stop", 1);
        }
        if(other.name == "Direction_Controller2_Stop"){
            Animator.SetInteger("stop", 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Vehicle")
        {
            transform.SetParent(null);
            Animator.SetInteger("ride", 0);
            Animator.speed = 0f;
        }
    }
}
