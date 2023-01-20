using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class playermoveputer : MonoBehaviour
{
public float moveSpeed;
public Rigidbody2D rb;
private Vector2 MoveDirection;
public Animator an;

    void start()
    {
        print("waited");
    }

    void Update()
    {
        ProssesInputs();

        an.SetFloat("horizontal", MoveDirection.x);
        an.SetFloat("vertical", 0f);
        an.SetFloat("speed", moveSpeed);
    }

    void FixedUpdate()
    {
        //physics
        Move();
    }

    void ProssesInputs()
    {
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");

            MoveDirection = new Vector2(moveX, moveY); 
    }

    void Move()
    {
            Vector2 direction = MoveDirection.normalized;
              rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }

    IEnumerator wait(){
        yield return new WaitForSeconds(1); 
    }
}
