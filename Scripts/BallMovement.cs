using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D ball;

    public float speed = 5.5f;


    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        float Yaxisrnd = Random.Range(-1f, 1f)==0?1:-1;
        float Xaxisrnd = Random.Range(-1f, 1f) == 0 ? 1 : -1;
        ball.velocity = new Vector2(Xaxisrnd, Yaxisrnd) * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);

            Vector2 dir = new Vector2(1, y).normalized;

            ball.velocity = dir * speed;
            speed += 2.0f;
        }

        if (collision.gameObject.name == "AI-Player")
        {
            float y = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1, y).normalized;
            ball.velocity = dir * speed;
            speed += 2.0f;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "LeftCollider")
        {
            StartCoroutine(AwaitCouroutine());
            ScoringSystem.instance.AIScore++;
            ScoringSystem.instance.AIScoreText.text = ScoringSystem.instance.AIScore.ToString();

            ball.transform.position = new Vector2(1, 0);
            ball.velocity = new Vector2(1, 0) * speed;

        }
        else if (collision.tag == "RightCollider")
        {

            StartCoroutine(AwaitCouroutine());
            ScoringSystem.instance.PlayerScore++;
            ScoringSystem.instance.PlayerScoreText.text = ScoringSystem.instance.PlayerScore.ToString();
            ball.transform.position = new Vector2(-1, 0);
            ball.velocity = new Vector2(-1,0) * speed;

        }
    }

    private float hitFactor(Vector2 ballPos, Vector2 RacketPos, float RacketHeight)
    {
        // (2-1) / 10
        return (ballPos.y - RacketPos.y) / RacketHeight;
    }

    IEnumerator AwaitCouroutine()
    {
        speed = 5.5f;
        yield return new WaitForSeconds(5);
    }
}
