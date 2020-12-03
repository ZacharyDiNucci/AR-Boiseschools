using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour {
    [Header("State")]
    public GameObject current;
    public GameObject previous;

    [Header("Pages")]
    public GameObject login;
    public GameObject begin;
    public GameObject instructions;
    public GameObject teacherInstructions;
    public GameObject teacherLogs;
    public GameObject options;
    public GameObject teacherView;
    public GameObject teacherView2;
    public GameObject teacherView3;
    public GameObject socialOne;
    public GameObject socialTwo;
    public GameObject socialThree;
    public GameObject socialFour;

    protected static int startPage = 0;
    void Start() { // probably could write this better but na
        login.GetComponent<Transitions>().PageSize(Screen.width, Screen.height);
        begin.GetComponent<Transitions>().PageSize(Screen.width, Screen.height);
        instructions.GetComponent<Transitions>().PageSize(Screen.width, Screen.height);
        teacherInstructions.GetComponent<Transitions>().PageSize(Screen.width, Screen.height);
        teacherLogs.GetComponent<Transitions>().PageSize(Screen.width, Screen.height);
        options.GetComponent<Transitions>().PageSize(Screen.width, Screen.height);
        teacherView.GetComponent<Transitions>().PageSize(Screen.width, Screen.height);
        socialOne.GetComponent<Transitions>().PageSize(Screen.width, Screen.height);
        socialTwo.GetComponent<Transitions>().PageSize(Screen.width, Screen.height);
        socialThree.GetComponent<Transitions>().PageSize(Screen.width, Screen.height);
        socialFour.GetComponent<Transitions>().PageSize(Screen.width, Screen.height);

    }

    void OnEnable() {
        GameObject[] pages = { login, begin, instructions, teacherInstructions, teacherLogs, options, teacherView, socialOne, socialTwo, socialThree, socialFour };
        current = previous = pages[startPage];
        current.GetComponent<Transitions>().previous = previous;
        current.GetComponent<Transitions>().transition = "Blink";
        current.SetActive(true);
    }

    public void ChangeMenuScrene(string scene) {
        string[] types = scene.Split('-');
        string transition = types[1];
        Debug.Log(types[0] + ", " + types[1]);
        previous = current;
        switch (types[0]) {
            default:
                current = login;
                break;
            case "Login":
                current = login;
                break;
            case "Begin":
                current = begin;
                break;
            case "Instructions":
                current = instructions;
                break;
            case "TeacherInstructions":
                current = teacherInstructions;
                break;
            case "TeacherLogs":
                current = teacherLogs;
                break;
            case "Options":
                current = options;
                break;
            case "TeacherView":
                current = teacherView;
                break;
            case "TeacherView2":
                current = teacherView2;
                break;
            case "TeacherView3":
                current = teacherView3;
                break;
            case "SocialOne":
                current = socialOne;
                break;
            case "SocialTwo":
                current = socialTwo;
                break;
            case "SocialThree":
                current = socialThree;
                break;
            case "SocialFour":
                current = socialFour;
                break;
            case "Game":
                SceneManager.LoadScene("GameScene");
                //current = login;
                break;
        }

        Transitions transitions = current.GetComponent<Transitions>();
        transitions.previous = previous;
        transitions.transition = transition;
        current.SetActive(true);
    }

    public static void ChangeStartingPage(int page) {
        if (page > 8) startPage = 0;
        else startPage = page;
    }

    enum Convertion { Login = 0, Begin = 1, Instructions = 2, TeacherInstructions = 3, TeacherLogs = 4, Options = 5, TeacherView = 6, SocialOne = 7, SocialTwo = 8, SocialThree = 9, SocialFour = 10 };
    public static void ChangeStartingPage(string page) {
        try {
            Convertion testPage = (Convertion)System.Enum.Parse(typeof(Convertion), page, true);
            if (System.Enum.IsDefined(typeof(Convertion), testPage) | testPage.ToString().Contains(",")) startPage = (int)testPage;
            else startPage = 0;
        } catch {
            startPage = 0;
        }
    }
}