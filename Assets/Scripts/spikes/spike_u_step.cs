using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike_u_step : MonoBehaviour
{
    void Awake()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()

    {
        GameObject ball1 = GameObject.Find("balls").transform.Find("spr_ball1").gameObject;
        GameObject ball2 = GameObject.Find("balls").transform.Find("spr_ball2").gameObject;
        Vector3 pos = transform.position;
        Vector3 pos1 = ball1.transform.position - pos;
        Vector3 pos2 = ball2.transform.position - pos;
        if ((Mathf.Abs(pos1.x) < 0.7) && (Mathf.Abs(pos1.y) < 0.75))
        {
            if ((pos1.y - 2*pos1.x < 1.15) && (pos1.y + 2 * pos1.x < 1.15)) {
                global.death += 1;
                ball_step a = ball1.gameObject.GetComponent<ball_step>();
                a.pos.x = a.startpos.x;
                a.pos.y = a.startpos.y;
                a.balltf.position = a.pos;
                a.speed = new Vector2(0, 0);
                a.djump = 0;
                a.onplatform = 0;
                a.grav = -0.015f;
    ball_step b = ball2.gameObject.GetComponent<ball_step>();
                b.pos.x = b.startpos.x;
                b.pos.y = b.startpos.y;
                b.balltf.position = b.pos;
                b.speed = new Vector2(0, 0);
                b.djump = 0;
                b.onplatform = 0;
                b.grav = -0.015f;
            }
        }
        if ((Mathf.Abs(pos2.x) < 0.7) && (Mathf.Abs(pos2.y) < 0.75))
        {
            if ((pos2.y - 2 * pos2.x < 1.15) && (pos2.y + 2 * pos2.x < 1.15))
            {
                global.death += 1;
                ball_step a = ball1.gameObject.GetComponent<ball_step>();
                a.pos.x = a.startpos.x;
                a.pos.y = a.startpos.y;
                a.balltf.position = a.pos;
                a.speed = new Vector2(0, 0);
                a.djump = 0;
                a.onplatform = 0;
                a.grav = -0.015f;
                ball_step b = ball2.gameObject.GetComponent<ball_step>();
                b.pos.x = b.startpos.x;
                b.pos.y = b.startpos.y;
                b.balltf.position = b.pos;
                b.speed = new Vector2(0, 0);
                b.djump = 0;
                b.onplatform = 0;
                b.grav = -0.015f;
            }
        }
    }
}
