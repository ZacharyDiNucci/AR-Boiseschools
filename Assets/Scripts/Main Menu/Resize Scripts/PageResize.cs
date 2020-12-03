using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageResize : MonoBehaviour {
    [Header("Base Buttons")]
    public GameObject homeButton;
    public GameObject backButton;

    public virtual void Resize(float x, float y) {
        ResizeBaseButtons(x, y);
    }

    public void ResizeBaseButtons(float x, float y) {
        RectTransform home = homeButton.GetComponent<RectTransform>();
        RectTransform back = backButton.GetComponent<RectTransform>();

        home.localPosition = new Vector2(x / 2 - home.sizeDelta.x, y / 2 - home.sizeDelta.y);
        back.localPosition = new Vector2(-x / 2 + back.sizeDelta.x, y / 2 - back.sizeDelta.y);
    }
}