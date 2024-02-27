using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door_step : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
    }

    void FixedUpdate()
    {
        GameObject ball1 = GameObject.Find("balls").transform.Find("spr_ball1").gameObject;
        Vector3 pos = transform.position;
        if ((Mathf.Abs(ball1.transform.position.x - pos.x) < 0.87) && (Mathf.Abs(ball1.transform.position.y - pos.y) < 2.4))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//공1이랑 부딛히면 넘어감
        }
    }
}
