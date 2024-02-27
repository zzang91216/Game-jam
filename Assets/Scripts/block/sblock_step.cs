using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sblock_step : MonoBehaviour
{
    void Awake()
    {
        
    }
    void FixedUpdate()
    {
        GameObject ball1 = GameObject.Find("balls").transform.Find("spr_ball1").gameObject;
        GameObject ball2 = GameObject.Find("balls").transform.Find("spr_ball2").gameObject;
        Vector3 pos = transform.position;
        if ((Mathf.Abs(ball1.transform.position.x - pos.x) < 0.45)&& (Mathf.Abs(ball1.transform.position.y - pos.y) < 0.5)) {

            ball1.gameObject.GetComponent<ball_step>().block_check(pos.x,pos.y,1);
        }
        if ((Mathf.Abs(ball2.transform.position.x - pos.x) < 0.45) && (Mathf.Abs(ball2.transform.position.y - pos.y) < 0.5))
        {

            ball2.gameObject.GetComponent<ball_step>().block_check(pos.x, pos.y,1);
        }
    }
}