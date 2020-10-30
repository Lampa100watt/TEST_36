using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItsDemo : MonoBehaviour
{
    public Text l_infoDemo;

    private void OnTriggerStay(Collider other)
    {
        if (GlobalVariables.l_days >= 1) l_infoDemo.text = "Это демо-версия игры," +
                "разработанная для Джема от народа." +
                "Можешь побегать пока тут ;)";
    }

    private void OnTriggerExit(Collider other)
    {
        l_infoDemo.text = "";
    }
}
