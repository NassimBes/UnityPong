using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;





public class BlockLogic : MonoBehaviour
{
    [SerializeField]
    int HitPoint = 5;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        HitPoint--;
        if (HitPoint == 0)
        {
            ArkScoring.Instance.PlayerScore++;
            ArkScoring.Instance.PlayerScoreText.text = ArkScoring.Instance.PlayerScore.ToString();
            Destroy(gameObject);
        }
        
    }
}
