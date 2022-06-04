using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage03 : MonoBehaviour
{
    public void SceneChange(){
        SceneManager.LoadScene("stage03"); // 선택씬 전환
    }
}
