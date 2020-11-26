using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if (Input.GetButtonDown("PickUp"))
        {
            animator.SetBool("pickup", true);
        }
        else
        {
            animator.SetBool("pickup", false);
        }
    }
}
