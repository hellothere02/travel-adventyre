using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{

    public void Move(Rigidbody2D playerRB, Vector2 direction)
    {
        playerRB.velocity = direction;
    }
}
