using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionResize : PageResize {
    [Header("Panel")]
    public GameObject Slider;
    public override void Resize(float x, float y) {
        base.ResizeBaseButtons(x, y);
        Slider.GetComponent<RectTransform>().localScale = new Vector2(x / 741, x / 741);
    }
}
