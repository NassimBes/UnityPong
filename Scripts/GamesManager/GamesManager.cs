using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;
using static UnityEditor.Progress;

public class GamesManager : MonoBehaviour
{
    public static GamesManager instance;



    TMP_Dropdown dropdown;


    private void OnEnable()
    {
        instance = this;
    }

    private void Start()
    {

        dropdown= GetComponent<TMP_Dropdown>();

        dropdown.options.Clear();

        int sceneCount = SceneManager.sceneCountInBuildSettings;
        string[] scenes = new string[sceneCount];
        for (int i = 0; i < sceneCount; i++)
        {
            scenes[i] = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(i));
            if (scenes[i] != "GamesManager")
            {
                dropdown.options.Add(new TMP_Dropdown.OptionData() { text= scenes[i] });
            }
        }
    }


    public void GMLoadScene()
    {
        SceneManager.LoadSceneAsync(dropdown.options[dropdown.value].text,LoadSceneMode.Single);
    }
}
