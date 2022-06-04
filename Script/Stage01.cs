using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage01 : MonoBehaviour
{
    public void SceneChange(){
        SceneManager.LoadScene("stage01"); // 선택씬 전환
    }
}
