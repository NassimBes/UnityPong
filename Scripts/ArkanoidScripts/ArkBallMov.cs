using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArkBallMov : MonoBehaviour
{

    Rigidbody2D ball;

    [SerializeField] private Rigidbody2D Player;
    
    [SerializeField]
    float speed = 20.0f;
/*
    [SerializeField]
    AudioSource blkDestroy;*/

    
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        ball.velocity = Vector2.up * speed;
       
    }


    private void Update()
    {
        if (ball.position.y < Player.transform.position.y - 5)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            float x = hitFactor(transform.position, collision.transform.position,collision.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;

            ball.velocity = dir*speed;
            
        }

/*        if (collision.gameObject.tag == "Blocks")
        {
            blkDestroy.Play();
        }*/
    }

    private float hitFactor(Vector2 ballPos,Vector2 PlayerPos,float PlayerWidth)
    {
        return (ballPos.x - PlayerPos.x) / PlayerWidth;
    }


}
