using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200f;
    private Rigidbody2D _ballBody;

    private void Awake()
    {
        _ballBody = GetComponent<Rigidbody2D>();
        AddStartForce();

    }


    public void ResetBall()
    {
        _ballBody.velocity = Vector2.zero;
        _ballBody.position = Vector2.zero;
    }

    public void AddStartForce()
    {
        float x = Random.value < 0.5f ? -1f : 1f;

        float y = Random.value < 0.5f ? Random.Range(1f, -0.5f) : Random.Range(0.5f, 1f);

        Vector2 direction = new Vector2(x, y);
        _ballBody.AddForce(direction * speed);
        
    }
}
