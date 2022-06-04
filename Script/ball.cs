using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    private Rigidbody2D ballRd; 
    public float Speed;
    Vector3 lastVelocity;
    public Text text;
    void Start()
    {
        ballRd = GetComponent<Rigidbody2D>();
        ballRd.velocity = new Vector2(1.0f * Speed, -1.0f * Speed); 
        Debug.Log("Start"); // 게임 스타트
    }
    void Update()
    {
        lastVelocity = ballRd.velocity;
        Debug.Log(ballRd.velocity);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        Speed = lastVelocity.magnitude;   
        if(Speed >=2.7f) // 공의 가속도 2.7f 이상 올라가지 않게 제한 버그때메 걸어둠
            Speed=2.7f;  
        var dir = Vector2.Reflect(lastVelocity.normalized, coll.contacts[0].normal); // 반사각
        ballRd.velocity = dir * Mathf.Max(Speed, 0f); 
        Debug.Log(coll.gameObject.name); //부딪히는 오브젝트를 출력
    }
}