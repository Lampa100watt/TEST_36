using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodEnter : MonoBehaviour
{
    public GameObject l_trigger;
    public static bool l_FoodEnter = false;

    private void OnTriggerEnter(Collider other)
    {
        l_FoodEnter = true;
    }
}
