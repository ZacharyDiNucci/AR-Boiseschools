using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad3 : MonoBehaviour
{
    public string nameText;
    public string prefText;
    public string notesText;
    public string progText;
    public GameObject nameNote;
    public GameObject prefNote;
    public GameObject notesNote;
    public GameObject progNote;
    public GameObject namePlaceHolder;
    public GameObject prefPlaceHolder;
    public GameObject notesPlaceHolder;
    public GameObject progPlaceHolder;
    public GameObject saveAnim;

    void Start()
    {
        nameText = PlayerPrefs.GetString("Name3NoteContents");
        namePlaceHolder.GetComponent<InputField>().text = nameText;

        prefText = PlayerPrefs.GetString("Pref3NoteContents");
        prefPlaceHolder.GetComponent<InputField>().text = prefText;

        notesText = PlayerPrefs.GetString("Notes3NoteContents");
        notesPlaceHolder.GetComponent<InputField>().text = notesText;

        progText = PlayerPrefs.GetString("Prog3NoteContents");
        progPlaceHolder.GetComponent<InputField>().text = progText;
    }

    public void NameSaveNote()
    {
        nameText = nameNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("Name3NoteContents", nameText);
        StartCoroutine(SaveTextRoll());
    }

    public void PrefSaveNote()
    {
        prefText = prefNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("Pref3NoteContents", prefText);
        StartCoroutine(SaveTextRoll());
    }

    public void NotesSaveNote()
    {
        notesText = notesNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("Notes3NoteContents", notesText);
        StartCoroutine(SaveTextRoll());
    }

    public void ProgSaveNote()
    {
        progText = progNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("Prog3NoteContents", progText);
        StartCoroutine(SaveTextRoll());
    }

    IEnumerator SaveTextRoll()
    {
        saveAnim.GetComponent<Animator>().Play("SavedAnim");
        yield return new WaitForSeconds(1);
        saveAnim.GetComponent<Animator>().Play("New State");
    }
}
