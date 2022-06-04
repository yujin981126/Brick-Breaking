using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Dynamic;
using TMPro;

public class PlayBar : MonoBehaviour
{
    public float speed;
    public Vector2 speed_vec;
    private Rigidbody2D pb;
    float time;
    public float _fadeTime = 1f;

    void Start()
    {
        speed = 0.07f;
        pb = GetComponent<Rigidbody2D>();
        SetResolution();
        
    }
    void Update()
    {
        speed_vec = Vector2.zero;
        if (Input.touchCount > 0)
        {
            int deviceWidth = Screen.width; // 기기 너비 저장
            Vector2 pos = Input.GetTouch(0).position;    // 터치한 위치
            int dWidth = deviceWidth/3;
            if (pos.x < dWidth)
                speed_vec.x -= speed;
            else
                speed_vec.x += speed;
            transform.Translate(speed_vec);
        }
    }
    public void OnCollisionEnter2D(Collision2D other) {
        Debug.Log(other.gameObject.name);  
    }
    private void SetResolution()
    {
        int setWidth = 1080; // 사용자 설정 너비
        int setHeight = 2340; // 사용자 설정 높이
        int deviceWidth = Screen.width; // 기기 너비 저장
        int deviceHeight = Screen.height; // 기기 높이 저장

        Screen.SetResolution(setWidth, (int)(((float)deviceHeight / deviceWidth) * setWidth), true); // SetResolution 함수 제대로 사용하기

        if ((float)setWidth / setHeight < (float)deviceWidth / deviceHeight) // 기기의 해상도 비가 더 큰 경우
        {
            float newWidth = ((float)setWidth / setHeight) / ((float)deviceWidth / deviceHeight); // 새로운 너비
            Camera.main.rect = new Rect((1f - newWidth) / 2f, 0f, newWidth, 1f); // 새로운 Rect 적용
        }
        else // 게임의 해상도 비가 더 큰 경우
        {
            float newHeight = ((float)deviceWidth / deviceHeight) / ((float)setWidth / setHeight); // 새로운 높이
            Camera.main.rect = new Rect(0f, (1f - newHeight) / 2f, 1f, newHeight); // 새로운 Rect 적용
        }
    }
}