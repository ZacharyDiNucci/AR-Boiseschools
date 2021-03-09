using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public GameObject currentScene;
    public GameObject previousScene;
    
    protected static int startPage = 0;
    public int ARScene1;
    public int ARScene2;
    public int ARScene3;

    public GameObject titlePanel;
    public GameObject arPanel;
    public GameObject arDescPanel1;
    public GameObject arDescPanel2;
    public GameObject arDescPanel3;

    void OnEnable(){
        GameObject[] pages ={titlePanel, arPanel, arDescPanel1, arDescPanel2, arDescPanel3};
        currentScene = previousScene = pages[startPage];
        currentScene.SetActive(true);
    }

    public void UpdateMenu(string scene){
        previousScene = currentScene;
        string[] types = scene.Split('-');
        switch (types[0]) {
            default:
                currentScene = titlePanel;

                break;
            case "Login":
                currentScene = titlePanel;
                break;
            case "AR":
                currentScene = arPanel;
                break;
            case "ARDescPanel1":
                currentScene = arDescPanel1;
                break;
            case "ARDescPanel2":
                currentScene = arDescPanel2;
                break;
            case "ARDescPanel3":
                currentScene = arDescPanel3;
                break;
            case "ARGame1":
                SceneManager.LoadScene(ARScene1);
                break;
            case "ARGame2":
                SceneManager.LoadScene(ARScene2);
                break;
            case "ARGame3":
                SceneManager.LoadScene(ARScene3);
                break;
        }
        currentScene.SetActive(true);
        previousScene.SetActive(false);
    }
    /*public void LoadScene1(){
        Debug.Log("Click");
        SceneManager.LoadScene(ARScene1);
    }
    public void LoadScene2(){
        SceneManager.LoadScene(ARScene2);
    }
    public void LoadScene3(){
        SceneManager.LoadScene(ARScene3);
    }*/
}
