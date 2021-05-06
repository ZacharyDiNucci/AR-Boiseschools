using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private List<GameObject> pages;
    private string previousPage;

    [SerializeField] private VideoPlayer video;

    [SerializeField] private AudioClip click;
    private AudioSource source;

    private void Start() {
        source = GetComponent<AudioSource>();
    }

    public void UpdateMenu(string name){
        source.Stop();
        source.PlayOneShot(click);

        foreach (GameObject g in pages) {
            if (g.name == name) {
                g.SetActive(true);
            }
            else {
                g.SetActive(false);
            }
        }
    }

    public void SwitchScene(int scene) {
        SceneManager.LoadScene(scene);
    }

    public void EnterSettings(string name) {
        source.Stop();
        source.PlayOneShot(click);

        previousPage = name;

        foreach (GameObject g in pages) {
            if (g.name == "Settings") {
                g.SetActive(true);
            }
            else {
                g.SetActive(false);
            }
        }


    }

    public void LeaveSettings() {
        source.Stop();
        source.PlayOneShot(click);

        foreach (GameObject g in pages) {
            if (g.name == previousPage) {
                g.SetActive(true);
            }
            else {
                g.SetActive(false);
            }
        }
    }

    public void ReadDescription(AudioClip clip) {
        source.PlayOneShot(clip);
    }

    public void ChangeVideoClip(VideoClip clip) {
        video.clip = clip;
    }
}
