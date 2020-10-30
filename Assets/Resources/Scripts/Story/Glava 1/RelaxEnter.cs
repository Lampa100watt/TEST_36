using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelaxEnter : MonoBehaviour
{
    public GameObject l_trigger;
    public static bool l_RelaxEnter = false;

    private void OnTriggerEnter(Collider other)
    {
        l_RelaxEnter = true;
    }
}
