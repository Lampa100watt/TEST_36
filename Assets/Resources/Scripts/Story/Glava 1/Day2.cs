using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2 : MonoBehaviour
{
    public GameObject l_man;
    private float l_timerDay2;
    private AudioClip l_morningAudio;
    public AudioSource l_day2Radio;
    private bool l_dayOne = false;

    // Start is called before the first frame update
    void Start()
    {
        l_morningAudio = Resources.Load<AudioClip>("Audio/Story/Galva1/D2_1");
        l_day2Radio.clip = l_morningAudio;
    }
     
    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.l_days == 1 && l_dayOne == false)
        {
            l_dayOne = true;
            l_man.SetActive(true);
            l_timerDay2 = 0;
        }

        l_timerDay2 += Time.deltaTime;

        if (l_timerDay2 > 2) l_day2Radio.Play();


    }
}
