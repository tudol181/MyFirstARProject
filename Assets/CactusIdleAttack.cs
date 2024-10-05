using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator mAnimator;
    private bool isAttacking = false;
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if(mAnimator is not null)
        {
            if (Input.GetKeyDown(KeyCode.O) && isAttacking)
            {
                mAnimator.SetTrigger("TrIdle");
                isAttacking = false; 
            }

            if (Input.GetKeyDown(KeyCode.C) && !isAttacking)
            {
                mAnimator.SetTrigger("TrAttack");
                isAttacking = true; 
            }
        }   
    }
}
