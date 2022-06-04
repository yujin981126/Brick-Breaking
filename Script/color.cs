using System.Dynamic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class color : MonoBehaviour
{
    public SpriteRenderer sp;
    public TextMeshProUGUI count;
    public int iCount = 10;
    // Start is called before the first frame update
    public GameManeger GM;
    void Start()
    {
        count.text = iCount.ToString();
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("충돌"); // 충돌 되면 출력
        GameObject.Find("snd01").GetComponent<AudioSource>().Play(); //충돌되면 소리 출력
        if(collision.gameObject.name == "ball") 
        {
            //초기 값
            sp.color= new Color(1,1,1,1);
            count.color = new Color(1, 1, 1, 1);
            GM.IncreseScore(); // 점수 ++
            iCount--;
            count.text = iCount.ToString();
            if(iCount <= 7)  //박스 안 숫자가 7이하 파랑색
            {
                sp.color= new Color(0,0.7f,1,1);
                count.color = new Color(0,0.7f,1,1);
            }
            if(iCount <= 5)  //박스 안 숫자가 5 이하 초록색
            {
                sp.color= new Color(0.7f,1,0.4f,1);
                count.color = new Color(0.7f,1,0.4f,1);
            }
            if(iCount <= 2)  //박스 안 숫자가 2 이하 빨간색
            {
                sp.color= new Color(1,0.6f,0.6f,1);
                count.color = new Color(1,0.6f,0.6f,1);
            }
            if(iCount <= 0) //박스 안 숫자가 0일떄
            {
                Debug.Log("삭제");
                Destroy(this.gameObject);
            }
        }
    }
}