using UnityEngine;

public class PlayerModel
{
    public PlayerModel(float speed, float jump)
    {
        Speed = speed;
        Jump = jump;
    }

    public float Speed { get; }
    public float Jump { get; }
}
