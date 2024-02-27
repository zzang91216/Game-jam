using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow_d_step : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject ball1 = GameObject.Find("balls").transform.Find("spr_ball1").gameObject;
        GameObject ball2 = GameObject.Find("balls").transform.Find("spr_ball2").gameObject;
        Vector3 pos = transform.position;
        if ((Mathf.Abs(ball1.transform.position.x - pos.x) < 0.45) && (Mathf.Abs(ball1.transform.position.y - pos.y) < 0.5)) // 공1부딛힐때
        {
            ball1.gameObject.GetComponent<ball_step>().grav *= -1* Mathf.Sign(ball1.gameObject.GetComponent<ball_step>().grav); // 중력반전
        }
        if ((Mathf.Abs(ball2.transform.position.x - pos.x) < 0.45) && (Mathf.Abs(ball2.transform.position.y - pos.y) < 0.5)) // 공2부딛힐떄
        {
            ball2.gameObject.GetComponent<ball_step>().grav *= -1 * Mathf.Sign(ball2.gameObject.GetComponent<ball_step>().grav);//중력반전
        }
    }
}
