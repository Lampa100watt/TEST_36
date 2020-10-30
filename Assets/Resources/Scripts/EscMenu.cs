using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EscMenu : MonoBehaviour
{
    private bool l_isPaused = false;
    private float l_TimeScaleRef = 1;
    private float l_VolumeRef = 1;
    public GameObject l_EscCanvas;
    //public Button l_reStart;
    public Button l_Exit;
    public Button l_cont;

    private void Start()
    {
        l_EscCanvas.SetActive(false);
        //l_reStart.onClick.AddListener(reStartEnabled);
        l_Exit.onClick.AddListener(ExiteEnabled);
        l_cont.onClick.AddListener(MenuOff);
    }

    //void reStartEnabled()
    //{
    //    SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    //}

    void ExiteEnabled()
    {
        Application.Quit();
    }

    private void MenuOn ()
    {
        Time.timeScale = 0f;

        AudioListener.volume = 0f;

        l_EscCanvas.SetActive(true);
    }

    public void MenuOff ()
    {
        Time.timeScale = l_TimeScaleRef;
        AudioListener.volume = l_VolumeRef;
        l_EscCanvas.SetActive(false);
        l_isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            l_isPaused = true;
            if (l_isPaused == true) MenuOn();
        }
    }
}
