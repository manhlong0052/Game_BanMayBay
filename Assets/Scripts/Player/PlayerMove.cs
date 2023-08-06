using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    protected Rigidbody2D rb2d;
    public Vector2 velocity = new Vector2(1f, 0f);
    public float pressHorizontal = 0f;
    public float speed = 5f;
    protected float playerPosX;

    private void Awake()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        this.playerPosX = transform.position.x;
        this.pressHorizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        if (playerPosX < 9 || playerPosX > -9) this.speed = 5f;
        if (playerPosX > 9 || playerPosX < -9) this.speed = 1f;
        this.movement();
    }

    private void movement()
    {
        this.velocity.x = this.pressHorizontal * this.speed;
        this.rb2d.MovePosition(this.rb2d.position + this.velocity * Time.deltaTime);
    }
}
