using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DONTTOUCH : MonoBehaviour
{
    public GameObject l_video;
    public RawImage l_videoImage;
    public GameObject l_objDestroy;
    public Text l_text;
    public Text l_pressE;
    private int l_count = 0;
    private float l_timerDNT;
    private bool l_scrimmer = false;

    // Start is called before the first frame update
    void Start()
    {
        l_video.SetActive(false);
        l_videoImage.enabled = false;
    }

    private void OnTriggerStay (Collider other)
    {
        l_scrimmer = true;
        l_pressE.text = "Press E";
    }

    private void OnTriggerExit(Collider other)
    {
        l_pressE.text = "";
        l_text.text = "";
        l_scrimmer = false;
        Destroy(l_objDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && l_scrimmer == true)
        {
            l_count += 1;
            l_scrimmerActivate();
        }
    }
    
    private void l_scrimmerActivate()
    {
        if (l_count == 1) l_text.text = "ТЫ УВЕРЕН";

        if (l_count == 2) l_text.text = "ТЫ ХОРОШО ПОДУМАЛ?";

        if (l_count == 3) l_text.text = "Я ПРЕДУПРЕДИЛ!";

        if (l_count == 4)
        {
            l_timerDNT += Time.deltaTime;
            l_video.SetActive(true);
            l_videoImage.enabled = true;
            l_text.text = "ХОРОШЕГО ХЕЛЛОУИНА!";
            l_scrimmer = false;
        }
    }
}
