using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transitions : MonoBehaviour {
    [Header("Setup")]
    public PageResize superScript;

    [Header("Transition Variables")]
    public GameObject foreground;
    public GameObject background;
    public GameObject previous;
    public string transition;

    private bool animating = false;
    private float[] duration = { 0, 0 };
    private Vector2 startPosition;

    void OnEnable() {
        foreground.SetActive(false);
        Setup();
    }

    public void PageSize(float x, float y) {
        background.GetComponent<RectTransform>().sizeDelta = new Vector2(x, y);
        foreground.GetComponent<RectTransform>().sizeDelta = new Vector2(x, y);
        if (superScript != null) superScript.Resize(x, y);
    }

    private void AnimateBack() {
        Vector2 prevPos = Vector2.Lerp(new Vector2(0, 0), new Vector2(Screen.width / 2, 0), duration[0] / duration[1]);
        Vector2 currPos = Vector2.Lerp(startPosition, new Vector2(0, 0), duration[0] / duration[1]);

        previous.GetComponent<RectTransform>().localPosition = prevPos;
        this.GetComponent<RectTransform>().localPosition = currPos;

        previous.GetComponent<Transitions>().foreground.GetComponent<Image>().color = new Color(0, 0, 0, 3 * duration[0] / (duration[1] * 5));
    }

    private void AnimateFade() {

    }

    private void AnimateSwipe() {
        Vector2 prevPos = Vector2.Lerp(new Vector2(0, 0), new Vector2(-Screen.width, 0), duration[0] / duration[1]);
        Vector2 currPos = Vector2.Lerp(startPosition, new Vector2(0, 0), duration[0] / duration[1]);

        previous.GetComponent<RectTransform>().localPosition = prevPos;
        this.GetComponent<RectTransform>().localPosition = currPos;
    }

    private void Setup() {
        this.GetComponent<RectTransform>().localPosition = new Vector2(0, 0);
        previous.GetComponent<Transitions>().foreground.SetActive(false);
        this.transform.SetAsLastSibling();
        duration = new float[] { 0, 0.2f };
        foreground.SetActive(true);
        animating = true;

        switch (transition) {
            default:
            case "Blink":
                duration[0] = duration[1];
                break;
            case "Fade":
                this.transform.SetAsFirstSibling();
                break;
            case "Swipe":
                this.GetComponent<RectTransform>().localPosition = new Vector2(Screen.width, 0);
                previous.GetComponent<Transitions>().foreground.SetActive(true);
                startPosition = new Vector2(Screen.width, 0);
                break;
            case "Back":
                this.GetComponent<RectTransform>().localPosition = new Vector2(-Screen.width, 0);
                previous.GetComponent<Transitions>().foreground.SetActive(true);
                startPosition = new Vector2(-Screen.width, 0);
                break;
        }
    }

    void Update() {
        if (!animating) return;

        duration[0] = (duration[0] >= duration[1]) ? duration[1] : duration[0] + Time.deltaTime;

        switch (transition) {
            default:
                duration[0] = duration[1];
                break;
            case "Fade":
                AnimateFade();
                break;
            case "Swipe":
                AnimateSwipe();
                break;
            case "Back":
                AnimateBack();
                break;
        }

        if (duration[0] == duration[1]) {
            previous.GetComponent<Transitions>().foreground.SetActive(false);
            foreground.SetActive(false);
            if (this.gameObject != previous) previous.SetActive(false);
            previous.GetComponent<Transitions>().foreground.GetComponent<Image>().color = new Color(0, 0, 0, 0);
            animating = false;
        }
    }
}