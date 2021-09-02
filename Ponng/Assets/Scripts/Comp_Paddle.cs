using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comp_Paddle : Paddle
{
    public Rigidbody2D Ball;
    private void FixedUpdate()
    {
        // Check if the ball is moving towards the paddle (positive x velocity)
        // or away from the paddle (negative x)
        if (this.Ball.velocity.x > 0.0f)
        {
            // Move the paddle in the direction of the ball
            if (this.Ball.position.y > this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
            else if (this.Ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            // Move towards the center of the field and idle there until
                // The ball starts coming towards the paddle again
            if (this.transform.position.y > 0)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }else if(this.transform.position.y < 0)
            {
                _rigidbody.AddForce(Vector2.up* this.speed);

            }
        }
    }
}
