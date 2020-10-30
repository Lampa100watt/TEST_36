using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sleeping : MonoBehaviour
{
    public Text l_PressE;
    public Text l_daysText;
    public Text l_Task;
    public Image l_SleepingBlack;
    private float l_timerSleep;
    private bool l_onTrigger = false;
    private bool l_Press = false;
    private bool l_toDay = false;

    private void OnTriggerStay(Collider other)
    {
        l_PressE.text = "Press E to sleeping";

        l_onTrigger = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && l_onTrigger == true)
        {
            l_Press = true;
        }

        l_Sleeping();

        l_timerSleep += Time.deltaTime;

        if (l_timerSleep > 2 && l_timerSleep <= 3 && l_toDay == true)
        {
            l_SleepingBlack.CrossFadeAlpha(1, 1f, false);
            l_daysText.text = GlobalVariables.l_days + " DAYS PASSED";
        }

        if (l_timerSleep > 10 && l_timerSleep <= 11)
        {
            l_daysText.text = "";
        }
    }

    private void l_Sleeping()
    {
        if (l_Press == true)
        {
            l_Press = false;
            l_toDay = true;
            l_Task.text = "";
            GlobalVariables.l_days += 1;
            l_timerSleep = 0;
            l_SleepingBlack.CrossFadeAlpha(255, 0.5f, false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        l_PressE.text = "";
        l_onTrigger = false;
    }
}
