using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changereset : MonoBehaviour
{
public void SceneChange(){
        Time.timeScale=1.0f; 
        SceneManager.LoadScene("GameStart"); //스타트 신 전환
    }
}
