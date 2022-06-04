using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage05 : MonoBehaviour
{
    public void SceneChange(){
        SceneManager.LoadScene("stage05"); // 선택씬 전환
    }
}
