using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeachLogResize : PageResize {

    [Header("Student Buttons")]
    public GameObject Buttons;

    public override void Resize(float x, float y) {
        base.ResizeBaseButtons(x, y);
        ResizeButtons(x,y);
    }

    public void ResizeButtons(float x, float y) { // i really could / should do this better but eh
        RectTransform[] allButtons = Buttons.GetComponentsInChildren<RectTransform>();

        RectTransform[] buttons = new RectTransform[allButtons.Length];
        int index = 0;
        for (int j = 1; j < buttons.Length; j++) {
            if (allButtons[j].gameObject.name == "Text" || allButtons[j].gameObject.name == "Buttons") continue;
            else {
                buttons[index] = allButtons[j];
                index++;
            }
        }

        for (int i = 0; i < buttons.Length; i++) {
            if (buttons[i] == null) break;
            buttons[i].sizeDelta = new Vector2(x * 2 / 3, y / 10);
            buttons[i].localPosition = new Vector2(0, -y * i / 8);
        }

        Buttons.GetComponent<RectTransform>().localPosition = new Vector2(0, y / 10);
    }
}