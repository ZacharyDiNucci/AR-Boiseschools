using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public int currectScene;
    public int Scene1;
    public int Scene2;
    public int Scene3;

    public void LoadScene1(){
        Debug.Log("Click");
        SceneManager.LoadScene(Scene1);
    }
    public void LoadScene2(){
        SceneManager.LoadScene(Scene2);
    }
    public void LoadScene3(){
        SceneManager.LoadScene(Scene3);
    }
}
