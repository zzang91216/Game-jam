using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class death_step : MonoBehaviour
{
    // Start is called before the first frame update
    Text death;
    void Awake()
    {
        death = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        death.text = "death :"+ global.death.ToString();
    }
}
