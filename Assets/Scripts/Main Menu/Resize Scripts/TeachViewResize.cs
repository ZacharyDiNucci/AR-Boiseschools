using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeachViewResize : PageResize {
    [Header("Unique")]
    public GameObject saveButton;

    [Header("Inputs")]
    public GameObject Preferences;
    public GameObject Notes;
    public GameObject Progress;

    public override void Resize(float x, float y) {
        base.ResizeBaseButtons(x, y);

        RectTransform save = saveButton.GetComponent<RectTransform>();
        save.localPosition = new Vector2(x / 2 - save.sizeDelta.x * 2, y / 2 - save.sizeDelta.y);


        GameObject[] objects = { Preferences, Notes, Progress };
        for (int i = 0; i < objects.Length; i++) {
            RectTransform rect = objects[i].GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(x / 2, 100);
        }
    }
}