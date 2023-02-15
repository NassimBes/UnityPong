using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkPlayerMov : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField]
    float speed = 1.0f;


    Vector2 dir = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dir.x = Input.GetAxis("Horizontal");
        rb.velocity = dir * speed;
    }
}
