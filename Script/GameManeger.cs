using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManeger : MonoBehaviour
{
    public int score = 0;
    public Text scoreTxt;
    public Text timerTxt;
    public float time = 100f;
    private float selectCountdown;
    void Start()
    {
        scoreTxt.text = score.ToString();
        selectCountdown =time;
    }
    void Update()
    {
        if(Mathf.Floor(selectCountdown) >= 0)
        {
            selectCountdown -= Time.deltaTime;
            //시간이 0초가 된다면...
            if(selectCountdown<=0.0f){
                Debug.Log("timeover");
                SceneManager.LoadScene("GameOver");
            }
            else 
            {
                timerTxt.text = Mathf.Floor(selectCountdown).ToString();
            }
        }
    }
    public void IncreseScore() //게임 점수 판정 함수
    {
        score ++;
        scoreTxt.text = score.ToString();
        if(score>=42){ // 획득할수 있는 최고 점수 42이 된다면 게임 클리어 
            SceneManager.LoadScene("GameClear");
        }
    }
}


