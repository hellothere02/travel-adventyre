using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRB;
    [SerializeField] private Vector2 direction;
    private PlayerMovement playerMovement;

    [Inject]
    private void Construct(PlayerMovement _playerMovement)
    {
        playerMovement = _playerMovement;
    }

    private void FixedUpdate()
    {
        playerMovement.Move(playerRB, direction);
    }
}
