using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad2 : MonoBehaviour
{
    public string name2Text;
    public string pref2Text;
    public string notes2Text;
    public string prog2Text;
    public GameObject name2Note;
    public GameObject pref2Note;
    public GameObject notes2Note;
    public GameObject prog2Note;
    public GameObject name2PlaceHolder;
    public GameObject pref2PlaceHolder;
    public GameObject notes2PlaceHolder;
    public GameObject prog2PlaceHolder;
    public GameObject saveAnim2;

    void Start()
    {
        name2Text = PlayerPrefs.GetString("Name2NoteContents");
        name2PlaceHolder.GetComponent<InputField>().text = name2Text;

        pref2Text = PlayerPrefs.GetString("Pref2NoteContents");
        pref2PlaceHolder.GetComponent<InputField>().text = pref2Text;

        notes2Text = PlayerPrefs.GetString("Notes2NoteContents");
        notes2PlaceHolder.GetComponent<InputField>().text = notes2Text;

        prog2Text = PlayerPrefs.GetString("Prog2NoteContents");
        prog2PlaceHolder.GetComponent<InputField>().text = prog2Text;
    }

    public void NameSaveNote()
    {
        name2Text = name2Note.GetComponent<Text>().text;
        PlayerPrefs.SetString("Name2NoteContents", name2Text);
        StartCoroutine(SaveTextRoll());
    }

    public void PrefSaveNote()
    {
        pref2Text = pref2Note.GetComponent<Text>().text;
        PlayerPrefs.SetString("Pref2NoteContents", pref2Text);
        StartCoroutine(SaveTextRoll());
    }

    public void NotesSaveNote()
    {
        notes2Text = notes2Note.GetComponent<Text>().text;
        PlayerPrefs.SetString("Notes2NoteContents", notes2Text);
        StartCoroutine(SaveTextRoll());
    }

    public void ProgSaveNote()
    {
        prog2Text = prog2Note.GetComponent<Text>().text;
        PlayerPrefs.SetString("Prog2NoteContents", prog2Text);
        StartCoroutine(SaveTextRoll());
    }

    IEnumerator SaveTextRoll()
    {
        saveAnim2.GetComponent<Animator>().Play("SavedAnim");
        yield return new WaitForSeconds(1);
        saveAnim2.GetComponent<Animator>().Play("New State");
    }
}
