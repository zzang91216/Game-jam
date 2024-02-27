using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time_step : MonoBehaviour
{
    // Start is called before the first frame update
    Text time;
    void Awake()
    {
        time = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time.text = "time :" + Mathf.CeilToInt(global.time).ToString() + "  seconds";
    }
}