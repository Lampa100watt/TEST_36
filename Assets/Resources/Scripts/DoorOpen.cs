using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    public Animator l_anim;
    public Text l_PressE;
    private bool l_doorOpen = false;

    public AudioSource l_audioSource;

    private void Start()
    {
        l_audioSource.Stop();
    }
    private void OnTriggerStay(Collider other)
    {
        l_PressE.text = "Press E";

        l_doorOpen = true;
    }

    private void OnTriggerExit(Collider other)
    {
        l_PressE.text = "";
        l_anim.SetBool("OpenDoor", false);
        l_doorOpen = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && l_doorOpen == true)
        {
            l_audioSource.mute = false;
            l_anim.SetBool("OpenDoor", true);
            l_audioSource.Play();
            if (!l_audioSource.isPlaying)
            {
                l_audioSource.mute = true;
            }
            l_doorOpen = false;
        }
    }
}
