using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Awake : MonoBehaviour
{
    public Image l_black;
    public GameObject l_Door;
    public GameObject l_Bett;
    public GameObject l_ExploreComplex;
    public GameObject l_man;
    public AudioSource l_FirstContact;
    public Text l_Task;
    public Text l_daysText;
    private AudioClip l_helloAudio;
    private float l_timerAwake;
    private bool l_awakeEndOfLine = true;
    private bool l_awakePassed = true;
    private bool l_awakePassedWriting = true;

    // Start is called before the first frame update
    void Start()
    {
        l_man.SetActive(true);
        l_Door.SetActive(false);
        l_Bett.SetActive(false);
        Color l_tempColor = l_black.color;
        l_tempColor.a = 255;
        l_black.color = l_tempColor;
        l_helloAudio = Resources.Load<AudioClip>("Audio/Story/Galva1/HelloF");
        l_FirstContact.clip = l_helloAudio;
    }

    // Update is called once per frame
    void Update()
    {
        //
        //Debug sector
        //if (Input.GetKeyDown(KeyCode.T))
        //{
        //    l_Door.SetActive(true);
        //    l_Bett.SetActive(true);
        //}
        //Debug sector
        //

        l_timerAwake += Time.deltaTime;

        if (l_timerAwake > 3)
        {
            l_FirstContact.mute = false;
            l_black.CrossFadeAlpha(-1, 1f, false);
        }

        if (l_timerAwake < 6)
        {
            l_FirstContact.Play();           
        }

        if (l_timerAwake > 37 && l_awakePassedWriting == true)  // && !l_FirstContact.isPlaying)
        {
            l_AwakePassedWrite();
        }

        if (l_awakePassed == true) l_AwakePassedClear();

        if (FoodEnter.l_FoodEnter == true && LaboEnter.l_LaboEnter == true && EngineEnter.l_EngineEnter == true && RelaxEnter.l_RelaxEnter == true && l_awakeEndOfLine == true)
        {
            l_TaskWriting();
            l_Bett.SetActive(true);
            l_ExploreComplex.SetActive(false);
        }
    }

    private void l_TaskWriting()
    {
        l_Task.text = "Вам надо отдохнуть!";
        l_awakeEndOfLine = false;
    }

    private void l_AwakePassedWrite()
    {
        l_awakePassedWriting = false;
        l_daysText.text = GlobalVariables.l_days + " DAYS PASSED";
        l_Door.SetActive(true);
    }

    private void l_AwakePassedClear()
    {
        if (l_timerAwake > 45)
        {
            l_daysText.text = "";
            l_awakePassed = false;
        }
    }
}
