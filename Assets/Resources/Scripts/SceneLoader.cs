using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Button l_StartButton, l_ExitButton;

    // Start is called before the first frame update
    void Start()
    {
        l_StartButton.onClick.AddListener(StartOnClick);
        l_ExitButton.onClick.AddListener(ExitOnClick);
    }

    void StartOnClick()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    void ExitOnClick()
    {
        Application.Quit();
    }
}
