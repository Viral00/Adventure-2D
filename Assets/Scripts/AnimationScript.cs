using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator animator;
    bool jump;

    private void Start()
    {
        jump = false;
    }
    private void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("Speed", speed);

        if(jump = Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Jump", jump); 
        }
        else
        {
            jump = false;
        }
    }
}
