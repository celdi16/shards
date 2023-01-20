using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joy : MonoBehaviour
{
public float moveSpeed;
public Rigidbody2D rb;
private Vector2 MoveDirection;
public Animator an;
public Joystick joystick;
public float[] position;

    void Update()
    {

        an.SetFloat("horizontal", MoveDirection.x);
        an.SetFloat("vertical", MoveDirection.y);
        an.SetFloat("speed", moveSpeed);
    }

    void FixedUpdate()
    {
        Move();
        ProssesInputs();
    }

    void ProssesInputs()
    {
            float moveX = joystick.Horizontal;
            float moveY = joystick.Vertical;

            MoveDirection = new Vector2(moveX, moveY); 
    }

    void Move()
    {
            rb.velocity = new Vector2(MoveDirection.x * moveSpeed, MoveDirection.y * moveSpeed);
    }
    
}