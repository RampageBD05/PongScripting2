using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{

    public float BounceStrength = 1f;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.GetComponent<Rigidbody2D>().AddForce(-normal * BounceStrength, ForceMode2D.Impulse);
        }
    }
}
