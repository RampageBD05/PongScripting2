using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 8f;
    [HideInInspector]
   public Rigidbody2D _RigidBody;


    private void Awake()
    {
        _RigidBody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _RigidBody.velocity = Vector2.zero;
        _RigidBody.position = new Vector2(_RigidBody.position.x , 0f);
    }
}
