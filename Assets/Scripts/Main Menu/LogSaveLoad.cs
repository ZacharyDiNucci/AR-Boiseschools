using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogSaveLoad : MonoBehaviour
{
    public string name1Text;
    public string name2Text;
    public string name3Text;
    public GameObject name1Note;
    public GameObject name2Note;
    public GameObject name3Note;
    public GameObject name1PlaceHolder;
    public GameObject name2PlaceHolder;
    public GameObject name3PlaceHolder;

    void OnEnable()
    {
        name1Text = PlayerPrefs.GetString("Name1NoteContents");
        name1PlaceHolder.GetComponentInChildren<Text>().text = name1Text;

        name2Text = PlayerPrefs.GetString("Name2NoteContents");
        name2PlaceHolder.GetComponentInChildren<Text>().text = name2Text;

        name3Text = PlayerPrefs.GetString("Name3NoteContents");
        name3PlaceHolder.GetComponentInChildren<Text>().text = name3Text;
    }

    public void Name1SaveNote()
    {
        name1Text = name1Note.GetComponent<Text>().text;
        PlayerPrefs.SetString("Name1NoteContents", name1Text);
    }

    public void Name2SaveNote()
    {
        name2Text = name2Note.GetComponent<Text>().text;
        PlayerPrefs.SetString("Name2NoteContents", name2Text);
    }

    public void Name3SaveNote()
    {
        name3Text = name3Note.GetComponent<Text>().text;
        PlayerPrefs.SetString("Name3NoteContents", name3Text);
    }
}
