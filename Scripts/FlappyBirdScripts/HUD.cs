using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    // Start is called before the first frame update
    public static HUD instance;


    public int PlayerScore = 0;
    public TMP_Text PlayerScoreText;


    private void OnEnable()
    {
        instance = this;
    }
}
