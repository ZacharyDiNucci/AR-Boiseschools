using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginResize : PageResize {
    [Header("Begin Buttons")]
    public GameObject buttonContainer;
    public GameObject[] buttons;
    public override void Resize(float x, float y) {
        base.ResizeBaseButtons(x, y);

        buttonContainer.GetComponent<RectTransform>().localPosition = new Vector2(0, -y / 20);

        for (int i = 0; i < buttons.Length; i++) {
            RectTransform rect = buttons[i].GetComponent<RectTransform>();
            rect.sizeDelta = new Vector2(x * 2 / 3, y / 10);
            switch (i){
                case 0:
                    rect.localPosition = new Vector2(0, y / 8);
                    break;
                case 1:
                    rect.localPosition = new Vector2(0, -y / 8);
                    break;
            }
        }
    }
}
