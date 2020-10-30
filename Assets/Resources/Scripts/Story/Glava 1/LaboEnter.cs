using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaboEnter : MonoBehaviour
{
    public GameObject l_trigger;
    public static bool l_LaboEnter = false;

    private void OnTriggerEnter(Collider other)
    {
        l_LaboEnter = true;
    }
}
