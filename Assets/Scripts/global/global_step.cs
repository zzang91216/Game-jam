using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class global_step : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            if (Input.anyKeyDown)
            {
                global.time = 0;
                global.death = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        else {
            if (SceneManager.GetActiveScene().name != "scn_fin" && SceneManager.GetActiveScene().name != "scn_1") {
                global.time += 0.02f;
            }
            
        }
        if (Input.GetMouseButton(0))
        {
            if (global.lclick == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                global.lclick = 1;
            }
        }
        else { global.lclick = 0; }
        if (Input.GetMouseButton(1))
        {
            if (global.rclick == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                global.rclick = 1;
            }
        }
        else { global.rclick = 0; }
        if ((null != GameObject.Find("balls").transform.Find("spr_ball1").gameObject)&& (null != GameObject.Find("balls").transform.Find("spr_ball2").gameObject))//둘이 같은 공간에 있을때
        {
            GameObject ball1 = GameObject.Find("balls").transform.Find("spr_ball1").gameObject;
            GameObject ball2 = GameObject.Find("balls").transform.Find("spr_ball2").gameObject;
            if ((Mathf.Abs(ball1.transform.position.x - ball2.transform.position.x) < 0.4) && (Mathf.Abs(ball1.transform.position.y - ball2.transform.position.y) < 0.5))
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
                b.grav = -0.015f;//둘이 부딛히면 사망
            }
        }
    }
   
}
