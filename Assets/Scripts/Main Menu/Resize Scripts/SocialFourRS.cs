using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocialFourRS : PageResize
{
    [Header("Social Story Four")]
    public GameObject Button;
    public override void Resize(float x, float y)
    {
        base.ResizeBaseButtons(x, y);

        RectTransform button = Button.GetComponent<RectTransform>();
        button.sizeDelta = new Vector2(x / 2, y / 10);
        button.localPosition = new Vector2(0, -y / 2.5f);
    }
}
