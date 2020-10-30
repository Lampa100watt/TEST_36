using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoTime : MonoBehaviour
{
    public GameObject l_isGOLocked;
    public int l_daysToGo;

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariables.l_days < l_daysToGo && GlobalVariables.l_mindLevel == false)
        {
            GlobalVariables.l_canOpenMindLevel = true;
            l_isGOLocked.SetActive(false);
        }

    }
}
