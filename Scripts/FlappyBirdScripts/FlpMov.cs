using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlpMov : MonoBehaviour
{



    [SerializeField]
    float flapforce = 5.5f;

    [SerializeField]
    float speed;



    Rigidbody2D flprb;


    // Start is called before the first frame update
    bool isDead=false;

    [SerializeField]
    GameObject restartMenu;

    [SerializeField]
    GameObject Bronze;

    [SerializeField]
    GameObject Silver;

    [SerializeField]
    GameObject Gold;

    [SerializeField]
    TMP_Text FinalScore;

    void Start()
    {
        Time.timeScale = 0;
        flprb = GetComponent<Rigidbody2D>();
        GetComponent<Animator>().SetBool("IsDead", isDead);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isDead==false) {
            GetComponent<Animator>().SetBool("OnClick", true);
            
            flprb.AddForce(new Vector2(0,1*flapforce));
            flprb.velocity = Vector2.right * speed;
        }
        else { GetComponent<Animator>().SetBool("OnClick", false); }

    }

    public void UnfreezeTime()
    {
        Time.timeScale = 1;
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        flprb.velocity = Vector2.zero;
        GetComponent<Animator>().SetBool("IsDead", isDead);
        restartMenu.SetActive(true);
        FinalScore.text = HUD.instance.PlayerScoreText.text;

        if (HUD.instance.PlayerScore > 100)
        {
            Gold.SetActive(true);
        }
        else if (HUD.instance.PlayerScore < 100 && HUD.instance.PlayerScore > 50)
        {
            Silver.SetActive(true);
        }
        else
        {
            Bronze.SetActive(true);
        }


        Time.timeScale = 0; 





    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            HUD.instance.PlayerScore++;
            HUD.instance.PlayerScoreText.text = HUD.instance.PlayerScore.ToString();
            Destroy(collision.gameObject);
        }
    }



    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
