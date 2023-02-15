using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ArkScoring : MonoBehaviour
{
    public static ArkScoring Instance;


    public int PlayerScore=0;
    public TMP_Text PlayerScoreText;


    private void OnEnable()
    {
        Instance= this;
    }


}
