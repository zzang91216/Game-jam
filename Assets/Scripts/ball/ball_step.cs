using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_step : MonoBehaviour
{
    int pressed = 0;
    public int djump = 0;
    public int onplatform = 0;

    public Vector3 pos;
    public Vector3 startpos;
    public Transform balltf;
    public Vector2 speed;
    public float grav = -0.015f;
    void Awake()
    {
        balltf = transform;
        pos = balltf.position;
        startpos = balltf.position;

        speed = new Vector2(0, 0);
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))//스페이스 눌렀을때
        {
            if (pressed == 1)//누른 직후면
            {
                if (onplatform == 1)
                {
                    speed.y = -0.36f * Mathf.Sign(grav);
                }
                else if (djump == 1)
                {
                    speed.y = -0.32f * Mathf.Sign(grav);
                    djump = 0;
                }
                //점프
                pressed = 0;// 누른 직후가 아니도록 변수 바꿈
            }
        }
        else {
            pressed = 1;//뗀상태면 변수 바꿈
            if (Mathf.Sign(grav) + Mathf.Sign(speed.y) == 0) {
                speed.y -= 2*speed.y* speed.y* Mathf.Sign(speed.y); // 항력고려
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed.x += 0.008f;//가속
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed.x -= 0.008f;//가속
        }
        onplatform = 0;
        speed.y += grav;
        speed.x *= 0.95f;
        speed.y *= 0.95f;
        pos.x += speed.x;
        pos.y += speed.y;
        balltf.position = pos;
        //변수설정
    }
    public void block_check(float x, float y, int k)//블록 부딛힐 때 함수 k는 작은블록인지 큰블록인지 확인
    {
        if (Mathf.Abs(pos.x - x - speed.x) < 0.7 -0.25f * k)//블록크기고려
        {
            if (y < pos.y + 0.75f - 0.25f*k && y >= pos.y + 0.75f - 0.25f * k - speed.y)
            {
                pos.y -= speed.y;
                speed.y *= -0.5f;
                if (grav > 0)
                {
                    djump = 1;
                    onplatform = 1;
                }
            }
            if (y > pos.y - 0.75f + 0.25f * k && y <= pos.y - 0.75f + 0.25f * k - speed.y)
            {
                pos.y -= speed.y;
                speed.y *= -0.5f;
                if (grav < 0) {
                    djump = 1;
                    onplatform = 1;
                }
            }
        }//부딛힌다
        
        if (Mathf.Abs(pos.y - y - speed.y) < 0.75 - 0.25f * k) {
            if (x < pos.x + 0.7f - 0.25f * k && x >= pos.x + 0.7f - 0.25f * k - speed.x)
            {
                pos.x -= speed.x;
                speed.x *= -0.5f;
            }
            if (x > pos.x - 0.7f + 0.25f * k && x <= pos.x - 0.7f + 0.25f * k - speed.x)
            {
                pos.x -= speed.x;
                speed.x *= -0.5f;
            }
        }
        if ((Mathf.Abs(pos.y - y - speed.y) > 0.75 - 0.25f * k)&& (Mathf.Abs(pos.x - x - speed.x) > 0.7 - 0.25f * k) && Mathf.Abs(speed.x) > 0.1 && Mathf.Abs(speed.y) > 0.1)
        {
            pos.x -= speed.x;
            speed.x *= -0.5f;
            pos.y -= speed.y;
            speed.y *= -0.5f;
        }
            balltf.position = pos;
    }//부딛힌다
}
