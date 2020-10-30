using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelaxAudio : MonoBehaviour
{
    public AudioClip[] l_audioSources;
    public AudioSource l_randomSound;
    private int l_rndNumber;
    private bool l_onTrigger = false;
    private int l_counter = 2;

    // Start is called before the first frame update
    void Start()
    {
        l_audioSources = Resources.LoadAll<AudioClip>("Audio/RelaxRoom");
    }

    private void OnTriggerEnter(Collider other)
    {
        l_rndNumber = Random.Range(0, l_audioSources.Length);
        l_onTrigger = true;
        l_counter += 1;
    }

    void Update()
    {
        if (l_onTrigger == true && (l_counter % 2) > 0)
        {
            l_randomSound.clip = l_audioSources[l_rndNumber];
            l_randomSound.Play();
        }
        
        if ((l_counter % 2) == 0)
        {
            l_randomSound.Stop();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        l_onTrigger = false;
    }
}
