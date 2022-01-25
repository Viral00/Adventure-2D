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
        float vertical = Input.GetAxisRaw("Jump");
        animator.SetFloat("Speed", Mathf.Abs(speed));


        if (vertical > 0)
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }
        Vector2 scale = transform.localScale;

        if (speed < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
        }
        else if (speed > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;
    }
}

