using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    Animator animator;

    void Start() {
        animator = GetComponent<Animator>();
    }
    
    public void Walk(bool isWalking) {
        animator.SetBool("isWalking", isWalking);
    }

}
