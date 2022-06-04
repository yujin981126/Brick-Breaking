using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stop : MonoBehaviour
{
    public void SceneChange(){
        SceneManager.LoadScene("GameSelect"); // 선택씬 전환
    }
}
