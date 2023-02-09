using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D player;
    public float speed = 5.5f;


    Vector2 dir = new Vector2(0,0);
    void Start()
    {
        player= GetComponent<Rigidbody2D>();

    }

    // Physic
    private void FixedUpdate()
    {
        dir.y = Input.GetAxis("Vertical");
        player.velocity = dir*speed;
    }
}
