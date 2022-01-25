using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : MonoSingleton<PlayerService>
{
    public PlayerView playerPrefab;

    private void Start()
    {
        PlayerModel playerModel = new PlayerModel(5f, 25f);
        PlayerController playerController = new PlayerController(playerModel, playerPrefab);
    }
}
