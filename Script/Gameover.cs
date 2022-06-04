using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    SpriteRenderer go;
    void Start()
    {
        go = this.GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D collision) // 공이 바닥에 내려가면 게임오버 판정 
    {
        Debug.Log("바닥충돌"); //충돌 판정 시 출력
        if(collision.gameObject.name == "ball")
        {
            Time.timeScale=0.0f; 
            SceneManager.LoadScene("GameOver"); //게임 오버 신 이동 
        }
    }
}




