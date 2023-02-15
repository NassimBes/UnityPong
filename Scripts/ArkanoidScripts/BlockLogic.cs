using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;





public class BlockLogic : MonoBehaviour
{



    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        ArkScoring.Instance.PlayerScore++;
        ArkScoring.Instance.PlayerScoreText.text = ArkScoring.Instance.PlayerScore.ToString();
        Destroy(gameObject);
    }
}
