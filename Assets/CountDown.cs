using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
    public float timeLeft = 5f;
    TextMeshProUGUI showTime;
    Canvas ExitCanvas;
    // Start is called before the first frame update
    void Start()
    {
        showTime = GameObject.Find("/Canvas/txtShowTime").GetComponent<TextMeshProUGUI>();
        ExitCanvas = GameObject.Find("/Canvas/Canvas").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timeLeft > 0)
        {
           timeLeft -= Time.deltaTime;
           showTime.text = timeLeft.ToString("###0");
        }
        else
        {
            ExitCanvas.enabled = true;
        }
    }
}
