using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
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
        nameText = PlayerPrefs.GetString("Name1NoteContents");
        namePlaceHolder.GetComponent<InputField>().text = nameText;

        prefText = PlayerPrefs.GetString("PrefNoteContents");
        prefPlaceHolder.GetComponent<InputField>().text = prefText;

        notesText = PlayerPrefs.GetString("NotesNoteContents");
        notesPlaceHolder.GetComponent<InputField>().text = notesText;

        progText = PlayerPrefs.GetString("ProgNoteContents");
        progPlaceHolder.GetComponent<InputField>().text = progText;
    }

    public void NameSaveNote()
    {
        nameText = nameNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("Name1NoteContents", nameText);
        StartCoroutine(SaveTextRoll());
    }

    public void PrefSaveNote()
    {
        prefText = prefNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("PrefNoteContents", prefText);
        StartCoroutine(SaveTextRoll());
    }

    public void NotesSaveNote()
    {
        notesText = notesNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("NotesNoteContents", notesText);
        StartCoroutine(SaveTextRoll());
    }

    public void ProgSaveNote()
    {
        progText = progNote.GetComponent<Text>().text;
        PlayerPrefs.SetString("ProgNoteContents", progText);
        StartCoroutine(SaveTextRoll());
    }

    IEnumerator SaveTextRoll()
    {
        saveAnim.GetComponent<Animator>().Play("SavedAnim");
        yield return new WaitForSeconds(1);
        saveAnim.GetComponent<Animator>().Play("New State");
    }
}
