using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    public Rigidbody2D ball;
    public float speed = 1f;


    Rigidbody2D AI;
    Vector2 move = Vector2.zero;

    void Start()
    {
        AI = GetComponent<Rigidbody2D>();
        
    }


    void FixedUpdate()
    {
        float dir = ball.position.y - transform.position.y;
        if (dir > 0)
        {
            AI.velocity = new Vector2(0, 1) * speed;
            
        }
        else if (dir < 0) {
            AI.velocity = new Vector2(0, -1) * speed;
        }
        else
        {
            AI.velocity = new Vector2(0, 0);
        }
    }
}
