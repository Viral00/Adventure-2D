using UnityEngine;

public class PlayerController
{
    public PlayerController(PlayerModel playerModel, PlayerView playerPrefab)
    {
        Player_Model = playerModel;
        Player_View = playerPrefab;
        Player_View.plyrcontroller = this;
    }

    public PlayerModel Player_Model { get; }
    public PlayerView Player_View { get; }


    public void PlayerMovement(Transform transform, float horizontal, float vertical, Rigidbody2D rb2d, bool isjump)
    {
        Vector2 position = transform.position;
        position.x += horizontal * Player_Model.Speed * Time.deltaTime;
        transform.position = position;

        if (vertical > 0 && isjump == true)
        {
            rb2d.AddForce(new Vector2(0f, Player_Model.Jump), ForceMode2D.Force);
            isjump = false;
        }
    }

    public void PlayerJump(float vertical, Animator animator)
    {
        if (vertical > 0)
        {
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }
    }
}
