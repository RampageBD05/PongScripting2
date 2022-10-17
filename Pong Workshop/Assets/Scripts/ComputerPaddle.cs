
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;
    private void FixedUpdate()
    {
        if(ball.velocity.x > 0f) // check if ball is going towards CPU
        {
            if(ball.position.y > _RigidBody.position.y)  {// If ball's y position is bigger than paddle 
                _RigidBody.AddForce(Vector2.up * speed); // move up
            }
            else if(ball.position.y < _RigidBody.position.y) // If ball's y position is less than paddle
            {
                _RigidBody.AddForce(Vector2.down * speed); // move down
            }
        }

        else
        {
            if(_RigidBody.position.y > 0f)
            {
                _RigidBody.AddForce(Vector2.down * speed);
            }

            else if (_RigidBody.position.y < 0f)
            {
                _RigidBody.AddForce(Vector2.up * speed);
            }
        }
    }
}
