using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alarma : MonoBehaviour
{
    public AudioSource l_audioSource;
    private bool l_onPosition = false;
    private bool l_alarmaON = false;
    public Text l_text;

    private void Start()
    {
        l_audioSource.Stop();
    }
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        l_onPosition = true;
        l_text.text = "Press E";
    }

    private void Update()
    {
        if (l_onPosition == true && Input.GetKeyDown(KeyCode.E))
        {
            l_alarmaStatus();
        }
    }

    private void l_alarmaStatus()
    {
        if (l_alarmaON == false)
        {
            l_alarmaON = true;
            l_audioSource.Play();
        }
        else
        {
            l_alarmaON = false;
            l_audioSource.Stop();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        l_onPosition = false;
        l_text.text = "";
    }
}
