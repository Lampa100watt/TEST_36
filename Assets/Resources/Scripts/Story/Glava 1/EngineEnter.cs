using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineEnter : MonoBehaviour
{
    public GameObject l_trigger;
    public static bool l_EngineEnter = false;

    private void OnTriggerEnter(Collider other)
    {
        l_EngineEnter = true;
    }
}
