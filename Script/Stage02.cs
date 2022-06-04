using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage02 : MonoBehaviour
{
    public void SceneChange(){
        SceneManager.LoadScene("stage02"); // 선택씬 전환
    }
}
