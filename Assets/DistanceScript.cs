using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceScript : MonoBehaviour
{
    private List<Animator> mAnimators= new List<Animator>(); 
    private bool isAttacking = false;
    private float distance = 0.25f;

    void Start()
    {
        mAnimators.AddRange(GetComponentsInChildren<Animator>());
    } 

    void Update()
    {
        if (mAnimators is not null)
        {
            for (int i = 0; i < mAnimators.Count - 1; i++)
            {
                Animator thisObject = mAnimators[i];
                for (int j = i + 1; j < mAnimators.Count; j++)
                {
                    Animator otherObject = mAnimators[j];
                    if (Vector3.Distance(thisObject.transform.position, otherObject.transform.position) <= distance &&
                        !isAttacking)
                    {
                        thisObject.SetTrigger("TrAttack");
                        otherObject.SetTrigger("TrAttack");
                        isAttacking = true;
                    }

                    if (Vector3.Distance(thisObject.transform.position, otherObject.transform.position) > distance &&
                        isAttacking)
                    {
                        thisObject.SetTrigger("TrIdle");
                        otherObject.SetTrigger("TrIdle");
                        isAttacking = false;
                    }
                }
            }
        }
    }
}