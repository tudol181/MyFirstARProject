using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAnimator : MonoBehaviour
{
    private Animator skeletonAnimator;
    private bool isIdle = true;
    
    void Start()
    {
        skeletonAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (skeletonAnimator is not null)
        {
            if (Input.GetKeyDown(KeyCode.P) && !isIdle)
            {
                skeletonAnimator.SetTrigger("TrIdle");
                isIdle = true;
            }

            if (Input.GetKeyDown(KeyCode.V) && isIdle)
            {
                skeletonAnimator.SetTrigger("TrJump");
                isIdle = false;
            }
        }
    }
}
