using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public Animator animator;
    public PlayerController plyrcontroller;
    private Rigidbody2D rb2D;
    private bool isJump;

    public PlayerView(PlayerController playerController)
    {
        Player_Controller = playerController;
    }

    public PlayerController Player_Controller { get; }

    private void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        isJump = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            isJump = true;
        }
    }

    private void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Jump");

        animator.SetFloat("Speed", Mathf.Abs(horizontal));

        Vector2 scale = transform.localScale;

        if (horizontal < 0)
        {
            scale.x = -1f * Mathf.Abs(scale.x);
        }
        else if (horizontal > 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;

        if (isJump == true)
        {
            plyrcontroller.PlayerJump(vertical, animator);
        }

        plyrcontroller.PlayerMovement(transform, horizontal, vertical, rb2D, isJump);
    }
}
