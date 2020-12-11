using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonManager : MonoBehaviour {
    public bool buttonPressed;
    public string objectName;
    public int HomeScene;

    public void ButtonPress(string name) {
        switch (name) {
            default:
                return;
            case "back":
                Menu.ChangeStartingPage("Begin");
                break;
            case "home":
                Menu.ChangeStartingPage("Login");
                break;
        }
        SceneManager.LoadScene(HomeScene);
    }
}